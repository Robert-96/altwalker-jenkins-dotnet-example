using Altom.AltWalker;

using System;

namespace Example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Start the executor service
            ExecutorService service = new ExecutorService();

            // Register the setup class and the classes for all models
            service.RegisterModel<ExampleModel>();

            // Start the executor service
            service.Run(args);
        }
    }
}
