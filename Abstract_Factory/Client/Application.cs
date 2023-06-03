using Abstract_Factory.Factory;
using Abstract_Factory.ProductAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Client
{
    public class Application
    {
        private GUIFactory _factory;

        private Button _buton;

        public Application(GUIFactory factory)
        {
            _factory = factory;
        }

        public Button CreateUI()
        {
            _buton = _factory.CreateButton();
            return _buton;
        }

        public string paint()
        {
            return _buton.Paint();
        }

    }
}
