namespace Proyecto1.Vista
{
    partial class FrmFacturacion
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
            cbclientes = new ComboBox();
            cbtipopago = new ComboBox();
            txtcantidad = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbproducto = new ComboBox();
            label5 = new Label();
            btnagregar = new Button();
            listView1 = new ListView();
            btnfactura = new Button();
            lbcajero = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(415, 21);
            label1.Name = "label1";
            label1.Size = new Size(239, 32);
            label1.TabIndex = 0;
            label1.Text = "GENERAR FACTURA";
            label1.Click += label1_Click;
            // 
            // cbclientes
            // 
            cbclientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbclientes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbclientes.FormattingEnabled = true;
            cbclientes.Location = new Point(50, 129);
            cbclientes.Name = "cbclientes";
            cbclientes.Size = new Size(319, 33);
            cbclientes.TabIndex = 1;
            cbclientes.SelectedIndexChanged += cbclientes_SelectedIndexChanged;
            // 
            // cbtipopago
            // 
            cbtipopago.DropDownStyle = ComboBoxStyle.DropDownList;
            cbtipopago.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cbtipopago.FormattingEnabled = true;
            cbtipopago.Items.AddRange(new object[] { "Efectivo\t", "Tarjeta", "Transferencia" });
            cbtipopago.Location = new Point(46, 457);
            cbtipopago.Name = "cbtipopago";
            cbtipopago.Size = new Size(134, 29);
            cbtipopago.TabIndex = 2;
            cbtipopago.SelectedIndexChanged += cbtipopago_SelectedIndexChanged;
            // 
            // txtcantidad
            // 
            txtcantidad.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtcantidad.Location = new Point(50, 284);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(100, 35);
            txtcantidad.TabIndex = 4;
            txtcantidad.TextChanged += txtcantidad_TextChanged;
            txtcantidad.KeyPress += txtcantidad_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(50, 215);
            label2.Name = "label2";
            label2.Size = new Size(122, 30);
            label2.TabIndex = 5;
            label2.Text = "CANTIDAD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(46, 390);
            label3.Name = "label3";
            label3.Size = new Size(178, 25);
            label3.TabIndex = 6;
            label3.Text = "MÉTODO DE PAGO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(50, 87);
            label4.Name = "label4";
            label4.Size = new Size(201, 30);
            label4.TabIndex = 7;
            label4.Text = "LISTA DE CLIENTES";
            // 
            // cbproducto
            // 
            cbproducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbproducto.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbproducto.FormattingEnabled = true;
            cbproducto.Location = new Point(507, 129);
            cbproducto.Name = "cbproducto";
            cbproducto.Size = new Size(393, 33);
            cbproducto.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(507, 87);
            label5.Name = "label5";
            label5.Size = new Size(232, 30);
            label5.TabIndex = 9;
            label5.Text = "LISTA DE PRODUCTOS";
            // 
            // btnagregar
            // 
            btnagregar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnagregar.Location = new Point(195, 264);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(125, 62);
            btnagregar.TabIndex = 10;
            btnagregar.Text = "AGREGAR PRODUCTO A FACTURA";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listView1.Location = new Point(503, 209);
            listView1.Name = "listView1";
            listView1.Size = new Size(572, 485);
            listView1.TabIndex = 11;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // btnfactura
            // 
            btnfactura.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnfactura.Location = new Point(50, 614);
            btnfactura.Name = "btnfactura";
            btnfactura.Size = new Size(130, 55);
            btnfactura.TabIndex = 12;
            btnfactura.Text = "REALIZAR FACTURA";
            btnfactura.UseVisualStyleBackColor = true;
            btnfactura.Click += button2_Click;
            // 
            // lbcajero
            // 
            lbcajero.AutoSize = true;
            lbcajero.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbcajero.Location = new Point(50, 21);
            lbcajero.Name = "lbcajero";
            lbcajero.Size = new Size(84, 25);
            lbcajero.TabIndex = 13;
            lbcajero.Text = "Cajero : ";
            lbcajero.Click += lbcajero_Click;
            // 
            // FrmFacturacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1151, 847);
            Controls.Add(lbcajero);
            Controls.Add(btnfactura);
            Controls.Add(listView1);
            Controls.Add(btnagregar);
            Controls.Add(label5);
            Controls.Add(cbproducto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtcantidad);
            Controls.Add(cbtipopago);
            Controls.Add(cbclientes);
            Controls.Add(label1);
            Name = "FrmFacturacion";
            Text = "FrmFacturacion";
            Load += FrmFacturacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbclientes;
        private ComboBox cbtipopago;
        private TextBox txtcantidad;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbproducto;
        private Label label5;
        private Button btnagregar;
        private ListView listView1;
        private Button btnfactura;
        private Label lbcajero;
    }
}