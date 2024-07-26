namespace Proyecto1.Vista
{
    partial class FrmEditarProducto
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
            txteditarnombre = new TextBox();
            txteditardescripcion = new TextBox();
            txteditarprecio = new TextBox();
            txteditarcantidad = new TextBox();
            btneditardatos = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(265, 18);
            label1.Name = "label1";
            label1.Size = new Size(217, 30);
            label1.TabIndex = 0;
            label1.Text = "EDITAR PRODUCTOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(265, 86);
            label2.Name = "label2";
            label2.Size = new Size(183, 30);
            label2.TabIndex = 1;
            label2.Text = "NUEVO NOMBRE";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(265, 197);
            label3.Name = "label3";
            label3.Size = new Size(228, 30);
            label3.TabIndex = 2;
            label3.Text = "NUEVA DESCRIPCION";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(265, 303);
            label4.Name = "label4";
            label4.Size = new Size(166, 30);
            label4.TabIndex = 3;
            label4.Text = "NUEVO PRECIO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(265, 400);
            label5.Name = "label5";
            label5.Size = new Size(199, 30);
            label5.TabIndex = 4;
            label5.Text = "NUEVA CANTIDAD";
            // 
            // txteditarnombre
            // 
            txteditarnombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txteditarnombre.Location = new Point(265, 146);
            txteditarnombre.Name = "txteditarnombre";
            txteditarnombre.Size = new Size(217, 29);
            txteditarnombre.TabIndex = 5;
            // 
            // txteditardescripcion
            // 
            txteditardescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txteditardescripcion.Location = new Point(265, 258);
            txteditardescripcion.Name = "txteditardescripcion";
            txteditardescripcion.Size = new Size(217, 29);
            txteditardescripcion.TabIndex = 6;
            // 
            // txteditarprecio
            // 
            txteditarprecio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txteditarprecio.Location = new Point(265, 348);
            txteditarprecio.Name = "txteditarprecio";
            txteditarprecio.Size = new Size(217, 29);
            txteditarprecio.TabIndex = 7;
            // 
            // txteditarcantidad
            // 
            txteditarcantidad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txteditarcantidad.Location = new Point(265, 452);
            txteditarcantidad.Name = "txteditarcantidad";
            txteditarcantidad.Size = new Size(217, 29);
            txteditarcantidad.TabIndex = 8;
            // 
            // btneditardatos
            // 
            btneditardatos.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btneditardatos.Location = new Point(265, 527);
            btneditardatos.Name = "btneditardatos";
            btneditardatos.Size = new Size(217, 38);
            btneditardatos.TabIndex = 9;
            btneditardatos.Text = "GUARDAR DATOS";
            btneditardatos.UseVisualStyleBackColor = true;
            btneditardatos.Click += btneditardatos_Click;
            // 
            // FrmEditarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(844, 697);
            Controls.Add(btneditardatos);
            Controls.Add(txteditarcantidad);
            Controls.Add(txteditarprecio);
            Controls.Add(txteditardescripcion);
            Controls.Add(txteditarnombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmEditarProducto";
            Text = "FrmEditarProducto";
            Load += FrmEditarProducto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txteditarnombre;
        private TextBox txteditardescripcion;
        private TextBox txteditarprecio;
        private TextBox txteditarcantidad;
        private Button btneditardatos;
    }
}