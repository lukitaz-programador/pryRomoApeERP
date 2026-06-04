namespace pryRomoApeERP.Funciones
{
    partial class frmAcercaDe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcercaDe));
            this.lblInfo = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrReloj = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInfo.Enabled = false;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblInfo.Location = new System.Drawing.Point(21, 55);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(355, 187);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = resources.GetString("lblInfo.Text");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario,
            this.lblConexion,
            this.lblFecha});
            this.statusStrip1.Location = new System.Drawing.Point(0, 282);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(397, 26);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(157, 21);
            this.lblUsuario.Text = "toolStripStatusLabel1";
            // 
            // lblConexion
            // 
            this.lblConexion.Name = "lblConexion";
            this.lblConexion.Size = new System.Drawing.Size(157, 21);
            this.lblConexion.Text = "toolStripStatusLabel3";
            // 
            // lblFecha
            // 
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(157, 21);
            this.lblFecha.Text = "toolStripStatusLabel4";
            // 
            // tmrReloj
            // 
            this.tmrReloj.Interval = 1000;
            // 
            // frmAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(397, 308);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acerca De";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblConexion;
        private System.Windows.Forms.ToolStripStatusLabel lblFecha;
        private System.Windows.Forms.Timer tmrReloj;
    }
}