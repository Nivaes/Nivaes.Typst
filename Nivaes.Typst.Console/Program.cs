namespace Nivaes.Typst.Console
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int i = RustInterop.AddNumbers(2, 3);

            Console.WriteLine($"Hello, World! {i}");
        }
    }
}
