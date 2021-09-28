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
    public class Car : BVehicle
    {
        /// <summary>
        /// Licenseplate and datetime properties
        /// </summary>
        /// 
        //public string Licenseplate { get; set; }
        //public DateTime Date { get; set; }

        /// <summary>
        /// price method with double return type
        /// </summary>
        /// <returns> 240</returns>
        //public  double Price()
        //{
        //    return 240;
        //}
        /// <summary>
        /// BVehicle type method 
        /// </summary>
        /// <returns> car </returns>
        //public string VehicleType()
        //{
        //    return "Car";
        //}

        
        public Car(String plate, DateTime date) : base(plate, date)
        {

        }
        /// <summary>
        /// overridden price  method of type double from abstract class 
        /// </summary>
        /// <param name="brobizz">parameter of type bool </param>
        /// <returns>if the condition is ==ture it will return 
        /// the price with discount else the fixed price will be returned.</returns>
        public override double Price(bool brobizz)
        {
            if (brobizz == true)
            {
                return 240*0.95;
            }
            return 240;
        }


        /// <summary>
        /// overridden vehicleType method from abstract class
        /// </summary>
        /// <returns> returns String  "Car"</returns>
        public override string VehicleType()
        {
            return "Car";
        }
       
    }
    } 
