namespace Proyecto1.Vista
{
    partial class FrmHistorialCliente
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
            listView1 = new ListView();
            label1 = new Label();
            lbcliente = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listView1.Location = new Point(65, 164);
            listView1.Name = "listView1";
            listView1.Size = new Size(534, 603);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(137, 24);
            label1.Name = "label1";
            label1.Size = new Size(203, 25);
            label1.TabIndex = 1;
            label1.Text = "Historial de Compras ";
            // 
            // lbcliente
            // 
            lbcliente.AutoSize = true;
            lbcliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbcliente.Location = new Point(65, 96);
            lbcliente.Name = "lbcliente";
            lbcliente.Size = new Size(83, 25);
            lbcliente.TabIndex = 2;
            lbcliente.Text = "Cliente: ";
            lbcliente.Click += label2_Click;
            // 
            // FrmHistorialCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OliveDrab;
            ClientSize = new Size(685, 847);
            Controls.Add(lbcliente);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "FrmHistorialCliente";
            Text = "FrmHistorialCliente";
            Load += FrmHistorialCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label label1;
        private Label lbcliente;
    }
}