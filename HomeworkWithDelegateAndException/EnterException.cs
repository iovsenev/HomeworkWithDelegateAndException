using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkWithDelegateAndException
{
    internal class EnterException : Exception
    {
        public EnterException(string msg) : base(msg) { }
    } 
}
