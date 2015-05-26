using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Group
    {
        public int GroupNumber { get; private set; }
        public string DepartmentName { get; private set; }
        public Group(int number, string name)
        {
            this.GroupNumber = number;
            this.DepartmentName = name;
        }
    }
}
