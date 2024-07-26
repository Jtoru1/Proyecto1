namespace Proyecto1.Vista
{
    partial class FrmInicio
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
            lbCajero = new Label();
            btnInventarios = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // lbCajero
            // 
            lbCajero.AutoSize = true;
            lbCajero.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbCajero.ForeColor = SystemColors.Control;
            lbCajero.Location = new Point(12, 9);
            lbCajero.Name = "lbCajero";
            lbCajero.Size = new Size(141, 30);
            lbCajero.TabIndex = 0;
            lbCajero.Text = "Bienvenido : ";
            lbCajero.Click += label1_Click;
            // 
            // btnInventarios
            // 
            btnInventarios.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnInventarios.Location = new Point(12, 78);
            btnInventarios.Name = "btnInventarios";
            btnInventarios.Size = new Size(243, 48);
            btnInventarios.TabIndex = 1;
            btnInventarios.Text = "Gestión de ventas";
            btnInventarios.UseVisualStyleBackColor = true;
            btnInventarios.Click += btnInventarios_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(12, 151);
            button2.Name = "button2";
            button2.Size = new Size(243, 48);
            button2.TabIndex = 2;
            button2.Text = "Gestión de inventarios";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(12, 225);
            button3.Name = "button3";
            button3.Size = new Size(243, 48);
            button3.TabIndex = 3;
            button3.Text = "Gestión de clientes";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(12, 297);
            button4.Name = "button4";
            button4.Size = new Size(243, 48);
            button4.TabIndex = 4;
            button4.Text = "Reportes y Análisis";
            button4.UseVisualStyleBackColor = true;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(831, 498);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnInventarios);
            Controls.Add(lbCajero);
            Name = "FrmInicio";
            Text = "FrmInicio";
            Load += FrmInicio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCajero;
        private Button btnInventarios;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}