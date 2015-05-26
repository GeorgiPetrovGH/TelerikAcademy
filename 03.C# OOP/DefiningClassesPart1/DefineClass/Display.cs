using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{
    class Display
    {
        //Fields
        private int displayHeight;
        private int displayWidth;
        private long displayColors;

        //Constructors
        public Display()
        {
            this.displayHeight = 0;
            this.displayWidth = 0;
            this.displayColors = 0;
        }
        public Display(int height, int width, long number)
        {
            this.displayHeight = height;
            this.displayWidth = width;
            this.displayColors = number;
        }

        //Properties
        public int Height
        {
            get { return this.displayHeight; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height can not be less than zero.");
                }
                this.displayHeight = value;
            }
        }

        public int Width
        {
            get { return this.displayWidth; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width can not be less than zero.");
                }
                this.displayWidth = value;
            }
        }

        public long Colors
        {
            get { return this.displayColors; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Colors can not be less than zero.");
                }
                this.displayColors = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendFormat("GSM Display");
            result.AppendLine();
            result.AppendFormat("GSM Display Height: {0}", this.Height);
            result.AppendLine();
            result.AppendFormat("GSM Display WIdth: {0}", this.Width);
            result.AppendLine();
            result.AppendFormat("GSM BDisplay Colors: {0}", this.Colors);            
            
            return result.ToString();
        }
    }
}
