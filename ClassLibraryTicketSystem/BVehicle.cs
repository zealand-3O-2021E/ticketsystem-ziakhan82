using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// public abstract class
    /// </summary>
 public abstract  class  BVehicle
    {
        public string Licenseplate { get; set; }
        public DateTime Date { get; set; }


        /// <summary>
        /// base class constracter we check the condtion
        /// if the plate charcter is more then 7 throw new exception
        /// </summary>
        /// <param name="plate"> paramter of type String</param>
        /// <param name="date"> datetime paramter</param>

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

        /// <summary>
        /// abstarct method of type double 
        /// </summary>
        /// <param name="brobizz"> paramter of type bool  </param>
        /// <returns></returns>
        public abstract double Price(bool brobizz);

        /// <summary>
        /// abstract method of type String
        /// </summary>
        /// <returns></returns>
        public abstract string VehicleType();

        

        




    }
}
