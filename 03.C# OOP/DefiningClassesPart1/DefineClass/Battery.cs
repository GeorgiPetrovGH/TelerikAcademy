using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{
    class Battery
    {
        public enum BatteryType
        {
            LiIon, NiMH, NiCd, Other
        }

        //Fields
        private string batteryModel;
        private int batteryHoursIdle;
        private int batteryHoursTalk;
        private BatteryType batteryType;

        
        //Constructors
        public Battery() 
        {
            batteryModel = "";
            batteryHoursIdle = 0;
            batteryHoursTalk = 0;
            batteryType = BatteryType.Other;
        }

        //I will define only one constructor with part of the information
        public Battery(string model) 
        {
            this.batteryModel = model;
            this.batteryHoursIdle = 0;
            this.batteryHoursTalk = 0;
            batteryType = BatteryType.Other;
        }
        public Battery(string model, int idle, int talk, BatteryType type) 
        {
            this.batteryModel = model;
            this.batteryHoursIdle = idle;
            this.batteryHoursTalk = talk;
            batteryType = type;
        }

        //Properties
        public string Model
        {
            get { return this.batteryModel; }
            set 
            {
                if (string.IsNullOrEmpty(value)) 
                {
                    throw new ArgumentException("Model can not be null.");
                }
                this.batteryModel = value;
            }
        }

        public int HoursIdle
        {
            get { return this.batteryHoursIdle; }
            set 
            {
                if (value < 0) 
                {
                    throw new ArgumentException("Battery Hours Idle are less than zero.");
                }
                this.batteryHoursIdle = value;
            }
        }

        public int HoursTalk
        {
            get { return this.batteryHoursTalk; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Battery Hours Talk are less than zero.");
                }
                this.batteryHoursTalk = value;
            }
        }

        public BatteryType Type
        {
            get { return this.batteryType; }
            set { this.batteryType = value; }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            
            result.AppendFormat("GSM Battery");
            result.AppendLine();
            result.AppendFormat("GSM Battery Model: {0}", this.Model);
            result.AppendLine();
            result.AppendFormat("GSM Battery HoursIdle: {0}", this.HoursIdle);
            result.AppendLine();
            result.AppendFormat("GSM Battery HoursTalk: {0}", this.HoursTalk);
            result.AppendLine();
            result.AppendFormat("GSM Battery HoursType: {0}", this.Type);            

            return result.ToString();
        }
    }
}
