namespace cooperativa_presentacion_desktop
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.finanzasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sucursalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.finanzasToolStripMenuItem,
            this.entidadesToolStripMenuItem,
            this.seguridadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // finanzasToolStripMenuItem
            // 
            this.finanzasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentaToolStripMenuItem,
            this.creditoToolStripMenuItem,
            this.transaccionesToolStripMenuItem});
            this.finanzasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("finanzasToolStripMenuItem.Image")));
            this.finanzasToolStripMenuItem.Name = "finanzasToolStripMenuItem";
            this.finanzasToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.finanzasToolStripMenuItem.Text = "Finanzas";
            // 
            // cuentaToolStripMenuItem
            // 
            this.cuentaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cuentaToolStripMenuItem.Image")));
            this.cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            this.cuentaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cuentaToolStripMenuItem.Text = "Cuentas";
            // 
            // creditoToolStripMenuItem
            // 
            this.creditoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("creditoToolStripMenuItem.Image")));
            this.creditoToolStripMenuItem.Name = "creditoToolStripMenuItem";
            this.creditoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.creditoToolStripMenuItem.Text = "Creditos";
            this.creditoToolStripMenuItem.Click += new System.EventHandler(this.creditoToolStripMenuItem_Click);
            // 
            // transaccionesToolStripMenuItem
            // 
            this.transaccionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("transaccionesToolStripMenuItem.Image")));
            this.transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
            this.transaccionesToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.transaccionesToolStripMenuItem.Text = "Transacciones ";
            // 
            // entidadesToolStripMenuItem
            // 
            this.entidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personasToolStripMenuItem,
            this.sociosToolStripMenuItem,
            this.sucursalesToolStripMenuItem,
            this.tipoCuentaToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.usuariosToolStripMenuItem1});
            this.entidadesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("entidadesToolStripMenuItem.Image")));
            this.entidadesToolStripMenuItem.Name = "entidadesToolStripMenuItem";
            this.entidadesToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.entidadesToolStripMenuItem.Text = "Entidades";
            // 
            // personasToolStripMenuItem
            // 
            this.personasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("personasToolStripMenuItem.Image")));
            this.personasToolStripMenuItem.Name = "personasToolStripMenuItem";
            this.personasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personasToolStripMenuItem.Text = "Personas";
            this.personasToolStripMenuItem.Click += new System.EventHandler(this.personasToolStripMenuItem_Click);
            // 
            // sociosToolStripMenuItem
            // 
            this.sociosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sociosToolStripMenuItem.Image")));
            this.sociosToolStripMenuItem.Name = "sociosToolStripMenuItem";
            this.sociosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sociosToolStripMenuItem.Text = "Socios";
            this.sociosToolStripMenuItem.Click += new System.EventHandler(this.sociosToolStripMenuItem_Click);
            // 
            // sucursalesToolStripMenuItem
            // 
            this.sucursalesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sucursalesToolStripMenuItem.Image")));
            this.sucursalesToolStripMenuItem.Name = "sucursalesToolStripMenuItem";
            this.sucursalesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sucursalesToolStripMenuItem.Text = "Sucursales";
            this.sucursalesToolStripMenuItem.Click += new System.EventHandler(this.sucursalesToolStripMenuItem_Click);
            // 
            // tipoCuentaToolStripMenuItem
            // 
            this.tipoCuentaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tipoCuentaToolStripMenuItem.Image")));
            this.tipoCuentaToolStripMenuItem.Name = "tipoCuentaToolStripMenuItem";
            this.tipoCuentaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tipoCuentaToolStripMenuItem.Text = "Tipo Cuenta";
            this.tipoCuentaToolStripMenuItem.Click += new System.EventHandler(this.tipoCuentaToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("empleadosToolStripMenuItem.Image")));
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem});
            this.seguridadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("seguridadToolStripMenuItem.Image")));
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuariosToolStripMenuItem.Image")));
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // usuariosToolStripMenuItem1
            // 
            this.usuariosToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("usuariosToolStripMenuItem1.Image")));
            this.usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            this.usuariosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.usuariosToolStripMenuItem1.Text = "Usuarios";
            this.usuariosToolStripMenuItem1.Click += new System.EventHandler(this.usuariosToolStripMenuItem1_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem finanzasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sucursalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem1;
    }
}