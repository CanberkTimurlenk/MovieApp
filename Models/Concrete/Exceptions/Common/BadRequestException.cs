﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete.Exceptions.Common
{
    public abstract class BadRequestException : Exception
    {
        protected BadRequestException(string message) :
           base(message)
        {

        }
    }
}
