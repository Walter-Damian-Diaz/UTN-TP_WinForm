﻿
namespace ventanaArticulos
{
    partial class FrmNuevoArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevoArticulo));
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.textBoxImagen = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBoxMinimizar = new System.Windows.Forms.PictureBox();
            this.tituloVentana = new System.Windows.Forms.Label();
            this.pictureBoxCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxVerImagen = new System.Windows.Forms.PictureBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVerImagen)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(51, 142);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(48, 23);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo: ";
            // 
            // lblNombre
            // 
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(47, 165);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(52, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(31, 218);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(68, 19);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion: ";
            // 
            // textBoxImagen
            // 
            this.textBoxImagen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxImagen.Location = new System.Drawing.Point(102, 191);
            this.textBoxImagen.Name = "textBoxImagen";
            this.textBoxImagen.Size = new System.Drawing.Size(100, 20);
            this.textBoxImagen.TabIndex = 2;
            this.textBoxImagen.Leave += new System.EventHandler(this.textBoxImagen_Leave);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNombre.Location = new System.Drawing.Point(102, 165);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDescripcion.Location = new System.Drawing.Point(102, 218);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescripcion.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnAceptar.Location = new System.Drawing.Point(0, 0);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(262, 38);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnCancelar.Location = new System.Drawing.Point(0, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(277, 38);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 40);
            this.panel2.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.Controls.Add(this.pictureBoxMinimizar);
            this.panel5.Controls.Add(this.tituloVentana);
            this.panel5.Controls.Add(this.pictureBoxCerrar);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(539, 27);
            this.panel5.TabIndex = 8;
            // 
            // pictureBoxMinimizar
            // 
            this.pictureBoxMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMinimizar.Image")));
            this.pictureBoxMinimizar.Location = new System.Drawing.Point(489, 0);
            this.pictureBoxMinimizar.Name = "pictureBoxMinimizar";
            this.pictureBoxMinimizar.Size = new System.Drawing.Size(27, 29);
            this.pictureBoxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMinimizar.TabIndex = 7;
            this.pictureBoxMinimizar.TabStop = false;
            this.pictureBoxMinimizar.Click += new System.EventHandler(this.pictureBoxMinimizar_Click);
            // 
            // tituloVentana
            // 
            this.tituloVentana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloVentana.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tituloVentana.Location = new System.Drawing.Point(204, 3);
            this.tituloVentana.Name = "tituloVentana";
            this.tituloVentana.Size = new System.Drawing.Size(137, 23);
            this.tituloVentana.TabIndex = 6;
            this.tituloVentana.Text = "Casa Hogar S.A";
            // 
            // pictureBoxCerrar
            // 
            this.pictureBoxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCerrar.Image")));
            this.pictureBoxCerrar.Location = new System.Drawing.Point(513, 0);
            this.pictureBoxCerrar.Name = "pictureBoxCerrar";
            this.pictureBoxCerrar.Size = new System.Drawing.Size(26, 27);
            this.pictureBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCerrar.TabIndex = 5;
            this.pictureBoxCerrar.TabStop = false;
            this.pictureBoxCerrar.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(660, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxVerImagen
            // 
            this.pictureBoxVerImagen.Location = new System.Drawing.Point(264, 146);
            this.pictureBoxVerImagen.Name = "pictureBoxVerImagen";
            this.pictureBoxVerImagen.Size = new System.Drawing.Size(157, 165);
            this.pictureBoxVerImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVerImagen.TabIndex = 15;
            this.pictureBoxVerImagen.TabStop = false;
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(102, 303);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(100, 21);
            this.comboBoxCategoria.TabIndex = 5;
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(102, 275);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(100, 21);
            this.comboBoxMarca.TabIndex = 4;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCodigo.Location = new System.Drawing.Point(102, 139);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigo.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Url Imagen: ";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Categoria: ";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Marca: ";
            // 
            // labelTitulo
            // 
            this.labelTitulo.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.Snow;
            this.labelTitulo.ImageKey = "(ninguno)";
            this.labelTitulo.Location = new System.Drawing.Point(31, 43);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(500, 53);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Agregar articulo";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 369);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(539, 44);
            this.panel3.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 38);
            this.panel1.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnAceptar);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(277, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(262, 38);
            this.panel6.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCancelar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(277, 38);
            this.panel4.TabIndex = 0;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPrecio.Location = new System.Drawing.Point(102, 246);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrecio.TabIndex = 16;
            this.textBoxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrecio_KeyPress);
            // 
            // labelPrecio
            // 
            this.labelPrecio.ForeColor = System.Drawing.Color.White;
            this.labelPrecio.Location = new System.Drawing.Point(55, 249);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(41, 20);
            this.labelPrecio.TabIndex = 17;
            this.labelPrecio.Text = "Precio: ";
            // 
            // FrmNuevoArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(539, 413);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.pictureBoxVerImagen);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.textBoxImagen);
            this.Controls.Add(this.textBoxDescripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmNuevoArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Casa Hogar S.A";
            this.Load += new System.EventHandler(this.FrmNuevoArticulo_Load);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVerImagen)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox textBoxImagen;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBoxVerImagen;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxCerrar;
        private System.Windows.Forms.Label tituloVentana;
        private System.Windows.Forms.PictureBox pictureBoxMinimizar;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label labelPrecio;
    }
}