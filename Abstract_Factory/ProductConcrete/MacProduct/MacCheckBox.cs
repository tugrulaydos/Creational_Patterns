using Abstract_Factory.ProductAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.ProductConcrete.MacProduct
{
    public class MacCheckBox : CheckBox
    {
        public string Paint()
        {
            return "Render a Checkbox in MacStyle";
        }
    }
}
