using CrispyWaffle.Composition;
using CrispyWaffle.Log;
using CrispyWaffle.Log.Adapters;
using CrispyWaffle.Log.Handlers;
using CrispyWaffle.Log.Providers;
using System;

namespace GHActionsCI
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceLocator.Register<IConsoleLogAdapter, StandardConsoleLogAdapter>(LifeStyle.SINGLETON);
            ServiceLocator.Register<IExceptionHandler, NullExceptionHandler>(LifeStyle.SINGLETON);

            LogConsumer.AddProvider<ConsoleLogProvider>();

            LogConsumer.Warning("Hello World");

            LogConsumer.Info("Hello World");

            foreach (var arg in args)
            {
                LogConsumer.Info("Arg: {0}", arg);

            }

            Console.ReadKey();
        }
    }
}
