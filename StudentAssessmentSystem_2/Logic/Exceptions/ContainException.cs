using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Exceptions
{
    public class ContainException : Exception
    {
        public string MissingObject { get; set; }
        public ContainException(string missingObject) 
        { 
            MissingObject = missingObject;
        }
    }
}
