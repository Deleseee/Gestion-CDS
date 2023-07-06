namespace GestionCD
{
    partial class CDNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CDNuevo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imagen = new System.Windows.Forms.Button();
            this.img = new System.Windows.Forms.PictureBox();
            this.titulo = new System.Windows.Forms.TextBox();
            this.autor = new System.Windows.Forms.TextBox();
            this.pais = new System.Windows.Forms.TextBox();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.discografica = new System.Windows.Forms.TextBox();
            this.guardar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cd = new System.Windows.Forms.CheckBox();
            this.vinilo = new System.Windows.Forms.CheckBox();
            this.casa = new System.Windows.Forms.RadioButton();
            this.prestado = new System.Windows.Forms.RadioButton();
            this.baja = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imagen
            // 
            resources.ApplyResources(this.imagen, "imagen");
            this.imagen.Name = "imagen";
            this.imagen.UseVisualStyleBackColor = true;
            this.imagen.Click += new System.EventHandler(this.imagen_Click);
            // 
            // img
            // 
            resources.ApplyResources(this.img, "img");
            this.img.Name = "img";
            this.img.TabStop = false;
            // 
            // titulo
            // 
            resources.ApplyResources(this.titulo, "titulo");
            this.titulo.Name = "titulo";
            // 
            // autor
            // 
            resources.ApplyResources(this.autor, "autor");
            this.autor.Name = "autor";
            // 
            // pais
            // 
            resources.ApplyResources(this.pais, "pais");
            this.pais.Name = "pais";
            // 
            // fecha
            // 
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.fecha, "fecha");
            this.fecha.Name = "fecha";
            // 
            // discografica
            // 
            resources.ApplyResources(this.discografica, "discografica");
            this.discografica.Name = "discografica";
            // 
            // guardar
            // 
            resources.ApplyResources(this.guardar, "guardar");
            this.guardar.Name = "guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // cancelar
            // 
            resources.ApplyResources(this.cancelar, "cancelar");
            this.cancelar.Name = "cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
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
            // cd
            // 
            resources.ApplyResources(this.cd, "cd");
            this.cd.Checked = true;
            this.cd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cd.Name = "cd";
            this.cd.UseVisualStyleBackColor = true;
            // 
            // vinilo
            // 
            resources.ApplyResources(this.vinilo, "vinilo");
            this.vinilo.Name = "vinilo";
            this.vinilo.UseVisualStyleBackColor = true;
            // 
            // casa
            // 
            resources.ApplyResources(this.casa, "casa");
            this.casa.Checked = true;
            this.casa.Name = "casa";
            this.casa.TabStop = true;
            this.casa.UseVisualStyleBackColor = true;
            // 
            // prestado
            // 
            resources.ApplyResources(this.prestado, "prestado");
            this.prestado.Name = "prestado";
            this.prestado.UseVisualStyleBackColor = true;
            // 
            // baja
            // 
            resources.ApplyResources(this.baja, "baja");
            this.baja.Name = "baja";
            this.baja.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cd);
            this.groupBox1.Controls.Add(this.baja);
            this.groupBox1.Controls.Add(this.vinilo);
            this.groupBox1.Controls.Add(this.prestado);
            this.groupBox1.Controls.Add(this.casa);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // CDNuevo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.discografica);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.pais);
            this.Controls.Add(this.autor);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.img);
            this.Controls.Add(this.imagen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CDNuevo";
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button imagen;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.TextBox titulo;
        private System.Windows.Forms.TextBox autor;
        private System.Windows.Forms.TextBox pais;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.TextBox discografica;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.RadioButton baja;
        private System.Windows.Forms.RadioButton prestado;
        private System.Windows.Forms.RadioButton casa;
        private System.Windows.Forms.CheckBox vinilo;
        private System.Windows.Forms.CheckBox cd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorProvider6;
    }
}