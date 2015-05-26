using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{
    class GsmTest
    {
        static void Main()
        {

            Battery[] batArray = new Battery[3];
            batArray[0] = new Battery("A", 1, 1, Battery.BatteryType.LiIon);
            batArray[1] = new Battery("B", 2, 2, Battery.BatteryType.NiCd);
            batArray[2] = new Battery("C", 3, 3, Battery.BatteryType.NiMH);
           
            Display[] disArray = new Display[3];
            disArray[0] = new Display(10, 10, 1000);
            disArray[1] = new Display(20, 20, 2000);
            disArray[2] = new Display(30, 30, 3000);

            GSM[] gsmArray = new GSM[3];
            gsmArray[0] = new GSM("Galaxy S5", "Samsung", 331.6M, "A.A.", batArray[0], disArray[0]);
            gsmArray[1] = new GSM("Desire 820", "HTC", 225.2M, "B.B.", batArray[1], disArray[1]);
            gsmArray[2] = new GSM("iPhone 6", "Apple", 869.5M, "C.C.", batArray[2], disArray[2]);
            Console.WriteLine("GSM Devices in the Array");
            foreach (var gsm in gsmArray)
            {
                Console.WriteLine(gsm.ToString());
            }
            Console.WriteLine();

            Console.WriteLine("iPhone4S");
            Console.WriteLine(GSM.IPhone4S.ToString());
            Console.WriteLine();

            GSM newGSM = gsmArray[0];
            newGSM.AddCall(DateTime.Now, "01", 25);
            newGSM.AddCall(DateTime.Now, "02", 60);
            newGSM.AddCall(DateTime.Now, "03", 35);
            Console.WriteLine("Price of calls: {0}", newGSM.CalculatePriceCalls(0.37));

            newGSM.PrintCalls();
            //pisha go prosto taka, za6toto ne mi se zanimava da vyrtq cikyl i da tyrsq nai dylgiq razgovor,
            //mislq, che ne e celta v zadachata :))
            newGSM.DeleteCall(1);
            Console.WriteLine("Price of calls: {0}", newGSM.CalculatePriceCalls(0.37));
            newGSM.ClearCalls();
            newGSM.PrintCalls();            
        }
    }
}
