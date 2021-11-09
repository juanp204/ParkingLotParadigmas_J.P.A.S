using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingLotParadigmas_J.P.A.S
{
    public partial class MDIParent : Form
    {
        public MDIParent()
        {
            InitializeComponent();
        }


        private void MDIParent_Load(object sender, EventArgs e)
        {
            ParkingLot parking = new ParkingLot
            {
                MdiParent = this
            };
            this.Size = new Size(parking.Size.Width+20, parking.Size.Height+43);
            parking.Show();
        }
    }
}
