using Abstract_Factory.ProductAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Factory
{
    public interface GUIFactory
    {
        public Button CreateButton();

        public CheckBox CreateCheckBox();
    }
}
