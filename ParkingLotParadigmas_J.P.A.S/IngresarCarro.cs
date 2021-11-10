using ParkingLotParadigmas_J.P.A.S.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ParkingLotParadigmas_J.P.A.S
{
    public partial class IngresarCarro : Form
    {
        public Dictionary<int, Vehicle> carrosingresar;

        public IngresarCarro(Dictionary<int, Vehicle> carros)
        {
            InitializeComponent();
            carrosingresar = carros;

        }

        private void Ingresarbtn_Click(object sender, EventArgs e)
        {
            if ((Tipocbx.Text != "") & (Placatbx.Text != "") & (Marcatbx.Text != "") & (Idencbx.Text != "") & (Sexocbx.Text != ""))
            {
                for(int i = 0; i<10; i++)
                {
                    try
                    {
                        if (carrosingresar.Count == 0)
                        {
                            carrosingresar.Add(i, new Vehicle { tipo = Tipocbx.Text, placa = Placatbx.Text, marca = Marcatbx.Text, identificacion_driver = Idencbx.Text, sexo_driver = Sexocbx.Text, afiliado_driver = Afiliadochbx.Checked, date=DateTime.Now, activo=true });;
                            break;
                        }

                        if (carrosingresar[i].activo)
                        {
                            continue;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("catch");
                        carrosingresar.Add(i, new Vehicle { tipo = Tipocbx.Text, placa = Placatbx.Text, marca = Marcatbx.Text, identificacion_driver = Idencbx.Text, sexo_driver = Sexocbx.Text, afiliado_driver = Afiliadochbx.Checked, date = DateTime.Now, activo =true });
                        break;
                    }
                }

                this.Hide();
                ParkingLot parkinglot = new ParkingLot(carrosingresar)
                {
                    MdiParent = this.MdiParent
                };
                this.MdiParent.Size = new Size(parkinglot.Size.Width + 20, parkinglot.Size.Height + 43);
                parkinglot.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("rellene todos los campos");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ParkingLot parkinglot = new ParkingLot(carrosingresar)
            {
                MdiParent = this.MdiParent
            };
            this.MdiParent.Size = new Size(parkinglot.Size.Width + 20, parkinglot.Size.Height + 43);
            parkinglot.Show();
            this.Close();
        }
    }
}
