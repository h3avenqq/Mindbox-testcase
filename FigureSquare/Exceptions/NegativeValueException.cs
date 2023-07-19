using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FigureArea.Exceptions
{
    public class NegativeValueException : Exception
    {
        public NegativeValueException(): base() { }
        public NegativeValueException(string entity) : base($"Figure \"{entity}\" has negative values.") { }
    }
}
