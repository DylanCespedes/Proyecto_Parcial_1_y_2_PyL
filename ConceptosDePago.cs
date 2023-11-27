using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sysacad
{
    public partial class ConceptosDePago : Form
    {
        public ConceptosDePago()
        {
            InitializeComponent();

            dataGridView1.ColumnCount = 2;

            dataGridView1.Columns[0].Name = "Concepto";
            dataGridView1.Columns[1].Name = "Precio";

            dataGridView1.Rows.Add("Libro de historia de la computadora", "$15290");
            dataGridView1.Rows.Add("Libro de Ingles I", "$11279");
            dataGridView1.Rows.Add("Libro de Matematica", "$8287");
            dataGridView1.Rows.Add("Cuota Mensual de Diciembre", "$14500");
            dataGridView1.Rows.Add("Cuota Mensual de Noviembre", "$14500");
            dataGridView1.Rows.Add("Cuota Mensual de Octubre", "$14500");
            dataGridView1.Rows.Add("Cuota Mensual de Septiembre", "$14500");
            dataGridView1.Rows.Add("Cuota Mensual de Agosto", "$14500");

        }

        private void btnElegir_Click(object sender, EventArgs e)
        {
            try
            {
                string Concepto = dataGridView1.SelectedRows[0].Cells["Concepto"].Value.ToString();

                DialogResult resultado = MessageBox.Show("Estas seguro de querer pagar lo seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(resultado == DialogResult.Yes)
                {
                    var btnElegir = new ElegirMetodo();
                    this.Hide();
                    btnElegir.ShowDialog();
                    this.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Elige una opciones disponibles para poder pagar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
