using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    internal class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message)
        {
        }
    }
}
