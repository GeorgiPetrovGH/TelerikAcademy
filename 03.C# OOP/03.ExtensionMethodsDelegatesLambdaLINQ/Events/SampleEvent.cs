using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class SampleEvent : EventArgs
    {
        private string sampleMessage;
        public SampleEvent(string text)
        {
            this.SampleMessage = text;
        }
        public string SampleMessage
        {
            get { return this.sampleMessage; }
            set { this.sampleMessage = value; }
        }
    }
}
