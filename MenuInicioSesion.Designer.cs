namespace Sysacad
{
    partial class formIniciar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtContrasenia = new TextBox();
            txtCorreo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnIngresar = new Button();
            btnCrear = new Button();
            label5 = new Label();
            btnLogAdmin = new Button();
            SuspendLayout();
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(98, 222);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '*';
            txtContrasenia.Size = new Size(251, 23);
            txtContrasenia.TabIndex = 0;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(98, 156);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(251, 23);
            txtCorreo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 72);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 128);
            label2.Location = new Point(160, 72);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 3;
            label2.Text = "UTN FRA - SYSACAD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 138);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 4;
            label3.Text = "Correo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 204);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 5;
            label4.Text = "Contraseña:";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(160, 275);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(116, 32);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(160, 327);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(116, 33);
            btnCrear.TabIndex = 7;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 255, 128);
            label5.Location = new Point(100, 106);
            label5.Name = "label5";
            label5.Size = new Size(249, 15);
            label5.TabIndex = 8;
            label5.Text = "Bienvenido al sistema SYSACAD de UTN - FRA";
            // 
            // btnLogAdmin
            // 
            btnLogAdmin.Location = new Point(331, 12);
            btnLogAdmin.Name = "btnLogAdmin";
            btnLogAdmin.Size = new Size(104, 57);
            btnLogAdmin.TabIndex = 9;
            btnLogAdmin.Text = "Ingresar como Administrador";
            btnLogAdmin.UseVisualStyleBackColor = true;
            btnLogAdmin.Click += btnLogAdmin_Click;
            // 
            // formIniciar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(447, 396);
            Controls.Add(btnLogAdmin);
            Controls.Add(label5);
            Controls.Add(btnCrear);
            Controls.Add(btnIngresar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCorreo);
            Controls.Add(txtContrasenia);
            Name = "formIniciar";
            Text = "SYSACAD.COM";
            Load += formIniciar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContrasenia;
        private TextBox txtCorreo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnIngresar;
        private Button btnCrear;
        private Label label5;
        private Button btnLogAdmin;
    }
}