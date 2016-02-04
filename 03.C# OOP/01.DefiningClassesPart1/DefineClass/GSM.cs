using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Define a class that holds information about a mobile phone device: model, manufacturer, price, owner,
// battery characteristics (model, hours idle and hours talk) => holding instances of class Battery and
// display characteristics (size and number of colors) => holding instances of class Display

namespace MobileDevice
{
    class GSM
    {
        //Fields
        private string gsmModel;
        private string gsmManufacturer;
        private decimal gsmPrice;
        private string gsmOwner;        
        private static GSM iPhone4S;
        private Battery gsmBattery;
        private Display gsmDisplay;

        //Constructors

        static GSM()
        {
            iPhone4S = new GSM("Iphone 4S", "Apple", 2000.11M, "I.I.");
        }

        public GSM()
        {
            this.gsmModel = "";
            this.gsmManufacturer = "";
            this.gsmPrice = 0;
            this.gsmOwner = "";
            this.gsmBattery = new Battery();
            this.gsmDisplay = new Display();
        }

        public GSM(string model, string manufacturer)
        {
            this.gsmModel = model;
            this.gsmManufacturer = manufacturer;
            this.gsmPrice = 0;
            this.gsmOwner = "";
        }

        public GSM(string model, string manufacturer, decimal price, string owner)
        {
            this.gsmModel = model;
            this.gsmManufacturer = manufacturer;
            this.gsmPrice = price;
            this.gsmOwner = owner;
            this.gsmBattery = new Battery();
            this.gsmDisplay = new Display();
        }
        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
        {
            this.gsmModel = model;
            this.gsmManufacturer = manufacturer;
            this.gsmPrice = price;
            this.gsmOwner = owner;
            this.gsmBattery = battery;
            this.gsmDisplay = display;
        }

        //Properties

        private readonly List<Call> CallHistory = new List<Call>();
        public static GSM IPhone4S
        {
            get { return iPhone4S; }
        }

        public string Model
        {
            get { return this.gsmModel; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model can not be null.");
                }
                this.gsmModel = value; 
            }
        }

        public string Manufacturer
        {
            get { return this.gsmManufacturer; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Manufacturer can not be null.");
                }
                this.gsmManufacturer = value;
            }
        }

        public decimal Price
        {
            get { return this.gsmPrice; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price can not be less than zero.");
                }
                this.gsmPrice = value;
            }
        }

        public string Owner
        {
            get { return this.gsmOwner; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Owner can not be null.");
                }
                this.gsmOwner = value;
            }
        }

        

        //Methods

        public void PrintCalls()
        {
            foreach (var call in CallHistory)
            {
                Console.WriteLine("Call:");
                Console.WriteLine("Date and Time: " + call.DateAndTime);
                Console.WriteLine("Dialed phone number: " + call.DialledPhoneNumber);
                Console.WriteLine("Duration: {0} seconds ", call.Duration);
                Console.WriteLine();
            }
        }
        public double CalculatePriceCalls(double pricePerMinute)
        {
            int duration = 0;
            foreach (var call in CallHistory)
            {
                duration += call.Duration;
            }
            return duration * pricePerMinute;
        }

        public void AddCall(DateTime dateAndTime, string dialledPhoneNumber, int duration)
        {
            Call call = new Call(dateAndTime, dialledPhoneNumber, duration);
            CallHistory.Add(call);
        }

        public void DeleteCall(int position)
        {
            if ((this.CallHistory.Count <= position) || (position< 0))
            {
                throw new ArgumentException("Call does not exists.");
            }
            this.CallHistory.RemoveAt(position);
        }

        public void ClearCalls()
        {
            CallHistory.Clear();
        }
        public override string ToString()
        {
            var result = new StringBuilder();            
            result.AppendLine(new string('-', 20));
            result.AppendFormat("GSM Model: {0}", this.Model);
            result.AppendLine();
            result.AppendFormat("GSM Manufacturer: {0}", this.Manufacturer);
            result.AppendLine();
            result.AppendFormat("GSM Price: {0}", this.Price);
            result.AppendLine();
            result.AppendFormat("GSM Owner: {0}", this.Owner);
            result.AppendLine();
            result.AppendFormat(this.gsmBattery.ToString());
            result.AppendLine();
            result.AppendFormat(this.gsmDisplay.ToString());

            return result.ToString();
        }


    }
}
