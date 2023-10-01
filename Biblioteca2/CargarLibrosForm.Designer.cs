namespace Biblioteca
{
    partial class frmCargarLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargarLibros));
            lblNombre = new Label();
            lblAutor = new Label();
            lblEditorial = new Label();
            txtNombre = new TextBox();
            txtAutor = new TextBox();
            txtEditorial = new TextBox();
            btnAgregar = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(108, 94);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(62, 16);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.BackColor = Color.Transparent;
            lblAutor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAutor.ForeColor = Color.White;
            lblAutor.Location = new Point(108, 140);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(43, 16);
            lblAutor.TabIndex = 1;
            lblAutor.Text = "Autor";
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.BackColor = Color.Transparent;
            lblEditorial.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEditorial.ForeColor = Color.White;
            lblEditorial.Location = new Point(108, 185);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(65, 16);
            lblEditorial.TabIndex = 2;
            lblEditorial.Text = "Editorial";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(195, 91);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(140, 21);
            txtNombre.TabIndex = 3;
            // 
            // txtAutor
            // 
            txtAutor.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtAutor.Location = new Point(195, 140);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(140, 21);
            txtAutor.TabIndex = 4;
            // 
            // txtEditorial
            // 
            txtEditorial.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEditorial.Location = new Point(195, 185);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(140, 21);
            txtEditorial.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(216, 76, 65);
            btnAgregar.FlatAppearance.BorderColor = Color.FromArgb(216, 76, 65);
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(122, 29, 24);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.FromArgb(247, 246, 244);
            btnAgregar.Location = new Point(419, 93);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 41);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(216, 76, 65);
            btnVolver.FlatAppearance.BorderColor = Color.FromArgb(216, 76, 65);
            btnVolver.FlatAppearance.MouseOverBackColor = Color.FromArgb(122, 29, 24);
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.FromArgb(247, 246, 244);
            btnVolver.Location = new Point(419, 168);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(100, 41);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmCargarLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 246, 244);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(580, 304);
            Controls.Add(btnVolver);
            Controls.Add(btnAgregar);
            Controls.Add(txtEditorial);
            Controls.Add(txtAutor);
            Controls.Add(txtNombre);
            Controls.Add(lblEditorial);
            Controls.Add(lblAutor);
            Controls.Add(lblNombre);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCargarLibros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CargarLibrosForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblAutor;
        private Label lblEditorial;
        private TextBox txtNombre;
        private TextBox txtAutor;
        private TextBox txtEditorial;
        private Button btnAgregar;
        private Button btnVolver;
    }
}