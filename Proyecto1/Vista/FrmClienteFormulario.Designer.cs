namespace Proyecto1.Vista
{
    partial class FrmClienteFormulario
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtnombre = new TextBox();
            txtapellido = new TextBox();
            txtdireccion = new TextBox();
            txttelefono = new TextBox();
            txtcorreo = new TextBox();
            btnregistrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(250, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 25);
            label1.TabIndex = 0;
            label1.Text = "AGREGAR USUARIOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(250, 110);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(201, 25);
            label2.TabIndex = 1;
            label2.Text = "INGRESE EL NOMBRE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(242, 228);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(209, 25);
            label3.TabIndex = 2;
            label3.Text = "INGRESE EL APELLIDO";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(242, 362);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(223, 25);
            label4.TabIndex = 3;
            label4.Text = "INGRESE LA DIRECCIÓN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(250, 473);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(214, 25);
            label5.TabIndex = 4;
            label5.Text = "INGRESE EL TELÉFONO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(250, 594);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(194, 25);
            label6.TabIndex = 5;
            label6.Text = "INGRESE EL CORREO";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(250, 157);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(201, 33);
            txtnombre.TabIndex = 6;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(249, 286);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(201, 33);
            txtapellido.TabIndex = 7;
            // 
            // txtdireccion
            // 
            txtdireccion.Location = new Point(250, 412);
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(201, 33);
            txtdireccion.TabIndex = 8;
            // 
            // txttelefono
            // 
            txttelefono.Location = new Point(250, 529);
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(201, 33);
            txttelefono.TabIndex = 9;
            txttelefono.TextChanged += textBox4_TextChanged;
            txttelefono.KeyPress += txttelefono_KeyPress;
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(249, 646);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(201, 33);
            txtcorreo.TabIndex = 10;
            txtcorreo.TextChanged += txtcorreo_TextChanged;
            // 
            // btnregistrar
            // 
            btnregistrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnregistrar.ForeColor = Color.Maroon;
            btnregistrar.Location = new Point(248, 715);
            btnregistrar.Name = "btnregistrar";
            btnregistrar.Size = new Size(202, 38);
            btnregistrar.TabIndex = 11;
            btnregistrar.Text = "REGISTRAR ";
            btnregistrar.UseVisualStyleBackColor = true;
            btnregistrar.Click += btnregistrar_Click;
            // 
            // FrmClienteFormulario
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(773, 830);
            Controls.Add(btnregistrar);
            Controls.Add(txtcorreo);
            Controls.Add(txttelefono);
            Controls.Add(txtdireccion);
            Controls.Add(txtapellido);
            Controls.Add(txtnombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.Control;
            Margin = new Padding(4);
            Name = "FrmClienteFormulario";
            Text = "FrmClienteFormulario";
            Load += FrmClienteFormulario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtnombre;
        private TextBox txtapellido;
        private TextBox txtdireccion;
        private TextBox txttelefono;
        private TextBox txtcorreo;
        private Button btnregistrar;
    }
}