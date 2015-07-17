using System;
using System.Collections.Generic;
using System.Linq;
namespace RefactorIfStatements
{
    using System.Text;
    public class Potato
    {
        public Potato()
        {
            
        }
        public bool IsCooked { get; internal set; }

        public bool IsPeeled { get; internal set; }

        public bool IsRotten { get; internal set; }
    }
}
