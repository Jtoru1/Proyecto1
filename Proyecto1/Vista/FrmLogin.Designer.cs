namespace Proyecto1.Vista
{
    partial class FrmLogin
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
            lbCorreo = new Label();
            txtCorreo = new TextBox();
            txtcontrasena = new TextBox();
            label2 = new Label();
            btninicio = new Button();
            SuspendLayout();
            // 
            // lbCorreo
            // 
            lbCorreo.AutoSize = true;
            lbCorreo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbCorreo.ForeColor = SystemColors.Control;
            lbCorreo.Location = new Point(329, 90);
            lbCorreo.Name = "lbCorreo";
            lbCorreo.Size = new Size(92, 32);
            lbCorreo.TabIndex = 0;
            lbCorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCorreo.Location = new Point(273, 156);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(199, 25);
            txtCorreo.TabIndex = 1;
            // 
            // txtcontrasena
            // 
            txtcontrasena.Location = new Point(273, 270);
            txtcontrasena.Name = "txtcontrasena";
            txtcontrasena.PasswordChar = '*';
            txtcontrasena.Size = new Size(199, 23);
            txtcontrasena.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(308, 208);
            label2.Name = "label2";
            label2.Size = new Size(143, 32);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // btninicio
            // 
            btninicio.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btninicio.ForeColor = Color.Teal;
            btninicio.Location = new Point(273, 344);
            btninicio.Name = "btninicio";
            btninicio.Size = new Size(199, 63);
            btninicio.TabIndex = 4;
            btninicio.Text = "Iniciar Sesión";
            btninicio.UseVisualStyleBackColor = true;
            btninicio.Click += btninicio_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(771, 591);
            Controls.Add(btninicio);
            Controls.Add(label2);
            Controls.Add(txtcontrasena);
            Controls.Add(txtCorreo);
            Controls.Add(lbCorreo);
            Name = "FrmLogin";
            Text = "Iniciar Sesión";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCorreo;
        private TextBox txtCorreo;
        private TextBox txtcontrasena;
        private Label label2;
        private Button btninicio;
    }
}