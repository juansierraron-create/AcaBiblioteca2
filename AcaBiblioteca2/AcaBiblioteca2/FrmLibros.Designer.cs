using FontAwesome.Sharp;

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
            txtBuscarISBN = new TextBox();
            lblBuscar = new Label();
            pnlDatos = new Panel();
            cmbEditorial = new ComboBox();
            cmbAutor = new ComboBox();
            txtExistencias = new TextBox();
            txtAnio = new TextBox();
            txtCategoria = new TextBox();
            txtTitulo = new TextBox();
            txtISBN = new TextBox();
            lblExistencias = new Label();
            lblAnio = new Label();
            lblCategoria = new Label();
            lblEditorial = new Label();
            lblAutor = new Label();
            lblTituloLib = new Label();
            lblISBN = new Label();
            PnlBotones = new Panel();
            btnCancelar = new IconButton();
            btnEliminar = new IconButton();
            btnEditar = new IconButton();
            btnGuardar = new IconButton();
            btnNuevo = new IconButton();
            dgvLibros = new DataGridView();
            pnlTitulo.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            pnlDatos.SuspendLayout();
            PnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.SeaGreen;
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1350, 60);
            pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(447, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(293, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTIÓN DE LIBROS   ";
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = Color.WhiteSmoke;
            pnlBusqueda.Controls.Add(btnBuscar);
            pnlBusqueda.Controls.Add(txtBuscarISBN);
            pnlBusqueda.Controls.Add(lblBuscar);
            pnlBusqueda.Dock = DockStyle.Top;
            pnlBusqueda.Location = new Point(0, 60);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(1350, 55);
            pnlBusqueda.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(698, 17);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(90, 20);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar ";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscarISBN
            // 
            txtBuscarISBN.Location = new Point(507, 14);
            txtBuscarISBN.Name = "txtBuscarISBN";
            txtBuscarISBN.Size = new Size(148, 23);
            txtBuscarISBN.TabIndex = 1;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscar.Location = new Point(365, 14);
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
            pnlDatos.Controls.Add(txtAnio);
            pnlDatos.Controls.Add(txtCategoria);
            pnlDatos.Controls.Add(txtTitulo);
            pnlDatos.Controls.Add(txtISBN);
            pnlDatos.Controls.Add(lblExistencias);
            pnlDatos.Controls.Add(lblAnio);
            pnlDatos.Controls.Add(lblCategoria);
            pnlDatos.Controls.Add(lblEditorial);
            pnlDatos.Controls.Add(lblAutor);
            pnlDatos.Controls.Add(lblTituloLib);
            pnlDatos.Controls.Add(lblISBN);
            pnlDatos.Dock = DockStyle.Top;
            pnlDatos.Location = new Point(0, 115);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(1350, 245);
            pnlDatos.TabIndex = 2;
            // 
            // cmbEditorial
            // 
            cmbEditorial.FormattingEnabled = true;
            cmbEditorial.Location = new Point(505, 117);
            cmbEditorial.Name = "cmbEditorial";
            cmbEditorial.Size = new Size(148, 23);
            cmbEditorial.TabIndex = 16;
            // 
            // cmbAutor
            // 
            cmbAutor.FormattingEnabled = true;
            cmbAutor.Location = new Point(505, 88);
            cmbAutor.Name = "cmbAutor";
            cmbAutor.Size = new Size(148, 23);
            cmbAutor.TabIndex = 15;
            // 
            // txtExistencias
            // 
            txtExistencias.Location = new Point(505, 204);
            txtExistencias.Name = "txtExistencias";
            txtExistencias.Size = new Size(148, 23);
            txtExistencias.TabIndex = 14;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(505, 175);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(148, 23);
            txtAnio.TabIndex = 13;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(505, 146);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(148, 23);
            txtCategoria.TabIndex = 12;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(505, 59);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(148, 23);
            txtTitulo.TabIndex = 10;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(505, 21);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(148, 23);
            txtISBN.TabIndex = 3;
            // 
            // lblExistencias
            // 
            lblExistencias.AutoSize = true;
            lblExistencias.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblExistencias.Location = new Point(394, 204);
            lblExistencias.Name = "lblExistencias";
            lblExistencias.Size = new Size(76, 15);
            lblExistencias.TabIndex = 9;
            lblExistencias.Text = "Existencias : ";
            lblExistencias.Click += Label1_Click;
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAnio.Location = new Point(394, 175);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(38, 15);
            lblAnio.TabIndex = 8;
            lblAnio.Text = "Año : ";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCategoria.Location = new Point(394, 146);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(69, 15);
            lblCategoria.TabIndex = 7;
            lblCategoria.Text = "Categoria : ";
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEditorial.Location = new Point(394, 117);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(61, 15);
            lblEditorial.TabIndex = 6;
            lblEditorial.Text = "Editorial : ";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAutor.Location = new Point(394, 88);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(48, 15);
            lblAutor.TabIndex = 5;
            lblAutor.Text = "Autor : ";
            // 
            // lblTituloLib
            // 
            lblTituloLib.AutoSize = true;
            lblTituloLib.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTituloLib.Location = new Point(394, 59);
            lblTituloLib.Name = "lblTituloLib";
            lblTituloLib.Size = new Size(48, 15);
            lblTituloLib.TabIndex = 4;
            lblTituloLib.Text = "Titulo : ";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblISBN.Location = new Point(394, 21);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(44, 15);
            lblISBN.TabIndex = 3;
            lblISBN.Text = "ISBN : ";
            // 
            // PnlBotones
            // 
            PnlBotones.Controls.Add(btnCancelar);
            PnlBotones.Controls.Add(btnEliminar);
            PnlBotones.Controls.Add(btnEditar);
            PnlBotones.Controls.Add(btnGuardar);
            PnlBotones.Controls.Add(btnNuevo);
            PnlBotones.Location = new Point(51, 366);
            PnlBotones.Name = "PnlBotones";
            PnlBotones.Size = new Size(1100, 72);
            PnlBotones.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderColor = Color.SeaGreen;
            btnCancelar.FlatAppearance.BorderSize = 2;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.IconChar = IconChar.Cancel;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = IconFont.Regular;
            btnCancelar.IconSize = 35;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(826, 17);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 45);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderColor = Color.SeaGreen;
            btnEliminar.FlatAppearance.BorderSize = 2;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.IconChar = IconChar.Diamond;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = IconFont.Regular;
            btnEliminar.IconSize = 35;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(647, 17);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(130, 45);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.FlatAppearance.BorderColor = Color.SeaGreen;
            btnEditar.FlatAppearance.BorderSize = 2;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.IconChar = IconChar.Edit;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = IconFont.Regular;
            btnEditar.IconSize = 35;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(474, 14);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(130, 45);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.FlatAppearance.BorderColor = Color.SeaGreen;
            btnGuardar.FlatAppearance.BorderSize = 2;
            btnGuardar.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.IconChar = IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = IconFont.Regular;
            btnGuardar.IconSize = 35;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(289, 14);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(130, 45);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar ";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatAppearance.BorderColor = Color.SeaGreen;
            btnNuevo.FlatAppearance.BorderSize = 2;
            btnNuevo.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            btnNuevo.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.IconChar = IconChar.Newspaper;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = IconFont.Regular;
            btnNuevo.IconSize = 35;
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(93, 17);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(130, 45);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dgvLibros
            // 
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.ImeMode = ImeMode.NoControl;
            dgvLibros.Location = new Point(51, 457);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.Size = new Size(1100, 260);
            dgvLibros.TabIndex = 4;
            // 
            // FrmLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(dgvLibros);
            Controls.Add(PnlBotones);
            Controls.Add(pnlDatos);
            Controls.Add(pnlBusqueda);
            Controls.Add(pnlTitulo);
            Name = "FrmLibros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLibros";
            WindowState = FormWindowState.Maximized;
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            PnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Panel pnlBusqueda;
        private Button btnBuscar;
        private TextBox txtBuscarISBN;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private Panel pnlDatos;
        private Label lblISBN;
        private Label lblAutor;
        private Label lblTituloLib;
        private Label lblExistencias;
        private Label lblAnio;
        private Label lblAno;
        private Label lblCategoria;
        private Label lblEditorial;
        private TextBox txtExistencias;
        private TextBox txtAnio;
        private TextBox txtCategoria;
        private TextBox txtTitulo;
        private TextBox txtISBN;
        private ComboBox cmbEditorial;
        private ComboBox cmbAutor;
        private Panel PnlBotones;
        private IconButton pnlEliminar;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton iconButton3;
        private IconButton pnlEditar;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private IconButton btnCancelar;
        private IconButton btnEliminar;
        private IconButton btnEditar;
        private DataGridView dgvLibros;
    }
}