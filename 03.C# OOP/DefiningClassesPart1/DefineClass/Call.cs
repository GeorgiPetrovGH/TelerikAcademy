using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{
    class Call
    {
        private DateTime dateAndTime;
        private string dialledPhoneNumber;
        private int duration;

        public Call(DateTime time, string phoneNumber, int duration) 
        {
            this.dateAndTime = time;
            this.dialledPhoneNumber = phoneNumber;
            this.duration = duration;
        }

        public DateTime DateAndTime 
        {
            get { return this.dateAndTime; }
            set { this.dateAndTime = value; }
        }

        public string DialledPhoneNumber 
        {
            get { return this.dialledPhoneNumber; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Dialled number can not be null.");
                }
                this.dialledPhoneNumber = value;
            }
        }

        public int Duration
        {
            get { return this.duration; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Duration can not be less than zero.");
                }
                this.duration = value;
            }
        }
              
    }
}
