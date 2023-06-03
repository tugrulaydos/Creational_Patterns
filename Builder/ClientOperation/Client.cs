using Builder.BuilderOperation;
using Builder.DirectorOperation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Builder.ClientOperation
{
    public class Client
    {
       public void Main()
       {
            var director = new Director(); 
            var builder = new ConcreteBuilder1();

            director.Builder = builder;
            

            Console.WriteLine("Basic Product");
            director.BuildMinimalViableProduct();
            Console.WriteLine(builder.GetProduct().ListParts());
            Console.WriteLine();

            Console.WriteLine("Medium Product");
            director.BuildMiddleFeaturedProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine();

            Console.WriteLine("Full Product");
            director.BuildFullFeaturedProduct();
            Console.WriteLine(builder.GetProduct().ListParts());





        }

    }
}
