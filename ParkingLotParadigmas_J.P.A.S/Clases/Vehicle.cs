using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotParadigmas_J.P.A.S.Clases
{
    class Vehicle
    {
        public bool activo = false;
        public string tipo { get => tipo; set => tipo = value; }
        public string placa { get => placa; set => placa = value; }
        public string marca { get => marca; set => marca = value; }
        public string identificacion_driver { get => identificacion_driver; set => identificacion_driver = value; }
        public string sexo_driver { get => sexo_driver; set => sexo_driver = value; }
        public bool afiliado_driver { get => afiliado_driver; set => afiliado_driver = value; }
    }
}
