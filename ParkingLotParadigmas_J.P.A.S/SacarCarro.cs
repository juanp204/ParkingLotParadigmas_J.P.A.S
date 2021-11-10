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
using System.IO;

namespace ParkingLotParadigmas_J.P.A.S
{
    public partial class SacarCarro : Form
    {
        public Dictionary<int, Vehicle> carrossacar;

        public SacarCarro(Dictionary<int, Vehicle> carros)
        {
            InitializeComponent();
            carrossacar = carros;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool confirmar = false;
            int vehicle = 0;
            for (int i = 0; i < 11; i++)
            {
                try
                {
                    if (Sacarcmbx.Text == carrossacar[i].placa)
                    {
                        confirmar = true;
                        vehicle = i;
                    }
                }
                catch
                {
                    continue;
                }

            }
            if (confirmar)
            {
                carrossacar.Remove(vehicle);

                //Console.WriteLine("Cerrando...");
                //try
                //{
                //    using (StreamWriter sw = new StreamWriter("Parqueadero.txt"))
                //    {
                //        sw.WriteLine();
                //    }
                //}
                //catch (Exception)
                //{
                //    MessageBox.Show("Error");
                //}



                this.Hide();
                ParkingLot parking = new ParkingLot(carrossacar)
                {
                    MdiParent = this.MdiParent
                };
                this.MdiParent.Size = new Size(parking.Size.Width + 20, parking.Size.Height + 43);
                parking.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("no se encontro el carro");
            }
            //50 pesos min carro
            //camioneta micro bus 20%+
            //afiliado 10%-
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ParkingLot parking = new ParkingLot(carrossacar)
            {
                MdiParent = this.MdiParent
            };
            this.MdiParent.Size = new Size(parking.Size.Width + 20, parking.Size.Height + 43);
            parking.Show();
            this.Close();
        }

        private void SacarCarro_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 11; i++)
            {
                try
                {
                    Sacarcmbx.Items.Add(carrossacar[i].placa);
                }
                catch { }
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            bool confirmar = false;
            Vehicle vehicle = new Vehicle();
            for (int i = 0; i < 11; i++)
            {
                try
                {
                    if (Sacarcmbx.Text == carrossacar[i].placa)
                    {
                        confirmar = true;
                        vehicle = carrossacar[i];
                    }
                }
                catch
                {
                    continue;
                }
                
            }
            if (confirmar)
            {
                cedulalbl.Text = vehicle.identificacion_driver;
                marcalbl.Text = vehicle.marca;
                tipolbl.Text = vehicle.tipo;
                sexolbl.Text = vehicle.sexo_driver;
                if (vehicle.activo)
                {
                    afiliadolbl.Text = "SI";
                }
                else
                {
                    afiliadolbl.Text = "NO";
                }
                tiempolbl.Text = vehicle.date.ToString();
            }
            else
            {
                MessageBox.Show("no se encontro el carro");
            }
        }

        private void calcularbtn_Click(object sender, EventArgs e)
        {
            bool confirmar = false;
            Vehicle vehicle = new Vehicle();
            for (int i = 0; i < 11; i++)
            {
                try
                {
                    if (Sacarcmbx.Text == carrossacar[i].placa)
                    {
                        confirmar = true;
                        vehicle = carrossacar[i];
                    }
                }
                catch
                {
                    continue;
                }

            }
            if (confirmar)
            {
                DateTime timepo2 = DateTime.Now;
                TimeSpan tiempoF = timepo2-vehicle.date;
                if (vehicle.tipo == "Carro particular")
                {
                    if (vehicle.afiliado_driver)
                    {
                        MessageBox.Show($"tiene que pagar {Convert.ToInt64(((tiempoF.TotalSeconds / 60) * 50)-(((tiempoF.TotalSeconds / 60) * 50)*0.1))} pesos");
                    }
                    else
                    {
                        MessageBox.Show($"tiene que pagar {Convert.ToInt64((tiempoF.TotalSeconds / 60) * 50)} pesos");
                    }
                }
                else
                {
                    if (vehicle.afiliado_driver)
                    {
                        MessageBox.Show($"tiene que pagar {Convert.ToInt64(((tiempoF.TotalSeconds / 60) * 60) - (((tiempoF.TotalSeconds / 60) * 60) * 0.1))} pesos");
                    }
                    else
                    {
                        MessageBox.Show($"tiene que pagar {Convert.ToInt64((tiempoF.TotalSeconds / 60) * 60)} pesos");
                    }
                }
            }
            else
            {
                MessageBox.Show("no se encontro el carro");
            }
        }
    }
}
