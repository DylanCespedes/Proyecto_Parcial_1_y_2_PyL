﻿namespace Sysacad
{
    partial class EditarCurso
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
            btnEditar = new Button();
            numbCupo = new NumericUpDown();
            label4 = new Label();
            txtDescripcion = new RichTextBox();
            label3 = new Label();
            txtCodigo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtNombre = new TextBox();
            label5 = new Label();
            txtHorario = new TextBox();
            label6 = new Label();
            txtAula = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numbCupo).BeginInit();
            SuspendLayout();
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(187, 134);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(143, 38);
            btnEditar.TabIndex = 18;
            btnEditar.Text = "Guardar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // numbCupo
            // 
            numbCupo.Location = new Point(12, 269);
            numbCupo.Name = "numbCupo";
            numbCupo.Size = new Size(120, 23);
            numbCupo.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 251);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 16;
            label4.Text = "Cantidad de cupo";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(12, 134);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(154, 114);
            txtDescripcion.TabIndex = 15;
            txtDescripcion.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 116);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 14;
            label3.Text = "Descripcion";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(12, 81);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(154, 23);
            txtCodigo.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 12;
            label2.Text = "Codigo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 11;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 28);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(154, 23);
            txtNombre.TabIndex = 10;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(187, 10);
            label5.Name = "label5";
            label5.Size = new Size(136, 15);
            label5.TabIndex = 20;
            label5.Text = "Horario de inicio y cierre";
            // 
            // txtHorario
            // 
            txtHorario.Location = new Point(187, 28);
            txtHorario.Name = "txtHorario";
            txtHorario.Size = new Size(143, 23);
            txtHorario.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(187, 63);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 22;
            label6.Text = "Aula";
            // 
            // txtAula
            // 
            txtAula.Location = new Point(187, 81);
            txtAula.Name = "txtAula";
            txtAula.Size = new Size(45, 23);
            txtAula.TabIndex = 21;
            // 
            // EditarCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 308);
            Controls.Add(label6);
            Controls.Add(txtAula);
            Controls.Add(label5);
            Controls.Add(txtHorario);
            Controls.Add(btnEditar);
            Controls.Add(numbCupo);
            Controls.Add(label4);
            Controls.Add(txtDescripcion);
            Controls.Add(label3);
            Controls.Add(txtCodigo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Name = "EditarCurso";
            Text = "EditarCurso";
            ((System.ComponentModel.ISupportInitialize)numbCupo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEditar;
        private NumericUpDown numbCupo;
        private Label label4;
        private RichTextBox txtDescripcion;
        private Label label3;
        private TextBox txtCodigo;
        private Label label2;
        private Label label1;
        private TextBox txtNombre;
        private Label label5;
        private TextBox txtHorario;
        private Label label6;
        private TextBox txtAula;
    }
}