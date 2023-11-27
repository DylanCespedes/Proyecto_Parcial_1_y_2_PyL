namespace Sysacad
{
    partial class CrearCurso
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
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtCodigo = new TextBox();
            label3 = new Label();
            txtDescripcion = new RichTextBox();
            label4 = new Label();
            numbCupo = new NumericUpDown();
            btnCrear = new Button();
            label5 = new Label();
            txtHorario = new TextBox();
            label6 = new Label();
            txtAula = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numbCupo).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 24);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(154, 23);
            txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 2;
            label2.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(12, 77);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(154, 23);
            txtCodigo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 112);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 4;
            label3.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(12, 130);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(154, 114);
            txtDescripcion.TabIndex = 6;
            txtDescripcion.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 247);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 7;
            label4.Text = "Cantidad de cupo";
            // 
            // numbCupo
            // 
            numbCupo.Location = new Point(12, 265);
            numbCupo.Name = "numbCupo";
            numbCupo.Size = new Size(120, 23);
            numbCupo.TabIndex = 8;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(192, 130);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(143, 38);
            btnCrear.TabIndex = 9;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(184, 5);
            label5.Name = "label5";
            label5.Size = new Size(146, 15);
            label5.TabIndex = 11;
            label5.Text = "Horario de ingreso y cierre";
            // 
            // txtHorario
            // 
            txtHorario.Location = new Point(184, 24);
            txtHorario.Name = "txtHorario";
            txtHorario.Size = new Size(146, 23);
            txtHorario.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(184, 59);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 24;
            label6.Text = "Aula";
            // 
            // txtAula
            // 
            txtAula.Location = new Point(184, 77);
            txtAula.Name = "txtAula";
            txtAula.Size = new Size(52, 23);
            txtAula.TabIndex = 23;
            // 
            // CrearCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 304);
            Controls.Add(label6);
            Controls.Add(txtAula);
            Controls.Add(label5);
            Controls.Add(txtHorario);
            Controls.Add(btnCrear);
            Controls.Add(numbCupo);
            Controls.Add(label4);
            Controls.Add(txtDescripcion);
            Controls.Add(label3);
            Controls.Add(txtCodigo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Name = "CrearCurso";
            Text = "CrearCurso";
            ((System.ComponentModel.ISupportInitialize)numbCupo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private TextBox txtCodigo;
        private Label label3;
        private RichTextBox txtDescripcion;
        private Label label4;
        private NumericUpDown numbCupo;
        private Button btnCrear;
        private Label label5;
        private TextBox txtHorario;
        private Label label6;
        private TextBox txtAula;
    }
}