namespace GestionCD
{
    partial class Gestioncd
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaModificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevo = new System.Windows.Forms.Button();
            this.busqMod = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.busquedaModificacionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // busquedaModificacionToolStripMenuItem
            // 
            this.busquedaModificacionToolStripMenuItem.Name = "busquedaModificacionToolStripMenuItem";
            this.busquedaModificacionToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
            this.busquedaModificacionToolStripMenuItem.Text = "Busqueda/Modificacion";
            this.busquedaModificacionToolStripMenuItem.Click += new System.EventHandler(this.busquedaModificacionToolStripMenuItem_Click);
            // 
            // nuevo
            // 
            this.nuevo.Location = new System.Drawing.Point(340, 173);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(132, 23);
            this.nuevo.TabIndex = 1;
            this.nuevo.Text = "Nuevo";
            this.nuevo.UseVisualStyleBackColor = true;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // busqMod
            // 
            this.busqMod.Location = new System.Drawing.Point(340, 224);
            this.busqMod.Name = "busqMod";
            this.busqMod.Size = new System.Drawing.Size(132, 23);
            this.busqMod.TabIndex = 2;
            this.busqMod.Text = "Busqueda/Modificacion";
            this.busqMod.UseVisualStyleBackColor = true;
            this.busqMod.Click += new System.EventHandler(this.busqMod_Click);
            // 
            // Gestioncd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.busqMod);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Gestioncd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion CD";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaModificacionToolStripMenuItem;
        private System.Windows.Forms.Button nuevo;
        private System.Windows.Forms.Button busqMod;
    }
}

