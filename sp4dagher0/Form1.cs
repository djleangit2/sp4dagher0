using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sp4dagher0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        


        public float[,] matriz_importes = new float[5, 5];
        public void LlenarDatosMatriz()
        {
            for (int f = 0; f < matriz_importes.GetLength(0); f++)
            {
                for (int c = 0; c < matriz_importes.GetLength(1) - 1; c++)
                {
                    matriz_importes[f, c] = Convert.ToSingle(dgvTabla.Rows[f].Cells[c + 1].Value);
                }
            }

        }
        public void CargarTabla()
        {
            dgvTabla.Rows.Add();
            dgvTabla[0, 0].Value = "Julio";
            dgvTabla.Rows.Add();
            dgvTabla[0, 1].Value = "Esteban";
            dgvTabla.Rows.Add();
            dgvTabla[0, 2].Value = "Javier";
            dgvTabla.Rows.Add();
            dgvTabla[0, 3].Value = "Gonzalo";
            dgvTabla.Rows.Add();
            dgvTabla[0, 4].Value = "Alberto";
            for (int c = 1; c < dgvTabla.ColumnCount; c++)
            {
                for (int f = 0; f < dgvTabla.Rows.Count; f++)
                {
                    if (dgvTabla[c, f].Value == null)
                    {
                        dgvTabla[c, f].Value = 0;
                    }
                }
            }
        }

        public Form()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTotales_Click(object sender, EventArgs e)
        {
            lstTotales.Items.Clear();
            lstTotales.Items.Add("Julio: " + matriz_importes[0, 4]);
            lstTotales.Items.Add("Esteban: " + matriz_importes[1, 4]);
            lstTotales.Items.Add("Javier: " + matriz_importes[2, 4]);
            lstTotales.Items.Add("Gonzalo: " + matriz_importes[3, 4]);
            lstTotales.Items.Add("Alberto: " + matriz_importes[4, 4]);

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            Array.Clear(matriz_importes, 0, matriz_importes.Length);
            bool datos_validados = true;
            for (int c = 1; c < dgvTabla.ColumnCount; c++)
            {
                for (int r = 0; r < dgvTabla.Rows.Count; r++)
                {
                    if (dgvTabla[c, r].Value == null)
                    {
                        datos_validados = false;
                        MessageBox.Show("Error faltan datos en la tabla");
                    }
                }
            }
            if (datos_validados == true)
            {
                MessageBox.Show("Datos validados");
            }
            LlenarDatosMatriz();
            for (int f = 0; f < matriz_importes.GetLength(0); f++)
            {
                for (int c = 0; c < matriz_importes.GetLength(1) - 1; c++)
                {
                    matriz_importes[f, 4] = matriz_importes[f, 4] + matriz_importes[f, c];
                }
            }
        }

        private void btnMozo_Click(object sender, EventArgs e)
        {
            float mayorvalor = matriz_importes[0, 0];
            int indice_mayor = 0;
            for (int f = 0; f < matriz_importes.GetLength(0); f++)
            {
                if (mayorvalor < matriz_importes[f, 4])
                {
                    mayorvalor = matriz_importes[f, 4];
                    indice_mayor = f;
                }
            }
            if (indice_mayor == 0)
            {
                txtMozo.Text = "Julio $" + matriz_importes[0, 4];
            }
            else
            {
                if (indice_mayor == 1)
                {
                    txtMozo.Text = "Esteban $" + matriz_importes[1, 4];
                }
                else
                {
                    if (indice_mayor == 2)
                    {
                        txtMozo.Text = "Javier $" + matriz_importes[2, 4];
                    }
                    else
                    {
                        if (indice_mayor == 3)
                        {
                            txtMozo.Text = "Gonzalo $" + matriz_importes[3, 4];
                        }
                        else
                        {
                            if (indice_mayor == 4)
                            {
                                txtMozo.Text = "Alberto $" + matriz_importes[4, 4];
                            }
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void lstTotales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnValidar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
    }
}
