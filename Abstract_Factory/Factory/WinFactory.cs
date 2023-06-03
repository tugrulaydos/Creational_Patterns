using Abstract_Factory.ProductAbstract;
using Abstract_Factory.ProductConcrete.WinProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Factory
{
    public class WinFactory : GUIFactory
    {
        public Button CreateButton()
        {
            return new WinButton();
        }

        public CheckBox CreateCheckBox()
        {
            return new WinCheckBox();
        }
    }
}
