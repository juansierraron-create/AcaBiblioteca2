namespace AcaBiblioteca
{
    partial class FrmUsuarios
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
            pnlSuperior = new Panel();
            lblTituloUsuarios = new Label();
            lblNombreU = new Label();
            lblApellidoU = new Label();
            lblTelefono = new Label();
            this.lblCorreo = new Label();
            this.txtNombreu = new TextBox();
            this.txtApellido = new TextBox();
            this.txtDocumento = new TextBox();
            this.txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            lblDocu = new Label();
            pnlDatos = new Panel();
            PnlBotones = new Panel();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            pnlSuperior.SuspendLayout();
            pnlDatos.SuspendLayout();
            PnlBotones.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = Color.MediumSeaGreen;
            pnlSuperior.Controls.Add(lblTituloUsuarios);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(0, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1204, 80);
            pnlSuperior.TabIndex = 2;
            // 
            // lblTituloUsuarios
            // 
            lblTituloUsuarios.AutoSize = true;
            lblTituloUsuarios.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloUsuarios.ForeColor = Color.Black;
            lblTituloUsuarios.Location = new Point(395, 19);
            lblTituloUsuarios.Name = "lblTituloUsuarios";
            lblTituloUsuarios.Size = new Size(279, 37);
            lblTituloUsuarios.TabIndex = 1;
            lblTituloUsuarios.Text = "Gestion de Usuarios ";
            lblTituloUsuarios.Click += lblTituloUsuarios_Click;
            // 
            // lblNombreU
            // 
            lblNombreU.AutoSize = true;
            lblNombreU.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombreU.Location = new Point(395, 77);
            lblNombreU.Name = "lblNombreU";
            lblNombreU.Size = new Size(62, 15);
            lblNombreU.TabIndex = 5;
            lblNombreU.Text = "Nombre : ";
            // 
            // lblApellidoU
            // 
            lblApellidoU.AutoSize = true;
            lblApellidoU.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblApellidoU.Location = new Point(395, 117);
            lblApellidoU.Name = "lblApellidoU";
            lblApellidoU.Size = new Size(61, 15);
            lblApellidoU.TabIndex = 6;
            lblApellidoU.Text = "Apellido : ";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTelefono.Location = new Point(395, 189);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(65, 15);
            lblTelefono.TabIndex = 8;
            lblTelefono.Text = "Telefono : ";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblCorreo.Location = new Point(395, 224);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new Size(54, 15);
            this.lblCorreo.TabIndex = 9;
            this.lblCorreo.Text = "Correo : ";
            this.lblCorreo.Click += this.label4_Click;
            // 
            // txtNombreu
            // 
            this.txtNombreu.Location = new Point(496, 77);
            this.txtNombreu.Name = "txtNombreu";
            this.txtNombreu.Size = new Size(148, 23);
            this.txtNombreu.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new Point(496, 117);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new Size(148, 23);
            this.txtApellido.TabIndex = 11;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new Point(496, 153);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new Size(148, 23);
            this.txtDocumento.TabIndex = 12;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new Point(496, 186);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new Size(148, 23);
            this.txtTelefono.TabIndex = 13;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(496, 216);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(148, 23);
            txtCorreo.TabIndex = 14;
            // 
            // lblDocu
            // 
            lblDocu.AutoSize = true;
            lblDocu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDocu.Location = new Point(395, 156);
            lblDocu.Name = "lblDocu";
            lblDocu.Size = new Size(82, 15);
            lblDocu.TabIndex = 16;
            lblDocu.Text = "Documento : ";
            // 
            // pnlDatos
            // 
            pnlDatos.Controls.Add(lblNombreU);
            pnlDatos.Controls.Add(lblDocu);
            pnlDatos.Controls.Add(lblApellidoU);
            pnlDatos.Controls.Add(txtCorreo);
            pnlDatos.Controls.Add(lblTelefono);
            pnlDatos.Controls.Add(this.txtTelefono);
            pnlDatos.Controls.Add(this.lblCorreo);
            pnlDatos.Controls.Add(this.txtDocumento);
            pnlDatos.Controls.Add(this.txtNombreu);
            pnlDatos.Controls.Add(this.txtApellido);
            pnlDatos.Dock = DockStyle.Top;
            pnlDatos.Location = new Point(0, 80);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(1204, 302);
            pnlDatos.TabIndex = 17;
            // 
            // PnlBotones
            // 
            PnlBotones.Controls.Add(btnCancelar);
            PnlBotones.Controls.Add(btnEliminar);
            PnlBotones.Controls.Add(btnEditar);
            PnlBotones.Controls.Add(btnGuardar);
            PnlBotones.Controls.Add(btnNuevo);
            PnlBotones.Location = new Point(46, 388);
            PnlBotones.Name = "PnlBotones";
            PnlBotones.Size = new Size(1100, 72);
            PnlBotones.TabIndex = 17;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderColor = Color.SeaGreen;
            btnCancelar.FlatAppearance.BorderSize = 2;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Regular;
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
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Diamond;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Regular;
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
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Regular;
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
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnGuardar.IconSize = 35;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(289, 14);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(130, 45);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar ";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = true;
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
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnNuevo.IconSize = 35;
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(93, 17);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(130, 45);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 749);
            Controls.Add(PnlBotones);
            Controls.Add(pnlDatos);
            Controls.Add(pnlSuperior);
            Name = "FrmUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmUsuarios";
            pnlSuperior.ResumeLayout(false);
            pnlSuperior.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            PnlBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSuperior;
        private Label lblTituloUsuarios;
        private Label lblNombreU;
        private Label lblTituloLib;
        private Label label1;
        private Label lblDocumento;
        private Label lblApellidoU;
        private Label lblDocumentoU;
        private Label lblTelefono;
        private Label label4;
        private TextBox txtISBN;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox txtCorreo;
        private Label lblDocu;
        private Panel pnlDatos;
        private Panel PnlBotones;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnNuevo;
    }
}