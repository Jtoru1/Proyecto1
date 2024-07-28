namespace Proyecto1.Vista
{
    partial class FrmProductoFormulario
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
            txtnombre = new TextBox();
            txtdescripcion = new TextBox();
            txtprecio = new TextBox();
            txtcantidad = new TextBox();
            btnregistrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(280, 52);
            label1.Name = "label1";
            label1.Size = new Size(243, 30);
            label1.TabIndex = 0;
            label1.Text = "AGREGAR PRODUCTOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(280, 130);
            label2.Name = "label2";
            label2.Size = new Size(225, 30);
            label2.TabIndex = 1;
            label2.Text = "INGRESE EL NOMBRE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(280, 257);
            label3.Name = "label3";
            label3.Size = new Size(276, 30);
            label3.TabIndex = 2;
            label3.Text = "INGRESE LA DESCRIPCIÓN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(280, 389);
            label4.Name = "label4";
            label4.Size = new Size(208, 30);
            label4.TabIndex = 3;
            label4.Text = "INGRESE EL PRECIO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(280, 494);
            label5.Name = "label5";
            label5.Size = new Size(247, 30);
            label5.TabIndex = 4;
            label5.Text = "INGRESE LA CANTIDAD";
            label5.Click += label5_Click;
            // 
            // txtnombre
            // 
            txtnombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtnombre.Location = new Point(280, 196);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(257, 25);
            txtnombre.TabIndex = 5;
            // 
            // txtdescripcion
            // 
            txtdescripcion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtdescripcion.Location = new Point(280, 321);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(257, 25);
            txtdescripcion.TabIndex = 6;
            // 
            // txtprecio
            // 
            txtprecio.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtprecio.Location = new Point(280, 453);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(257, 25);
            txtprecio.TabIndex = 7;
            txtprecio.TextChanged += txtprecio_TextChanged;
            txtprecio.KeyPress += txtprecio_KeyPress;
            // 
            // txtcantidad
            // 
            txtcantidad.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtcantidad.Location = new Point(280, 555);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(257, 25);
            txtcantidad.TabIndex = 8;
            txtcantidad.TextChanged += txtcantidad_TextChanged;
            txtcantidad.KeyPress += txtcantidad_KeyPress;
            // 
            // btnregistrar
            // 
            btnregistrar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnregistrar.ForeColor = Color.Black;
            btnregistrar.Location = new Point(280, 635);
            btnregistrar.Name = "btnregistrar";
            btnregistrar.Size = new Size(257, 52);
            btnregistrar.TabIndex = 9;
            btnregistrar.Text = "REGISTRAR";
            btnregistrar.UseVisualStyleBackColor = true;
            btnregistrar.Click += btnregistrar_Click;
            // 
            // FrmProductoFormulario
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(955, 767);
            Controls.Add(btnregistrar);
            Controls.Add(txtcantidad);
            Controls.Add(txtprecio);
            Controls.Add(txtdescripcion);
            Controls.Add(txtnombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "FrmProductoFormulario";
            Text = "FrmProductoFormulario";
            Load += FrmProductoFormulario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtnombre;
        private TextBox txtdescripcion;
        private TextBox txtprecio;
        private TextBox txtcantidad;
        private Button btnregistrar;
    }
}