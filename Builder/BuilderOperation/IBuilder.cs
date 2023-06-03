using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.BuilderOperation
{
    public interface IBuilder
    {   
        public void BuildPartA();

        public void buildPartB();

        public void buildPartC();

    }
}
