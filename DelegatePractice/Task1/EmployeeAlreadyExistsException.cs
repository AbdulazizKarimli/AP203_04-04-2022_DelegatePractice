﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    internal class EmployeeAlreadyExistsException : Exception
    {
        public EmployeeAlreadyExistsException(string message) : base(message)
        {
        }
    }
}
