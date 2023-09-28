namespace Biblioteca
{
    partial class frmBiblioteca
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBiblioteca));
            btnCargarLibros = new Button();
            btnListarLibros = new Button();
            btnAltaLector = new Button();
            btnListarLectores = new Button();
            btnPrestamo = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnCargarLibros
            // 
            btnCargarLibros.BackColor = Color.Transparent;
            btnCargarLibros.BackgroundImage = (Image)resources.GetObject("btnCargarLibros.BackgroundImage");
            btnCargarLibros.BackgroundImageLayout = ImageLayout.Stretch;
            btnCargarLibros.Cursor = Cursors.Hand;
            btnCargarLibros.FlatAppearance.BorderColor = Color.FromArgb(227, 114, 100);
            btnCargarLibros.FlatAppearance.BorderSize = 0;
            btnCargarLibros.FlatStyle = FlatStyle.Flat;
            btnCargarLibros.Font = new Font("Roboto", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCargarLibros.ForeColor = Color.FromArgb(247, 246, 244);
            btnCargarLibros.Location = new Point(388, 310);
            btnCargarLibros.Name = "btnCargarLibros";
            btnCargarLibros.Size = new Size(183, 49);
            btnCargarLibros.TabIndex = 0;
            btnCargarLibros.Text = "Cargar Libro";
            btnCargarLibros.UseVisualStyleBackColor = false;
            btnCargarLibros.Click += btnCargarLibros_Click;
            // 
            // btnListarLibros
            // 
            btnListarLibros.BackColor = Color.FromArgb(227, 114, 100);
            btnListarLibros.Cursor = Cursors.Hand;
            btnListarLibros.FlatAppearance.BorderColor = Color.FromArgb(227, 114, 100);
            btnListarLibros.FlatAppearance.MouseDownBackColor = Color.FromArgb(122, 29, 24);
            btnListarLibros.FlatAppearance.MouseOverBackColor = Color.FromArgb(216, 76, 65);
            btnListarLibros.FlatStyle = FlatStyle.Flat;
            btnListarLibros.Font = new Font("Roboto", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnListarLibros.ForeColor = Color.FromArgb(247, 246, 244);
            btnListarLibros.Location = new Point(0, 124);
            btnListarLibros.Name = "btnListarLibros";
            btnListarLibros.Size = new Size(233, 41);
            btnListarLibros.TabIndex = 1;
            btnListarLibros.Text = "Listar Libros";
            btnListarLibros.UseVisualStyleBackColor = false;
            btnListarLibros.Click += btnListarLibros_Click;
            // 
            // btnAltaLector
            // 
            btnAltaLector.BackColor = Color.FromArgb(227, 114, 100);
            btnAltaLector.Cursor = Cursors.Hand;
            btnAltaLector.FlatAppearance.BorderColor = Color.FromArgb(227, 114, 100);
            btnAltaLector.FlatAppearance.MouseDownBackColor = Color.FromArgb(122, 29, 24);
            btnAltaLector.FlatAppearance.MouseOverBackColor = Color.FromArgb(216, 76, 65);
            btnAltaLector.FlatStyle = FlatStyle.Flat;
            btnAltaLector.Font = new Font("Roboto", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAltaLector.ForeColor = Color.FromArgb(247, 246, 244);
            btnAltaLector.Location = new Point(0, 206);
            btnAltaLector.Name = "btnAltaLector";
            btnAltaLector.Size = new Size(233, 41);
            btnAltaLector.TabIndex = 2;
            btnAltaLector.Text = "Alta Lector";
            btnAltaLector.UseVisualStyleBackColor = false;
            btnAltaLector.Click += btnAltaLector_Click;
            // 
            // btnListarLectores
            // 
            btnListarLectores.BackColor = Color.FromArgb(227, 114, 100);
            btnListarLectores.Cursor = Cursors.Hand;
            btnListarLectores.FlatAppearance.BorderColor = Color.FromArgb(227, 114, 100);
            btnListarLectores.FlatAppearance.MouseDownBackColor = Color.FromArgb(122, 29, 24);
            btnListarLectores.FlatAppearance.MouseOverBackColor = Color.FromArgb(216, 76, 65);
            btnListarLectores.FlatStyle = FlatStyle.Flat;
            btnListarLectores.Font = new Font("Roboto", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnListarLectores.ForeColor = Color.FromArgb(247, 246, 244);
            btnListarLectores.Location = new Point(0, 247);
            btnListarLectores.Name = "btnListarLectores";
            btnListarLectores.Size = new Size(233, 41);
            btnListarLectores.TabIndex = 3;
            btnListarLectores.Text = "Lectores";
            btnListarLectores.UseVisualStyleBackColor = false;
            btnListarLectores.Click += btnListarLectores_Click;
            // 
            // btnPrestamo
            // 
            btnPrestamo.BackColor = Color.FromArgb(227, 114, 100);
            btnPrestamo.Cursor = Cursors.Hand;
            btnPrestamo.FlatAppearance.BorderColor = Color.FromArgb(227, 114, 100);
            btnPrestamo.FlatAppearance.MouseDownBackColor = Color.FromArgb(122, 29, 24);
            btnPrestamo.FlatAppearance.MouseOverBackColor = Color.FromArgb(216, 76, 65);
            btnPrestamo.FlatStyle = FlatStyle.Flat;
            btnPrestamo.Font = new Font("Roboto", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrestamo.ForeColor = Color.FromArgb(247, 246, 244);
            btnPrestamo.Location = new Point(0, 165);
            btnPrestamo.Name = "btnPrestamo";
            btnPrestamo.Size = new Size(233, 41);
            btnPrestamo.TabIndex = 4;
            btnPrestamo.Text = "Prestar Libros";
            btnPrestamo.UseVisualStyleBackColor = false;
            btnPrestamo.Click += btnPrestamo_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(247, 246, 244);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Roboto", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Gray;
            btnExit.Location = new Point(676, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(41, 41);
            btnExit.TabIndex = 5;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmBiblioteca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 246, 244);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(719, 432);
            ControlBox = false;
            Controls.Add(btnExit);
            Controls.Add(btnPrestamo);
            Controls.Add(btnListarLectores);
            Controls.Add(btnAltaLector);
            Controls.Add(btnListarLibros);
            Controls.Add(btnCargarLibros);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBiblioteca";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BIBLIOTECA";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCargarLibros;
        private Button btnListarLibros;
        private Button btnAltaLector;
        private Button btnListarLectores;
        private Button btnPrestamo;
        private Button btnExit;
    }
}