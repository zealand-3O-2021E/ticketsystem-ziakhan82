using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// car Class
    /// </summary>
   public class Car
    {
        /// <summary>
        /// Licenseplate and datetime properties
        /// </summary>
        public string Licenseplate { get; set; }
        public DateTime Date { get; set; }

        /// <summary>
        /// price method with double return type
        /// </summary>
        /// <returns> 240</returns>
        public double Price()
        {
            return 240;
        }
        /// <summary>
        /// Vehicle type method 
        /// </summary>
        /// <returns> car </returns>
        public string VehicleType()
        {
            return "Car";
        }

    }
}
