using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkingLotParadigmas_J.P.A.S.Clases;

namespace ParkingLotParadigmas_J.P.A.S
{
    public partial class ParkingLot : Form
    {
        public Dictionary<int, Vehicle> carrosparking;

        public ParkingLot(Dictionary<int, Vehicle> carros)
        {
            InitializeComponent();
            carrosparking = carros;
            for (int i=0; i<10; i++)
            {
                try
                {
                    if (carrosparking[i].activo)
                    {
                        if (i == 0)
                        {
                            lbl1.Text = $"Ocupado\n  {carrosparking[i].placa}";
                        }
                        if (i == 1)
                        {
                            lbl2.Text = $"Ocupado\n  {carrosparking[i].placa}";
                        }
                        if (i == 2)
                        {
                            lbl3.Text = $"Ocupado\n  {carrosparking[i].placa}";
                        }
                        if (i == 3)
                        {
                            lbl4.Text = $"Ocupado\n  {carrosparking[i].placa}";
                        }
                        if (i == 4)
                        {
                            lbl5.Text = $"Ocupado\n  {carrosparking[i].placa}";
                        }
                        if (i == 5)
                        {
                            lbl6.Text = $"Ocupado\n  {carrosparking[i].placa}";
                        }
                        if (i == 6)
                        {
                            lbl7.Text = $"Ocupado\n  {carrosparking[i].placa}";
                        }
                        if (i == 7)
                        {
                            lbl8.Text = $"Ocupado\n  {carrosparking[i].placa}";
                        }
                        if (i == 8)
                        {
                            lbl9.Text = $"Ocupado\n  {carrosparking[i].placa}";
                        }
                        if (i == 9)
                        {
                            lbl10.Text = $"Ocupado\n  {carrosparking[i].placa}";
                        }
                    }

                }
                catch
                {
                    continue;
                }
                
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            IngresarCarro ing = new IngresarCarro(carrosparking)
            {
                MdiParent = this.MdiParent
            };
            this.MdiParent.Size = new Size(ing.Size.Width + 20, ing.Size.Height + 43);
            ing.Show();
            this.Close();
        }

        private void ParkingLot_Load(object sender, EventArgs e)
        {
            // for (int x )
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SacarCarro sacar = new SacarCarro(carrosparking)
            {
                MdiParent = this.MdiParent
            };
            this.MdiParent.Size = new Size(sacar.Size.Width + 20, sacar.Size.Height + 43);
            sacar.Show();
            this.Close();
        }
    }

}
