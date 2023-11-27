namespace Sysacad
{
    partial class CambiarContrasena
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
            btnVolverMenu = new Button();
            btnConfirmar = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnVolverMenu
            // 
            btnVolverMenu.Location = new Point(169, 232);
            btnVolverMenu.Name = "btnVolverMenu";
            btnVolverMenu.Size = new Size(75, 39);
            btnVolverMenu.TabIndex = 13;
            btnVolverMenu.Text = "Volver al menu";
            btnVolverMenu.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(60, 232);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(74, 39);
            btnConfirmar.TabIndex = 12;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 163);
            label3.Name = "label3";
            label3.Size = new Size(125, 15);
            label3.TabIndex = 11;
            label3.Text = "Confirmar contraseña:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(60, 181);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(184, 23);
            textBox2.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 109);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 9;
            label2.Text = "Nueva contraseña:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(60, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 23);
            textBox1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 52);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 7;
            label1.Text = "Cambio de contraseña";
            // 
            // CambiarContrasena
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 316);
            Controls.Add(btnVolverMenu);
            Controls.Add(btnConfirmar);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "CambiarContrasena";
            Text = "CambiarContrasena";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolverMenu;
        private Button btnConfirmar;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
    }
}