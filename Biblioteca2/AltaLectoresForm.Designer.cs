﻿namespace Biblioteca
{
    partial class frmAltaLectores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaLectores));
            btnAgregar = new Button();
            txtDNI = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            lblDNI = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(216, 76, 65);
            btnAgregar.FlatAppearance.BorderColor = Color.FromArgb(216, 76, 65);
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(122, 29, 24);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.FromArgb(247, 246, 244);
            btnAgregar.Location = new Point(414, 94);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 41);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtDNI
            // 
            txtDNI.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDNI.Location = new Point(197, 185);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(140, 24);
            txtDNI.TabIndex = 12;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(197, 140);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(140, 24);
            txtApellido.TabIndex = 11;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(197, 91);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(140, 24);
            txtNombre.TabIndex = 10;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDNI.Location = new Point(124, 185);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(31, 17);
            lblDNI.TabIndex = 9;
            lblDNI.Text = "DNI";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(124, 140);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(60, 17);
            lblApellido.TabIndex = 8;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(124, 94);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(58, 17);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(216, 76, 65);
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(216, 76, 65);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(122, 29, 24);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.ForeColor = Color.FromArgb(247, 246, 244);
            btnClose.Location = new Point(414, 172);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 41);
            btnClose.TabIndex = 14;
            btnClose.Text = "VOLVER";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmAltaLectores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 246, 244);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(580, 304);
            Controls.Add(btnClose);
            Controls.Add(btnAgregar);
            Controls.Add(txtDNI);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblDNI);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAltaLectores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AltaLectoresForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private TextBox txtDNI;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label lblDNI;
        private Label lblApellido;
        private Label lblNombre;
        private Button btnClose;
    }
}