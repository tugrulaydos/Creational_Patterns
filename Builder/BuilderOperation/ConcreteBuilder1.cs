using Builder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.BuilderOperation
{
    public class ConcreteBuilder1 : IBuilder
    {
        private Product1 _product;

        public ConcreteBuilder1()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._product = new Product1();
        }
        public void BuildPartA()
        {
            this._product.Add("PartA1");
        }

        public void buildPartB()
        {
            this._product.Add("PartB1");
        }

        public void buildPartC()
        {
            this._product.Add("PartC1");
        }

        public Product1 GetProduct()
        {
            Product1 result = this._product;

            this.Reset();

            return result;
        }
    }
}
