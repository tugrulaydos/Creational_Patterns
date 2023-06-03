namespace Singleton_Pattern
{
    internal class Program
    {
        public static void TestSingleton(string value)
        {
            Singleton singleton = Singleton.GetInstance(value);
            Console.WriteLine(singleton.Value);
        }

        static void Main(string[] args)
        {
            Thread process1 = new Thread(() =>
            {
                TestSingleton("FOO");
            });

            Thread process2 = new Thread(() =>
            {
                TestSingleton("BAR");
            });

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();



        }
    }
}