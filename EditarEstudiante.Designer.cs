namespace Sysacad
{
    partial class EditarEstudiante
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
            pictureBox1 = new PictureBox();
            btnEditar = new Button();
            btnVolver = new Button();
            dataGridView1 = new DataGridView();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.descarga1;
            pictureBox1.Location = new Point(604, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(540, 136);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(151, 44);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar datos";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(540, 236);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(151, 43);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver al menu";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(508, 309);
            dataGridView1.TabIndex = 3;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(540, 186);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(151, 44);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // EditarEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(703, 344);
            Controls.Add(btnEliminar);
            Controls.Add(dataGridView1);
            Controls.Add(btnVolver);
            Controls.Add(btnEditar);
            Controls.Add(pictureBox1);
            Name = "EditarEstudiante";
            Text = "Editar Estudiante";
            Load += EditarEstudiante_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnEditar;
        private Button btnVolver;
        private DataGridView dataGridView1;
        private Button btnEliminar;
    }
}