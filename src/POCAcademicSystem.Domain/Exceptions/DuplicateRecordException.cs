using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCAcademicSystem.Domain.Exceptions
{
    public class DuplicateRecordException : EntityValidationException
    {
        public DuplicateRecordException(string message)
            : base(message)
        {

        }
    }
}
