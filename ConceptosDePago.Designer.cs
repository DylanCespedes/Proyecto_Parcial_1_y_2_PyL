namespace Sysacad
{
    partial class ConceptosDePago
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
            dataGridView1 = new DataGridView();
            btnElegir = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(242, 294);
            dataGridView1.TabIndex = 0;
            // 
            // btnElegir
            // 
            btnElegir.Location = new Point(12, 323);
            btnElegir.Name = "btnElegir";
            btnElegir.Size = new Size(96, 57);
            btnElegir.TabIndex = 1;
            btnElegir.Text = "Elegir";
            btnElegir.UseVisualStyleBackColor = true;
            btnElegir.Click += btnElegir_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(158, 323);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(96, 57);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // ConceptosDePago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 392);
            Controls.Add(btnVolver);
            Controls.Add(btnElegir);
            Controls.Add(dataGridView1);
            Name = "ConceptosDePago";
            Text = "ConceptosDePago";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnElegir;
        private Button btnVolver;
    }
}