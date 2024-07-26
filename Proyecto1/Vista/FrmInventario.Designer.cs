namespace Proyecto1.Vista
{
    partial class FrmInventario
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
            btnarticulo = new Button();
            btneditar = new Button();
            btneliminar = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(244, 23);
            label1.Name = "label1";
            label1.Size = new Size(348, 32);
            label1.TabIndex = 0;
            label1.Text = "INVENTARIO DE PRODUCTOS";
            // 
            // btnarticulo
            // 
            btnarticulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnarticulo.Location = new Point(780, 98);
            btnarticulo.Name = "btnarticulo";
            btnarticulo.Size = new Size(123, 80);
            btnarticulo.TabIndex = 1;
            btnarticulo.Text = "Agregar Nuevo Producto";
            btnarticulo.UseVisualStyleBackColor = true;
            btnarticulo.Click += btnarticulo_Click;
            // 
            // btneditar
            // 
            btneditar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btneditar.Location = new Point(780, 231);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(123, 56);
            btneditar.TabIndex = 2;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = true;
            btneditar.Click += btneditar_Click;
            // 
            // btneliminar
            // 
            btneliminar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btneliminar.Location = new Point(780, 339);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(123, 55);
            btneliminar.TabIndex = 3;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click;
            // 
            // listView1
            // 
            listView1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listView1.Location = new Point(12, 98);
            listView1.Name = "listView1";
            listView1.Size = new Size(724, 531);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listviewarticulo_SelectedIndexChanged;
            // 
            // FrmInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(957, 712);
            Controls.Add(listView1);
            Controls.Add(btneliminar);
            Controls.Add(btneditar);
            Controls.Add(btnarticulo);
            Controls.Add(label1);
            Name = "FrmInventario";
            Text = "FrmVenta";
            Load += FrmVenta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnarticulo;
        private Button btneditar;
        private Button btneliminar;
        private ListView listView1;
    }
}