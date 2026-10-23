namespace AcaBiblioteca2
{
    partial class FrmLibros
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
            pnlTitulo = new Panel();
            lblTitulo = new Label();
            pnlBusqueda = new Panel();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            pnlDatos = new Panel();
            cmbEditorial = new ComboBox();
            cmbAutor = new ComboBox();
            txtExistencias = new TextBox();
            txtano = new TextBox();
            txtCategoria = new TextBox();
            txtTitulo = new TextBox();
            txtISBN = new TextBox();
            lblExistencias = new Label();
            lblAno = new Label();
            lblCategoria = new Label();
            lblEditorial = new Label();
            lblAutor = new Label();
            lblTituloLib = new Label();
            lblISBN = new Label();
            pnlTitulo.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            pnlDatos.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.SeaGreen;
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(800, 60);
            pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(234, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(293, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTIÓN DE LIBROS   ";
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = Color.WhiteSmoke;
            pnlBusqueda.Controls.Add(btnBuscar);
            pnlBusqueda.Controls.Add(txtBuscar);
            pnlBusqueda.Controls.Add(lblBuscar);
            pnlBusqueda.Dock = DockStyle.Top;
            pnlBusqueda.Location = new Point(0, 60);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(800, 55);
            pnlBusqueda.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(514, 19);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(90, 20);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar ";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(323, 16);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(148, 23);
            txtBuscar.TabIndex = 1;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscar.Location = new Point(181, 16);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(35, 15);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "ISBN";
            // 
            // pnlDatos
            // 
            pnlDatos.Controls.Add(cmbEditorial);
            pnlDatos.Controls.Add(cmbAutor);
            pnlDatos.Controls.Add(txtExistencias);
            pnlDatos.Controls.Add(txtano);
            pnlDatos.Controls.Add(txtCategoria);
            pnlDatos.Controls.Add(txtTitulo);
            pnlDatos.Controls.Add(txtISBN);
            pnlDatos.Controls.Add(lblExistencias);
            pnlDatos.Controls.Add(lblAno);
            pnlDatos.Controls.Add(lblCategoria);
            pnlDatos.Controls.Add(lblEditorial);
            pnlDatos.Controls.Add(lblAutor);
            pnlDatos.Controls.Add(lblTituloLib);
            pnlDatos.Controls.Add(lblISBN);
            pnlDatos.Dock = DockStyle.Top;
            pnlDatos.Location = new Point(0, 115);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(800, 245);
            pnlDatos.TabIndex = 2;
            // 
            // cmbEditorial
            // 
            cmbEditorial.FormattingEnabled = true;
            cmbEditorial.Location = new Point(323, 119);
            cmbEditorial.Name = "cmbEditorial";
            cmbEditorial.Size = new Size(148, 23);
            cmbEditorial.TabIndex = 16;
            // 
            // cmbAutor
            // 
            cmbAutor.FormattingEnabled = true;
            cmbAutor.Location = new Point(323, 90);
            cmbAutor.Name = "cmbAutor";
            cmbAutor.Size = new Size(148, 23);
            cmbAutor.TabIndex = 15;
            // 
            // txtExistencias
            // 
            txtExistencias.Location = new Point(323, 206);
            txtExistencias.Name = "txtExistencias";
            txtExistencias.Size = new Size(148, 23);
            txtExistencias.TabIndex = 14;
            // 
            // txtano
            // 
            txtano.Location = new Point(323, 177);
            txtano.Name = "txtano";
            txtano.Size = new Size(148, 23);
            txtano.TabIndex = 13;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(323, 148);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(148, 23);
            txtCategoria.TabIndex = 12;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(323, 61);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(148, 23);
            txtTitulo.TabIndex = 10;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(323, 23);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(148, 23);
            txtISBN.TabIndex = 3;
            // 
            // lblExistencias
            // 
            lblExistencias.AutoSize = true;
            lblExistencias.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblExistencias.Location = new Point(212, 206);
            lblExistencias.Name = "lblExistencias";
            lblExistencias.Size = new Size(76, 15);
            lblExistencias.TabIndex = 9;
            lblExistencias.Text = "Existencias : ";
            lblExistencias.Click += label1_Click;
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAno.Location = new Point(212, 177);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(38, 15);
            lblAno.TabIndex = 8;
            lblAno.Text = "Año : ";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCategoria.Location = new Point(212, 148);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(69, 15);
            lblCategoria.TabIndex = 7;
            lblCategoria.Text = "Categoria : ";
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEditorial.Location = new Point(212, 119);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(61, 15);
            lblEditorial.TabIndex = 6;
            lblEditorial.Text = "Editorial : ";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAutor.Location = new Point(212, 90);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(48, 15);
            lblAutor.TabIndex = 5;
            lblAutor.Text = "Autor : ";
            // 
            // lblTituloLib
            // 
            lblTituloLib.AutoSize = true;
            lblTituloLib.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTituloLib.Location = new Point(212, 61);
            lblTituloLib.Name = "lblTituloLib";
            lblTituloLib.Size = new Size(48, 15);
            lblTituloLib.TabIndex = 4;
            lblTituloLib.Text = "Titulo : ";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblISBN.Location = new Point(212, 23);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(44, 15);
            lblISBN.TabIndex = 3;
            lblISBN.Text = "ISBN : ";
            // 
            // FrmLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlDatos);
            Controls.Add(pnlBusqueda);
            Controls.Add(pnlTitulo);
            Name = "FrmLibros";
            Text = "FrmLibros";
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Panel pnlBusqueda;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private Panel pnlDatos;
        private Label lblISBN;
        private Label lblAutor;
        private Label lblTituloLib;
        private Label lblExistencias;
        private Label lblAno;
        private Label lblCategoria;
        private Label lblEditorial;
        private TextBox txtExistencias;
        private TextBox txtano;
        private TextBox txtCategoria;
        private TextBox txtTitulo;
        private TextBox txtISBN;
        private ComboBox cmbEditorial;
        private ComboBox cmbAutor;
    }
}