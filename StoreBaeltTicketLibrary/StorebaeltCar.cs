using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace StoreBaeltTicketLibrary
{
  public  class StorebaeltCar:Car
    {
        public StorebaeltCar(String plate, DateTime date) : base(plate, date)
        {


        }
        public override double Price(bool brobizz)
        {
            int weekday = (int)Date.DayOfWeek;
            double price = 240;

            if (weekday == 0 || weekday == 6)
            {
                price = price * 0.8; 
            }
            if (brobizz == true)
            {
               return price * 0.95;
            }

            //if (brobizz == true)
            //{
            //    return 240 * 0.95;
            //}
            return price;
        }



    }
}
