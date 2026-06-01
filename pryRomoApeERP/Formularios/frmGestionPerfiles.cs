using pryRomoApeERP.Base_de_Datos;
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

        public frmGestionPerfiles(string mail = "")
        {
            InitializeComponent();
            mailUsuario = mail;
            InicializarConexion();
        }

        private void InicializarConexion()
        {
            try
            {
                archivoBD = new Archivo("Romo.accdb");
                
                if (archivoBD.Conexion != null && archivoBD.Conexion.EstaConectado)
                {
                    tablaPerfilesAcceso = new tablaPerfil(archivoBD.Conexion);
                    tablaUsuariosAcceso = new tablaUsuario(archivoBD.Conexion);
                    auditoria = new RegistroAuditoria(archivoBD.Conexion);
                    
                    CargarPerfilesDisponibles();
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
                
                List<PerfilInfo> perfiles = tablaPerfilesAcceso.ObtenerTodosPerfiles();
                
                foreach (PerfilInfo perfil in perfiles)
                {
                    lstPerfiles.Items.Add(perfil.Nombre, false);
                }

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

        private void CargarPerfilesUsuario()
        {
            try
            {
                List<PerfilInfo> perfilesUsuario = tablaPerfilesAcceso.ObtenerPerfilesUsuario(mailUsuario);
                
                for (int i = 0; i < lstPerfiles.Items.Count; i++)
                {
                    string nombrePerfil = lstPerfiles.Items[i].ToString();
                    
                    bool tieneEstePerfil = perfilesUsuario.Exists(p => p.Nombre == nombrePerfil);
                    lstPerfiles.SetItemChecked(i, tieneEstePerfil);
                }
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
                if (string.IsNullOrWhiteSpace(txtMailAniadirPerfil.Text))
                {
                    MessageBox.Show("Por favor ingrese un mail de usuario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string mailNuevo = txtMailAniadirPerfil.Text.Trim();

                // Verificar que el usuario exista
                if (!tablaUsuariosAcceso.UsuarioExiste(mailNuevo))
                {
                    MessageBox.Show("El usuario no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener el perfil seleccionado
                int perfilSeleccionado = -1;
                for (int i = 0; i < lstPerfiles.Items.Count; i++)
                {
                    if (lstPerfiles.GetItemChecked(i))
                    {
                        string nombrePerfil = lstPerfiles.Items[i].ToString();
                        List<PerfilInfo> perfiles = tablaPerfilesAcceso.ObtenerTodosPerfiles();
                        
                        foreach (PerfilInfo perfil in perfiles)
                        {
                            if (perfil.Nombre == nombrePerfil)
                            {
                                perfilSeleccionado = perfil.IdPerfil;
                                break;
                            }
                        }
                        
                        if (perfilSeleccionado != -1)
                            break;
                    }
                }

                if (perfilSeleccionado == -1)
                {
                    MessageBox.Show("Por favor seleccione un perfil para asignar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (tablaPerfilesAcceso.AsignarPerfilUsuario(mailNuevo, perfilSeleccionado))
                {
                    auditoria.RegistrarAccion(mailUsuario, $"Asignó perfil al usuario {mailNuevo}");
                    MessageBox.Show("Perfil asignado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMailAniadirPerfil.Clear();
                    CargarPerfilesDisponibles();
                }
                else
                {
                    MessageBox.Show("Error al asignar el perfil.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar perfil:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtMailAniadirPerfil_TextChanged(object sender, EventArgs e)
        {
            // Evento para cambios en el TextBox del mail
        }
    }
}
