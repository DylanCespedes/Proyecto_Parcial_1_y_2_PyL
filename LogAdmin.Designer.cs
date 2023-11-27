namespace Sysacad
{
    partial class LogAdmin
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
            btnVolver = new Button();
            label2 = new Label();
            txtCorreo = new TextBox();
            label1 = new Label();
            txtPassword = new TextBox();
            btnAdminIngresar = new Button();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(20, 160);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(88, 45);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "Cerrar";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 38);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 8;
            label2.Text = "Correo";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(65, 56);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(156, 23);
            txtCorreo.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 94);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 6;
            label1.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(65, 112);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(156, 23);
            txtPassword.TabIndex = 5;
            // 
            // btnAdminIngresar
            // 
            btnAdminIngresar.Location = new Point(178, 159);
            btnAdminIngresar.Name = "btnAdminIngresar";
            btnAdminIngresar.Size = new Size(94, 46);
            btnAdminIngresar.TabIndex = 10;
            btnAdminIngresar.Text = "Ingresar";
            btnAdminIngresar.UseVisualStyleBackColor = true;
            btnAdminIngresar.Click += btnAdminIngresar_Click;
            // 
            // LogAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(304, 222);
            Controls.Add(btnAdminIngresar);
            Controls.Add(btnVolver);
            Controls.Add(label2);
            Controls.Add(txtCorreo);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Name = "LogAdmin";
            Text = "LogAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label label2;
        private TextBox txtCorreo;
        private Label label1;
        private TextBox txtPassword;
        private Button btnAdminIngresar;
    }
}