using System.Drawing;
using System.Windows.Forms;

namespace pryRomoApeERP.Utilidades
{
    public static class InterfazHelper
    {
        private static readonly Color FondoFormulario =
            SystemColors.GradientInactiveCaption;

        private static readonly Color FondoGrupo =
            SystemColors.GradientActiveCaption;

        private static readonly Color BordeCampo =
            Color.FromArgb(170, 190, 210);

        public static void AplicarEstiloProfesional(Form formulario)
        {
            formulario.BackColor = FondoFormulario;
            formulario.Font = new Font("Segoe UI", 9F);

            AplicarEstiloControles(formulario.Controls);
        }

        public static void ConfigurarEnterComoTab(Form formulario)
        {
            ConfigurarEnterEnControles(formulario, formulario.Controls);
        }

        private static void AplicarEstiloControles(Control.ControlCollection controles)
        {
            foreach (Control control in controles)
            {
                if (control is GroupBox grupo)
                {
                    grupo.BackColor = FondoGrupo;
                    grupo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                }
                else if (control is Label etiqueta)
                {
                    etiqueta.Font = new Font("Segoe UI", 9F);
                    etiqueta.ForeColor = Color.FromArgb(35, 45, 55);
                }
                else if (control is TextBox texto)
                {
                    texto.BorderStyle = BorderStyle.FixedSingle;
                    texto.BackColor = Color.White;
                }
                else if (control is MaskedTextBox mascara)
                {
                    mascara.BorderStyle = BorderStyle.FixedSingle;
                    mascara.BackColor = Color.White;
                }
                else if (control is ComboBox combo)
                {
                    combo.FlatStyle = FlatStyle.Flat;
                    combo.BackColor = Color.White;
                }
                else if (control is Button boton)
                {
                    boton.FlatStyle = FlatStyle.Flat;
                    boton.FlatAppearance.BorderColor = BordeCampo;
                    boton.FlatAppearance.BorderSize = 1;
                    boton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                }
                else if (control is ListBox lista)
                {
                    lista.BorderStyle = BorderStyle.FixedSingle;
                    lista.BackColor = Color.White;
                }
                else if (control is DataGridView grilla)
                {
                    grilla.BackgroundColor = Color.White;
                    grilla.BorderStyle = BorderStyle.None;
                    grilla.EnableHeadersVisualStyles = false;
                    grilla.ColumnHeadersDefaultCellStyle.BackColor =
                        Color.FromArgb(204, 224, 244);
                    grilla.ColumnHeadersDefaultCellStyle.ForeColor =
                        Color.FromArgb(25, 35, 45);
                    grilla.ColumnHeadersDefaultCellStyle.Font =
                        new Font("Segoe UI", 9F, FontStyle.Bold);
                    grilla.DefaultCellStyle.Font =
                        new Font("Segoe UI", 9F);
                    grilla.AlternatingRowsDefaultCellStyle.BackColor =
                        Color.FromArgb(245, 249, 252);
                    grilla.RowHeadersVisible = false;
                    grilla.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.Fill;
                    grilla.SelectionMode =
                        DataGridViewSelectionMode.FullRowSelect;
                    grilla.ReadOnly = true;
                }
                else if (control is StatusStrip barra)
                {
                    barra.BackColor = Color.FromArgb(225, 235, 245);
                    barra.Font = new Font("Segoe UI", 9F);
                }
                else if (control is MenuStrip menu)
                {
                    menu.BackColor = FondoGrupo;
                    menu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    menu.RenderMode = ToolStripRenderMode.Professional;
                }

                if (control.HasChildren)
                {
                    AplicarEstiloControles(control.Controls);
                }
            }
        }

        private static void ConfigurarEnterEnControles(
            Form formulario,
            Control.ControlCollection controles)
        {
            foreach (Control control in controles)
            {
                if (control is TextBox ||
                    control is MaskedTextBox ||
                    control is ComboBox ||
                    control is CheckBox ||
                    control is CheckedListBox)
                {
                    control.KeyDown += (sender, e) =>
                    {
                        if (e.KeyCode == Keys.Enter)
                        {
                            e.SuppressKeyPress = true;
                            formulario.SelectNextControl(
                                (Control)sender,
                                true,
                                true,
                                true,
                                true);
                        }
                    };
                }

                if (control.HasChildren)
                {
                    ConfigurarEnterEnControles(formulario, control.Controls);
                }
            }
        }
    }
}
