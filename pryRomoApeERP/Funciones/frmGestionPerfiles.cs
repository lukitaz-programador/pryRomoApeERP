using pryRomoApeERP.Base_de_Datos;
using pryRomoApeERP.Funciones.Login;
using pryRomoApeERP.Utilidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace pryRomoApeERP
{
    public partial class frmGestionPerfiles : Form
    {
        private string mailUsuario;
        private Archivo archivoBD;
        private tablaPerfil tablaPerfilesAcceso;
        private tablaUsuario tablaUsuariosAcceso;
        private RegistroAuditoria auditoria;
        private ConexionDB conexionBD;


        public frmGestionPerfiles(string mail = "")
        {
            InitializeComponent();
            mailUsuario =
                string.IsNullOrWhiteSpace(mail)
                ? Sesion.MailUsuario
                : mail;

            InterfazHelper.AplicarEstiloProfesional(this);
            InterfazHelper.ConfigurarEnterComoTab(this);
            InicializarConexion();
        }


        private void InicializarConexion()
        {
            try
            {
                archivoBD = new Archivo("RomoBD.accdb");

                if (archivoBD.Conexion != null && archivoBD.Conexion.EstaConectado)
                {
                    tablaPerfilesAcceso = new tablaPerfil(archivoBD.Conexion);
                    tablaUsuariosAcceso = new tablaUsuario(archivoBD.Conexion);
                    auditoria = new RegistroAuditoria(archivoBD.Conexion);

                    CargarPerfilesDisponibles();
                    CargarCorreosEnCombo();
                }
                else
                {
                    MessageBox.Show("Error al conectar con la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al inicializar conexión:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPerfilesDisponibles()
        {
            try
            {
                lstPerfiles.Items.Clear();

                // Cargar manualmente los perfiles solicitados
                lstPerfiles.Items.Add("Admin", false);
                lstPerfiles.Items.Add("Logis", false);
                lstPerfiles.Items.Add("Venta", false);
                lstPerfiles.Items.Add("Marke", false);
                lstPerfiles.Items.Add("RRHH", false);
                lstPerfiles.Items.Add("Conta", false);
                lstPerfiles.Items.Add("Basico", false);

                if (!string.IsNullOrWhiteSpace(mailUsuario))
                {
                    CargarPerfilesUsuario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar perfiles:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCorreosEnCombo()
        {
            try
            {
                cboMail.Items.Clear();

                List<UsuarioInfo> usuarios = tablaUsuariosAcceso.ObtenerTodosUsuarios();

                foreach (var u in usuarios)
                {
                    cboMail.Items.Add(u.Mail);
                }

                if (!string.IsNullOrWhiteSpace(mailUsuario))
                {
                    int index = cboMail.Items.IndexOf(mailUsuario);
                    if (index >= 0)
                        cboMail.SelectedIndex = index;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar correos:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPerfilesUsuario()
        {
            try
            {
                string mail = cboMail.SelectedItem != null ? cboMail.SelectedItem.ToString() : mailUsuario;

                if (string.IsNullOrWhiteSpace(mail))
                    return;

                List<PerfilInfo> perfilesUsuario = tablaPerfilesAcceso.ObtenerPerfilesUsuario(mail);

                for (int i = 0; i < lstPerfiles.Items.Count; i++)
                {
                    string nombrePerfil = lstPerfiles.Items[i].ToString();

                    bool tieneEstePerfil = perfilesUsuario.Exists(p => p.Nombre == nombrePerfil);
                    lstPerfiles.SetItemChecked(i, tieneEstePerfil);
                }

                auditoria?.RegistrarAccion(mailUsuario, $"Actualizó selección de perfiles para {mail}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar perfiles del usuario:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarPerfiles_Click(object sender, EventArgs e)
        {
            try
            {
                string mailNuevo = cboMail.SelectedItem != null ? cboMail.SelectedItem.ToString() : string.Empty;

                if (string.IsNullOrWhiteSpace(mailNuevo))
                {
                    MessageBox.Show("Por favor seleccione un mail de usuario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar que el usuario exista
                if (!tablaUsuariosAcceso.UsuarioExiste(mailNuevo))
                {
                    MessageBox.Show("El usuario no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool almenosUno = false;
                // Asignar o quitar perfiles en la base de datos según estado del CheckedListBox
                // Primero, para simplicidad, asignar perfiles seleccionados (solo asignaciones nuevas)
                for (int i = 0; i < lstPerfiles.Items.Count; i++)
                {
                    if (lstPerfiles.GetItemChecked(i))
                    {
                        almenosUno = true;
                        string nombrePerfil = lstPerfiles.Items[i].ToString();
                        int idPerfil = MapearNombreAIdPerfil(nombrePerfil);
                        if (idPerfil > 0)
                        {
                            tablaPerfilesAcceso.AsignarPerfilUsuario(mailNuevo, idPerfil);
                        }
                    }
                }

                if (!almenosUno)
                {
                    MessageBox.Show("Por favor seleccione al menos un perfil para asignar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                auditoria?.RegistrarAccion(mailUsuario, $"Asignó perfiles al usuario {mailNuevo}");
                MessageBox.Show("Perfiles procesados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarPerfilesDisponibles();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar perfil:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int MapearNombreAIdPerfil(string nombre)
        {
            switch (nombre)
            {
                case "Admin": return 1;
                case "Logis": return 2;
                case "Venta": return 3;
                case "Marke": return 4;
                case "RRHH": return 5;
                case "Conta": return 6;
                case "Basico": return 7;
                default: return -1;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la gestión de perfiles?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                auditoria.RegistrarAccion(mailUsuario, "Salió de la gestión de perfiles");

                if (archivoBD?.Conexion != null)
                {
                    archivoBD.Conexion.Desconectar();
                }

                frmPrincipal paso = new frmPrincipal(mailUsuario);
                paso.Show();
                this.Hide();
            }
        }

        private void cboMail_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Al seleccionar un correo, limpiar y marcar los perfiles correspondientes
            CargarPerfilesUsuario();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Actualizar marcación de perfiles de acuerdo al correo seleccionado
            CargarPerfilesUsuario();
        }

        private void frmGestionPerfiles_Load(object sender, EventArgs e)
        {
            if (!Seguridad.EsAdmin())
            {
                MessageBox.Show("No posee permisos.");
                this.Close();
            }
        }

        private void lstPerfiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
