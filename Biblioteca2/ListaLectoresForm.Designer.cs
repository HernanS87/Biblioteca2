namespace Biblioteca
{
    partial class frmListaLectores
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaLectores));
            dtgvLectores = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            Prestamos = new DataGridViewTextBoxColumn();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvLectores).BeginInit();
            SuspendLayout();
            // 
            // dtgvLectores
            // 
            dtgvLectores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvLectores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvLectores.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgvLectores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgvLectores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvLectores.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, DNI, Prestamos });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Roboto Bk", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgvLectores.DefaultCellStyle = dataGridViewCellStyle2;
            dtgvLectores.Location = new Point(35, 96);
            dtgvLectores.Name = "dtgvLectores";
            dtgvLectores.RowHeadersVisible = false;
            dtgvLectores.RowTemplate.Height = 25;
            dtgvLectores.Size = new Size(577, 252);
            dtgvLectores.TabIndex = 1;
            dtgvLectores.CellContentClick += dtgvLectores_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            // 
            // DNI
            // 
            DNI.HeaderText = "DNI";
            DNI.Name = "DNI";
            // 
            // Prestamos
            // 
            Prestamos.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Prestamos.HeaderText = "Prestamos";
            Prestamos.Name = "Prestamos";
            Prestamos.Width = 95;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(247, 246, 244);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Roboto", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Gray;
            btnExit.Location = new Point(666, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(41, 41);
            btnExit.TabIndex = 6;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmListaLectores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 246, 244);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(719, 432);
            ControlBox = false;
            Controls.Add(btnExit);
            Controls.Add(dtgvLectores);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmListaLectores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListaLectoresForm";
            Load += frmListaLectores_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvLectores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvLectores;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Prestamos;
        private Button btnExit;
    }
}