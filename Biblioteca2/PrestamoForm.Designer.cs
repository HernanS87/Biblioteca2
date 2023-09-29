namespace Biblioteca
{
    partial class frmPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrestamo));
            btnPedirLibro = new Button();
            txtLibro = new TextBox();
            txtDni = new TextBox();
            lblLibro = new Label();
            lblDni = new Label();
            btnDevolverLibro = new Button();
            dtgvPrestamos = new DataGridView();
            Lector = new DataGridViewTextBoxColumn();
            Libro = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvPrestamos).BeginInit();
            SuspendLayout();
            // 
            // btnPedirLibro
            // 
            btnPedirLibro.BackColor = Color.FromArgb(216, 76, 65);
            btnPedirLibro.Cursor = Cursors.Hand;
            btnPedirLibro.FlatAppearance.BorderColor = Color.FromArgb(216, 76, 65);
            btnPedirLibro.FlatAppearance.MouseOverBackColor = Color.FromArgb(122, 29, 24);
            btnPedirLibro.FlatStyle = FlatStyle.Flat;
            btnPedirLibro.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnPedirLibro.ForeColor = Color.FromArgb(247, 246, 244);
            btnPedirLibro.Location = new Point(441, 39);
            btnPedirLibro.Name = "btnPedirLibro";
            btnPedirLibro.Size = new Size(136, 41);
            btnPedirLibro.TabIndex = 13;
            btnPedirLibro.Text = "PEDIR LIBRO";
            btnPedirLibro.UseVisualStyleBackColor = false;
            btnPedirLibro.Click += btnPedirLibro_Click;
            // 
            // txtLibro
            // 
            txtLibro.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtLibro.Location = new Point(235, 115);
            txtLibro.Name = "txtLibro";
            txtLibro.Size = new Size(140, 24);
            txtLibro.TabIndex = 11;
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.Location = new Point(235, 56);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(140, 24);
            txtDni.TabIndex = 10;
            // 
            // lblLibro
            // 
            lblLibro.AutoSize = true;
            lblLibro.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblLibro.Location = new Point(182, 118);
            lblLibro.Name = "lblLibro";
            lblLibro.Size = new Size(41, 17);
            lblLibro.TabIndex = 8;
            lblLibro.Text = "Libro";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.Location = new Point(189, 59);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(31, 17);
            lblDni.TabIndex = 7;
            lblDni.Text = "DNI";
            // 
            // btnDevolverLibro
            // 
            btnDevolverLibro.BackColor = Color.FromArgb(216, 76, 65);
            btnDevolverLibro.Cursor = Cursors.Hand;
            btnDevolverLibro.FlatAppearance.BorderColor = Color.FromArgb(216, 76, 65);
            btnDevolverLibro.FlatAppearance.MouseOverBackColor = Color.FromArgb(122, 29, 24);
            btnDevolverLibro.FlatStyle = FlatStyle.Flat;
            btnDevolverLibro.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnDevolverLibro.ForeColor = Color.FromArgb(247, 246, 244);
            btnDevolverLibro.Location = new Point(441, 115);
            btnDevolverLibro.Name = "btnDevolverLibro";
            btnDevolverLibro.Size = new Size(136, 41);
            btnDevolverLibro.TabIndex = 14;
            btnDevolverLibro.Text = "DEVOLVER LIBRO";
            btnDevolverLibro.UseVisualStyleBackColor = false;
            btnDevolverLibro.Click += btnDevolverLibro_Click;
            // 
            // dtgvPrestamos
            // 
            dtgvPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvPrestamos.BackgroundColor = SystemColors.ButtonFace;
            dtgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvPrestamos.Columns.AddRange(new DataGridViewColumn[] { Lector, Libro });
            dtgvPrestamos.Location = new Point(73, 204);
            dtgvPrestamos.Name = "dtgvPrestamos";
            dtgvPrestamos.RowHeadersVisible = false;
            dtgvPrestamos.RowTemplate.Height = 25;
            dtgvPrestamos.Size = new Size(577, 133);
            dtgvPrestamos.TabIndex = 15;
            // 
            // Lector
            // 
            Lector.HeaderText = "Lector DNI";
            Lector.Name = "Lector";
            // 
            // Libro
            // 
            Libro.HeaderText = "Nombre del libro";
            Libro.Name = "Libro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(282, 184);
            label1.Name = "label1";
            label1.Size = new Size(159, 17);
            label1.TabIndex = 16;
            label1.Text = "PRESTAMOS VIGENTES";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(247, 246, 244);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Roboto", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Gray;
            btnExit.Location = new Point(650, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(41, 41);
            btnExit.TabIndex = 17;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmPrestamo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 246, 244);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(703, 393);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Controls.Add(dtgvPrestamos);
            Controls.Add(btnDevolverLibro);
            Controls.Add(btnPedirLibro);
            Controls.Add(txtLibro);
            Controls.Add(txtDni);
            Controls.Add(lblLibro);
            Controls.Add(lblDni);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPrestamo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrestamoForm";
            Load += frmPrestamo_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvPrestamos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPedirLibro;
        private TextBox txtLibro;
        private TextBox txtDni;
        private Label lblLibro;
        private Label lblDni;
        private Button btnDevolverLibro;
        private DataGridView dtgvPrestamos;
        private Label label1;
        private DataGridViewTextBoxColumn Lector;
        private DataGridViewTextBoxColumn Libro;
        private Button btnExit;
    }
}