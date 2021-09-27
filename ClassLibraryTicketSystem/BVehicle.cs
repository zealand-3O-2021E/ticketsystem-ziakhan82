using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
 public abstract  class  BVehicle
    {
        public string Licenseplate { get; set; }
        public DateTime Date { get; set; }

        public BVehicle( String plate, DateTime date)
        {
            if (plate.Length <= 7)
            {

                Licenseplate = plate;
            }
            else
            {
                throw new ArgumentException("The license plate can't be more then 7 character");
            }
            Date = date;

        }


        public abstract double Price(bool brobizz);

        public abstract string VehicleType();

        

        




    }
}
