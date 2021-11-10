using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotParadigmas_J.P.A.S.Clases
{
    public class Vehicle
    {
        public bool activo = false;
        public string tipo { get; set; }
        public string placa { get; set; }
        public string marca { get; set; }
        public string identificacion_driver { get; set; }
        public string sexo_driver { get; set; }
        public bool afiliado_driver { get; set; }
        public DateTime date { get; set; }
    }
}
