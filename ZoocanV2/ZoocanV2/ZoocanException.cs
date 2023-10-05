using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoocanV2
{
    public class ZoocanException : ApplicationException
    {
        public ZoocanException() { }
        public ZoocanException(string message) : base(message) { }
        public ZoocanException(string message, Exception inner) : base(message, inner) { }
    }
}
