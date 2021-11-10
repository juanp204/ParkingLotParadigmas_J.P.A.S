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
    public partial class MDIParent : Form
    {
        public MDIParent()
        {
            InitializeComponent();
        }

        public Dictionary<int, Vehicle> carros = new Dictionary<int, Vehicle>();

        public void MDIParent_Load(object sender, EventArgs e)
        {
            ParkingLot parkinglot = new ParkingLot(carros)
            {
                MdiParent = this
            };
            this.Size = new Size(parkinglot.Size.Width+20, parkinglot.Size.Height+43);
            parkinglot.Show();
        }

        private void MDIParent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("Cerrando...");
            
        }
    }
}
