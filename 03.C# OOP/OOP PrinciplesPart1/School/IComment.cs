using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public interface IComment
    {
        string Comment { get; }
        void MakeComment(string text);
    }
}
