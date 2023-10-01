namespace Biblioteca
{
    partial class frmListaLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaLibros));
            dtgvLibros = new DataGridView();
            Titulo = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            Editorial = new DataGridViewTextBoxColumn();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvLibros).BeginInit();
            SuspendLayout();
            // 
            // dtgvLibros
            // 
            dtgvLibros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvLibros.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgvLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvLibros.Columns.AddRange(new DataGridViewColumn[] { Titulo, Autor, Editorial });
            dtgvLibros.Location = new Point(56, 71);
            dtgvLibros.Name = "dtgvLibros";
            dtgvLibros.RowHeadersVisible = false;
            dtgvLibros.RowTemplate.Height = 25;
            dtgvLibros.Size = new Size(577, 252);
            dtgvLibros.TabIndex = 0;
            // 
            // Titulo
            // 
            Titulo.HeaderText = "Titulo";
            Titulo.Name = "Titulo";
            // 
            // Autor
            // 
            Autor.HeaderText = "Autor";
            Autor.Name = "Autor";
            // 
            // Editorial
            // 
            Editorial.HeaderText = "Editorial";
            Editorial.Name = "Editorial";
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
            btnExit.TabIndex = 7;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmListaLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 246, 244);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(703, 393);
            Controls.Add(btnExit);
            Controls.Add(dtgvLibros);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmListaLibros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListaLibrosForm";
            Load += ListaLibrosForm_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvLibros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvLibros;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn Editorial;
        private Button btnExit;
    }
}