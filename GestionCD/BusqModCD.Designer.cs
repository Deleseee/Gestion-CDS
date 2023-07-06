namespace GestionCD
{
    partial class BusqModCD
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
            this.discografica = new System.Windows.Forms.TextBox();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.pais = new System.Windows.Forms.TextBox();
            this.autor = new System.Windows.Forms.TextBox();
            this.titulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.img = new System.Windows.Forms.PictureBox();
            this.listacds = new System.Windows.Forms.ListBox();
            this.modificar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cd = new System.Windows.Forms.CheckBox();
            this.baja = new System.Windows.Forms.RadioButton();
            this.vinilo = new System.Windows.Forms.CheckBox();
            this.prestado = new System.Windows.Forms.RadioButton();
            this.casa = new System.Windows.Forms.RadioButton();
            this.cerrar = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.imagen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            this.SuspendLayout();
            // 
            // discografica
            // 
            this.discografica.Enabled = false;
            this.discografica.Location = new System.Drawing.Point(423, 220);
            this.discografica.Name = "discografica";
            this.discografica.Size = new System.Drawing.Size(100, 20);
            this.discografica.TabIndex = 6;
            // 
            // fecha
            // 
            this.fecha.Enabled = false;
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(423, 169);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(100, 20);
            this.fecha.TabIndex = 4;
            // 
            // pais
            // 
            this.pais.Enabled = false;
            this.pais.Location = new System.Drawing.Point(423, 196);
            this.pais.Name = "pais";
            this.pais.Size = new System.Drawing.Size(100, 20);
            this.pais.TabIndex = 5;
            // 
            // autor
            // 
            this.autor.Enabled = false;
            this.autor.Location = new System.Drawing.Point(423, 143);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(100, 20);
            this.autor.TabIndex = 3;
            // 
            // titulo
            // 
            this.titulo.Enabled = false;
            this.titulo.Location = new System.Drawing.Point(423, 117);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(100, 20);
            this.titulo.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(278, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Discografica: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(278, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Pais: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(278, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Fecha de compra: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(278, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Autor/Titulo: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(278, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Titulo:";
            // 
            // img
            // 
            this.img.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.img.Location = new System.Drawing.Point(264, 281);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(110, 99);
            this.img.TabIndex = 22;
            this.img.TabStop = false;
            // 
            // listacds
            // 
            this.listacds.FormattingEnabled = true;
            this.listacds.Location = new System.Drawing.Point(38, 59);
            this.listacds.Name = "listacds";
            this.listacds.Size = new System.Drawing.Size(150, 290);
            this.listacds.TabIndex = 1;
            this.listacds.SelectedIndexChanged += new System.EventHandler(this.listacds_SelectedIndexChanged);
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(615, 158);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(75, 23);
            this.modificar.TabIndex = 14;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Visible = false;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cd);
            this.groupBox1.Controls.Add(this.baja);
            this.groupBox1.Controls.Add(this.vinilo);
            this.groupBox1.Controls.Add(this.prestado);
            this.groupBox1.Controls.Add(this.casa);
            this.groupBox1.Location = new System.Drawing.Point(423, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // cd
            // 
            this.cd.AutoSize = true;
            this.cd.Enabled = false;
            this.cd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cd.Location = new System.Drawing.Point(46, 31);
            this.cd.Name = "cd";
            this.cd.Size = new System.Drawing.Size(41, 17);
            this.cd.TabIndex = 7;
            this.cd.Text = "CD";
            this.cd.UseVisualStyleBackColor = true;
            // 
            // baja
            // 
            this.baja.AutoSize = true;
            this.baja.Enabled = false;
            this.baja.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.baja.Location = new System.Drawing.Point(142, 61);
            this.baja.Name = "baja";
            this.baja.Size = new System.Drawing.Size(46, 17);
            this.baja.TabIndex = 11;
            this.baja.Text = "Baja";
            this.baja.UseVisualStyleBackColor = true;
            // 
            // vinilo
            // 
            this.vinilo.AutoSize = true;
            this.vinilo.Enabled = false;
            this.vinilo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.vinilo.Location = new System.Drawing.Point(98, 31);
            this.vinilo.Name = "vinilo";
            this.vinilo.Size = new System.Drawing.Size(51, 17);
            this.vinilo.TabIndex = 8;
            this.vinilo.Text = "Vinilo";
            this.vinilo.UseVisualStyleBackColor = true;
            // 
            // prestado
            // 
            this.prestado.AutoSize = true;
            this.prestado.Enabled = false;
            this.prestado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.prestado.Location = new System.Drawing.Point(69, 61);
            this.prestado.Name = "prestado";
            this.prestado.Size = new System.Drawing.Size(67, 17);
            this.prestado.TabIndex = 0;
            this.prestado.Text = "Prestado";
            this.prestado.UseVisualStyleBackColor = true;
            // 
            // casa
            // 
            this.casa.AutoSize = true;
            this.casa.Enabled = false;
            this.casa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.casa.Location = new System.Drawing.Point(14, 61);
            this.casa.Name = "casa";
            this.casa.Size = new System.Drawing.Size(49, 17);
            this.casa.TabIndex = 9;
            this.casa.Text = "Casa";
            this.casa.UseVisualStyleBackColor = true;
            // 
            // cerrar
            // 
            this.cerrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cerrar.Location = new System.Drawing.Point(615, 196);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(75, 23);
            this.cerrar.TabIndex = 15;
            this.cerrar.Text = "Cerrar";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(615, 113);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(75, 23);
            this.guardar.TabIndex = 13;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Visible = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // imagen
            // 
            this.imagen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imagen.Location = new System.Drawing.Point(273, 252);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(93, 23);
            this.imagen.TabIndex = 12;
            this.imagen.Text = "Buscar imagen";
            this.imagen.UseVisualStyleBackColor = true;
            this.imagen.Visible = false;
            this.imagen.Click += new System.EventHandler(this.imagen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // BusqModCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imagen);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.listacds);
            this.Controls.Add(this.img);
            this.Controls.Add(this.discografica);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.pais);
            this.Controls.Add(this.autor);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BusqModCD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda/Modificacion CD";
            this.Load += new System.EventHandler(this.BusqModCD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox discografica;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.TextBox pais;
        private System.Windows.Forms.TextBox autor;
        private System.Windows.Forms.TextBox titulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.ListBox listacds;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cd;
        private System.Windows.Forms.RadioButton baja;
        private System.Windows.Forms.CheckBox vinilo;
        private System.Windows.Forms.RadioButton prestado;
        private System.Windows.Forms.RadioButton casa;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Button imagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
    }
}