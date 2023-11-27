namespace Sysacad
{
    partial class ElegirMetodo
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
            btnTarjeta = new Button();
            btnTransferencia = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 32);
            label1.Name = "label1";
            label1.Size = new Size(171, 15);
            label1.TabIndex = 0;
            label1.Text = "Seleccione un metodo de pago";
            // 
            // btnTarjeta
            // 
            btnTarjeta.Location = new Point(25, 86);
            btnTarjeta.Name = "btnTarjeta";
            btnTarjeta.Size = new Size(130, 58);
            btnTarjeta.TabIndex = 1;
            btnTarjeta.Text = "Tarjeta de credito/debito";
            btnTarjeta.UseVisualStyleBackColor = true;
            btnTarjeta.Click += btnTarjeta_Click;
            // 
            // btnTransferencia
            // 
            btnTransferencia.Location = new Point(181, 86);
            btnTransferencia.Name = "btnTransferencia";
            btnTransferencia.Size = new Size(130, 58);
            btnTransferencia.TabIndex = 2;
            btnTransferencia.Text = "Transferencia bancaria";
            btnTransferencia.UseVisualStyleBackColor = true;
            btnTransferencia.Click += btnTransferencia_Click;
            // 
            // ElegirMetodo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(338, 205);
            Controls.Add(btnTransferencia);
            Controls.Add(btnTarjeta);
            Controls.Add(label1);
            Name = "ElegirMetodo";
            Text = "ElegirMetodo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnTarjeta;
        private Button btnTransferencia;
    }
}