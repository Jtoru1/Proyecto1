namespace Proyecto1.Vista
{
    partial class FrmEditarUsuario
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
            txteditarnombre = new TextBox();
            txteditarapellido = new TextBox();
            txteditardireccion = new TextBox();
            txteditartelefono = new TextBox();
            txteditarcorreo = new TextBox();
            btnguardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(234, 31);
            label1.Name = "label1";
            label1.Size = new Size(223, 32);
            label1.TabIndex = 0;
            label1.Text = "EDITAR USUARIOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(234, 101);
            label2.Name = "label2";
            label2.Size = new Size(208, 32);
            label2.TabIndex = 1;
            label2.Text = "NUEVO NOMBRE";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(225, 204);
            label3.Name = "label3";
            label3.Size = new Size(217, 32);
            label3.TabIndex = 2;
            label3.Text = "NUEVO APELLIDO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(234, 303);
            label4.Name = "label4";
            label4.Size = new Size(231, 32);
            label4.TabIndex = 3;
            label4.Text = "NUEVA DIRECCIÓN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(234, 403);
            label5.Name = "label5";
            label5.Size = new Size(223, 32);
            label5.TabIndex = 4;
            label5.Text = "NUEVO TELÉFONO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(234, 515);
            label6.Name = "label6";
            label6.Size = new Size(200, 32);
            label6.TabIndex = 5;
            label6.Text = "NUEVO CORREO";
            label6.Click += label6_Click;
            // 
            // txteditarnombre
            // 
            txteditarnombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txteditarnombre.Location = new Point(234, 155);
            txteditarnombre.Name = "txteditarnombre";
            txteditarnombre.Size = new Size(208, 29);
            txteditarnombre.TabIndex = 6;
            // 
            // txteditarapellido
            // 
            txteditarapellido.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txteditarapellido.Location = new Point(234, 268);
            txteditarapellido.Name = "txteditarapellido";
            txteditarapellido.Size = new Size(208, 29);
            txteditarapellido.TabIndex = 7;
            // 
            // txteditardireccion
            // 
            txteditardireccion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txteditardireccion.Location = new Point(234, 357);
            txteditardireccion.Name = "txteditardireccion";
            txteditardireccion.Size = new Size(208, 29);
            txteditardireccion.TabIndex = 8;
            // 
            // txteditartelefono
            // 
            txteditartelefono.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txteditartelefono.Location = new Point(234, 461);
            txteditartelefono.Name = "txteditartelefono";
            txteditartelefono.Size = new Size(208, 29);
            txteditartelefono.TabIndex = 9;
            txteditartelefono.TextChanged += textBox4_TextChanged;
            // 
            // txteditarcorreo
            // 
            txteditarcorreo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txteditarcorreo.Location = new Point(234, 570);
            txteditarcorreo.Name = "txteditarcorreo";
            txteditarcorreo.Size = new Size(208, 29);
            txteditarcorreo.TabIndex = 10;
            // 
            // btnguardar
            // 
            btnguardar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnguardar.ForeColor = Color.Maroon;
            btnguardar.Location = new Point(234, 637);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(208, 49);
            btnguardar.TabIndex = 11;
            btnguardar.Text = "GUARDAR DATOS";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // FrmEditarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(745, 758);
            Controls.Add(btnguardar);
            Controls.Add(txteditarcorreo);
            Controls.Add(txteditartelefono);
            Controls.Add(txteditardireccion);
            Controls.Add(txteditarapellido);
            Controls.Add(txteditarnombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.Control;
            Name = "FrmEditarUsuario";
            Text = "FrmEditarUsuario";
            Load += FrmEditarUsuario_Load;
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
        private TextBox txteditarnombre;
        private TextBox txteditarapellido;
        private TextBox txteditardireccion;
        private TextBox txteditartelefono;
        private TextBox txteditarcorreo;
        private Button btnguardar;
    }
}