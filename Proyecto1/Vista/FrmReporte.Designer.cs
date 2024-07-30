namespace Proyecto1.Vista
{
    partial class FrmReporte
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
            btnfiltrofechas = new Button();
            btnComprasMayores = new Button();
            btnVentasMayores = new Button();
            listView1 = new ListView();
            cbmeses = new ComboBox();
            btnmesyaño = new Button();
            cbanos = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(281, 27);
            label1.Name = "label1";
            label1.Size = new Size(268, 32);
            label1.TabIndex = 0;
            label1.Text = "REPORTES Y ANÁLISIS";
            // 
            // btnfiltrofechas
            // 
            btnfiltrofechas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnfiltrofechas.Location = new Point(428, 84);
            btnfiltrofechas.Name = "btnfiltrofechas";
            btnfiltrofechas.Size = new Size(121, 81);
            btnfiltrofechas.TabIndex = 1;
            btnfiltrofechas.Text = "Filtrar Ventas por Fecha";
            btnfiltrofechas.UseVisualStyleBackColor = true;
            btnfiltrofechas.Click += btnfiltrofechas_Click;
            // 
            // btnComprasMayores
            // 
            btnComprasMayores.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnComprasMayores.Location = new Point(28, 84);
            btnComprasMayores.Name = "btnComprasMayores";
            btnComprasMayores.Size = new Size(141, 80);
            btnComprasMayores.TabIndex = 2;
            btnComprasMayores.Text = "Clientes con Mayores Compras";
            btnComprasMayores.UseVisualStyleBackColor = true;
            btnComprasMayores.Click += btncompras_Click;
            // 
            // btnVentasMayores
            // 
            btnVentasMayores.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVentasMayores.Location = new Point(226, 83);
            btnVentasMayores.Name = "btnVentasMayores";
            btnVentasMayores.Size = new Size(135, 80);
            btnVentasMayores.TabIndex = 3;
            btnVentasMayores.Text = "Vendedores con Mayores Ventas";
            btnVentasMayores.UseVisualStyleBackColor = true;
            btnVentasMayores.Click += btnventas_Click;
            // 
            // listView1
            // 
            listView1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            listView1.Location = new Point(28, 235);
            listView1.Name = "listView1";
            listView1.Size = new Size(919, 608);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // cbmeses
            // 
            cbmeses.DropDownStyle = ComboBoxStyle.DropDownList;
            cbmeses.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cbmeses.FormattingEnabled = true;
            cbmeses.Location = new Point(801, 84);
            cbmeses.Name = "cbmeses";
            cbmeses.Size = new Size(121, 29);
            cbmeses.TabIndex = 1;
            cbmeses.Visible = false;
            cbmeses.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnmesyaño
            // 
            btnmesyaño.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnmesyaño.Location = new Point(631, 83);
            btnmesyaño.Name = "btnmesyaño";
            btnmesyaño.Size = new Size(127, 79);
            btnmesyaño.TabIndex = 6;
            btnmesyaño.Text = "Filtrar Ventas por Mes y Año";
            btnmesyaño.UseVisualStyleBackColor = true;
            btnmesyaño.Click += button2_Click;
            // 
            // cbanos
            // 
            cbanos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbanos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cbanos.FormattingEnabled = true;
            cbanos.Location = new Point(801, 136);
            cbanos.Name = "cbanos";
            cbanos.Size = new Size(121, 29);
            cbanos.TabIndex = 1;
            cbanos.Visible = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(428, 186);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(330, 29);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.Visible = false;
            // 
            // FrmReporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGoldenrod;
            ClientSize = new Size(1065, 906);
            Controls.Add(dateTimePicker1);
            Controls.Add(cbanos);
            Controls.Add(btnmesyaño);
            Controls.Add(cbmeses);
            Controls.Add(listView1);
            Controls.Add(btnVentasMayores);
            Controls.Add(btnComprasMayores);
            Controls.Add(btnfiltrofechas);
            Controls.Add(label1);
            Name = "FrmReporte";
            Text = "FrmReporte";
            Load += FrmReporte_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnfiltrofechas;
        private Button btnComprasMayores;
        private Button btnVentasMayores;
        private ListView listView1;
        private ComboBox cbmeses;
        private Button btnmesyaño;
        private ComboBox cbanos;
        private DateTimePicker dateTimePicker1;
    }
}