using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace OresundBron
{
   public class OresundCar:Car
    {
        public OresundCar(String plate, DateTime date) : base(plate, date)
        {
            

        }
        public override double Price(bool brobizz)
        {
            if (brobizz == true)
            {
                return 161;
            }
            return 410;
        }
        public override string VehicleType()
        {
            return "OresundCar";
        }
    }
}
