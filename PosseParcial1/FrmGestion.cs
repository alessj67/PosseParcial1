using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PosseParcial1
{
    public partial class FrmGestion : Form
    {
        public FrmGestion()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FrmGestion_Load(object sender, EventArgs e)
        {
           CargarRubros();
        }

        private void CargarRubros()
        {
            cmbRubro.Items.Clear();

            StreamReader ar = new StreamReader("RUBROS.csv");

            while (!ar.EndOfStream)
            {

                string linea = ar.ReadLine();
                cmbRubro.Items.Add(linea);

            }

            ar.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbRubro.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un rubro.");
            }
            else
            {
                dgvGrilla.Rows.Clear(); 
                int cont = 0;
                cont++;
                decimal total = 0;
                StreamReader ar = new StreamReader("ARTICULOS.csv");
                while (!ar.EndOfStream)
                {
                    string lin = ar.ReadLine();
                    string[] datos = lin.Split(';');
                    if (datos[3] == cmbRubro.Text)
                    {
                        decimal cost = Convert.ToDecimal(datos[2]);
                        int stock = Convert.ToInt32(datos[4]);
                        decimal valor = cost * stock;

                        dgvGrilla.Rows.Add(datos[0], datos[1], cost, stock, valor);

                        cont++;
                        total += valor;
                    }
                }
                ar.Close();
                lblTotal.Text = "$" + total.ToString();
                lblCant.Text = cont.ToString();
                
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (cmbRubro.SelectedItem != null)
            {
                string nomAr = "ARTICULOS__" + cmbRubro.Text + ".CSV";
                StreamReader ar = new StreamReader("ARTICULOS.csv");
                StreamWriter arExport = new StreamWriter(nomAr, false);

                arExport.WriteLine("Codigo; Descripcion; Costo; Stock; Valor; Valor en Stock");
                while (!ar.EndOfStream)
                {
                    string lin = ar.ReadLine();
                    string[] datos = lin.Split(';');


                    if (datos[3] == cmbRubro.Text)
                    {
                        decimal cost = Convert.ToDecimal(datos[2]);
                        int stock = Convert.ToInt32(datos[4]);
                        decimal valor = cost * stock;

                        arExport.WriteLine(datos[0] + ';' + datos[1] + ';' + cost + ';' + stock + ';' + valor + ';' + valor);
                    }
                }
                ar.Close();
                ar.Dispose();
                arExport.Close();
                arExport.Dispose();

                MessageBox.Show("Los datos se exportaron en " + nomAr, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
       
                MessageBox.Show("Selecciona un Rubro ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void lnkAcerca_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAcercaDe pna = new FrmAcercaDe();
            pna.ShowDialog(this);
           
        }
    }
}
