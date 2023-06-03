
using Abstract_Factory.ProductAbstract;
using Abstract_Factory.ProductConcrete.MacProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Factory
{
    public class MacFactory : GUIFactory
    {
        public Button CreateButton()
        {
            return new MacButton();
        }

        public CheckBox CreateCheckBox()
        {
            return new MacCheckBox();
        }
    }
}
