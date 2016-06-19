﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCAcademicSystem.Domain.Exceptions
{
    public class EntityValidationException : Exception
    {
        public EntityValidationException(string message)
            : base(message)
        {

        }
    }
}
