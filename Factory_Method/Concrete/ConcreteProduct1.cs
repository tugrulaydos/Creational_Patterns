using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.Concrete
{
    public class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "ConcreteProduct1";
        }
    }
}
