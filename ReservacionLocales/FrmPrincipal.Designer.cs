
namespace ReservacionLocales
{
    partial class FrmPrincipal
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nenuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuRegistarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuconsultarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCerrarSecion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(52, 54);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(224, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nenuUsuarios,
            this.menuCerrarSecion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(421, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nenuUsuarios
            // 
            this.nenuUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuRegistarUsuario,
            this.subMenuconsultarUsuario});
            this.nenuUsuarios.Name = "nenuUsuarios";
            this.nenuUsuarios.Size = new System.Drawing.Size(164, 20);
            this.nenuUsuarios.Text = "Administracion de Usuarios";
            // 
            // subMenuRegistarUsuario
            // 
            this.subMenuRegistarUsuario.Name = "subMenuRegistarUsuario";
            this.subMenuRegistarUsuario.Size = new System.Drawing.Size(180, 22);
            this.subMenuRegistarUsuario.Text = "Registrar";
            this.subMenuRegistarUsuario.Click += new System.EventHandler(this.subMenuRegistarUsuario_Click);
            // 
            // subMenuconsultarUsuario
            // 
            this.subMenuconsultarUsuario.Name = "subMenuconsultarUsuario";
            this.subMenuconsultarUsuario.Size = new System.Drawing.Size(180, 22);
            this.subMenuconsultarUsuario.Text = "Consultar";
            this.subMenuconsultarUsuario.Click += new System.EventHandler(this.subMenuconsultarUsuario_Click);
            // 
            // menuCerrarSecion
            // 
            this.menuCerrarSecion.Name = "menuCerrarSecion";
            this.menuCerrarSecion.Size = new System.Drawing.Size(89, 20);
            this.menuCerrarSecion.Text = "Cerrar Secion";
            this.menuCerrarSecion.Click += new System.EventHandler(this.menuCerrarSecion_Click_1);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 98);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nenuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem subMenuRegistarUsuario;
        private System.Windows.Forms.ToolStripMenuItem subMenuconsultarUsuario;
        private System.Windows.Forms.ToolStripMenuItem menuCerrarSecion;
    }
}