using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{

    /// <summary>
    /// MC Class
    /// </summary>
    public class MC : BVehicle
    {
        //public string Licenseplate { get; set; }
        //public DateTime date { get; set; }


        /// <summary>
        /// price method with double return type
        /// </summary>
        /// <returns>125</returns>
        //public double Price()
        //{
        //    return 125;

        //}
        ///// <summary>
        ///// BVehicle method with string return type
        ///// </summary>
        ///// <returns>MC</returns>
        //public string Vehicle()
        //{
        //    return "MC";
        //}

        public MC(String plate, DateTime date) : base(plate, date)
        {


        }
        public override double Price(bool brobizz)
        {
            if (brobizz == true)
            {
                return 125 * 0.95;
            }
            return 125;
        }

        public override string VehicleType()
        {
            return "MC";
        }
        
        

        }
    }

