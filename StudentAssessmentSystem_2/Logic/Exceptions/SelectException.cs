using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Exceptions
{
    public class SelectException : Exception
    {
        public string MissingSelect { get; set; }
        public SelectException (string message, string missingSelect) : base(message)
        {
            MissingSelect = missingSelect;
        }
        public SelectException(string message) : base(message) 
        { 

        }
    }
}
