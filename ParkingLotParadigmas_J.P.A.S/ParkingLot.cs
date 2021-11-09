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
        public ParkingLot()
        {
            InitializeComponent();
        }

        Dictionary<int, Vehicle> parking = new Dictionary<int, Vehicle>();

        Vehicle[] carros = { new Vehicle(), new Vehicle(), new Vehicle(), new Vehicle(), new Vehicle(), new Vehicle(), new Vehicle(), new Vehicle(), new Vehicle(), new Vehicle() };


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            IngresarCarro ing = new IngresarCarro
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
    }

}
