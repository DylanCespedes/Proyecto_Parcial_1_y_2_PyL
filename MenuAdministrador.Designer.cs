namespace Sysacad
{
    partial class MenuAdministrador
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
            btnCrearEstudiante = new Button();
            btnEditarEstudiante = new Button();
            btnCerrarSesion = new Button();
            label3 = new Label();
            btnCursos = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(49, 52);
            label1.Name = "label1";
            label1.Size = new Size(197, 15);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido al modo Administracion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(94, 37);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 1;
            label2.Text = "UTN FRA - SYSACAD";
            // 
            // btnCrearEstudiante
            // 
            btnCrearEstudiante.Location = new Point(50, 82);
            btnCrearEstudiante.Name = "btnCrearEstudiante";
            btnCrearEstudiante.Size = new Size(196, 41);
            btnCrearEstudiante.TabIndex = 2;
            btnCrearEstudiante.Text = "Crear estudiante";
            btnCrearEstudiante.UseVisualStyleBackColor = true;
            btnCrearEstudiante.Click += btnCrearEstudiante_Click;
            // 
            // btnEditarEstudiante
            // 
            btnEditarEstudiante.Location = new Point(50, 129);
            btnEditarEstudiante.Name = "btnEditarEstudiante";
            btnEditarEstudiante.Size = new Size(196, 40);
            btnEditarEstudiante.TabIndex = 3;
            btnEditarEstudiante.Text = "Editar/Eliminar estudiante";
            btnEditarEstudiante.UseVisualStyleBackColor = true;
            btnEditarEstudiante.Click += btnEditarEstudiante_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(50, 221);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(196, 43);
            btnCerrarSesion.TabIndex = 5;
            btnCerrarSesion.Text = "Cerrar sesion";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(140, 267);
            label3.Name = "label3";
            label3.Size = new Size(93, 17);
            label3.TabIndex = 6;
            label3.Text = "UTN FRA 2023";
            // 
            // btnCursos
            // 
            btnCursos.Location = new Point(50, 175);
            btnCursos.Name = "btnCursos";
            btnCursos.Size = new Size(197, 40);
            btnCursos.TabIndex = 7;
            btnCursos.Text = "Cursos";
            btnCursos.UseVisualStyleBackColor = true;
            btnCursos.Click += btnCursos_Click;
            // 
            // MenuAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.descarga;
            ClientSize = new Size(288, 362);
            Controls.Add(btnCursos);
            Controls.Add(label3);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnEditarEstudiante);
            Controls.Add(btnCrearEstudiante);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MenuAdministrador";
            Text = "Menu Administrativo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnCrearEstudiante;
        private Button btnEditarEstudiante;
        private Button btnCerrarSesion;
        private Label label3;
        private Button btnCursos;
    }
}