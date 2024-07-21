// ***********************************************************************
// Assembly         : GHActionsCI
// Author           : Guilherme Branco Stracini
// Created          : 19/01/2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 23/03/2023
// ***********************************************************************
// <copyright file="Program.cs" company="Guilherme Branco Stracini ME">
//     Copyright © 2020
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace GHActionsCI
{
    using System.Diagnostics.CodeAnalysis;
    using CrispyWaffle.Composition;
    using CrispyWaffle.Log;
    using CrispyWaffle.Log.Adapters;
    using CrispyWaffle.Log.Handlers;
    using CrispyWaffle.Log.Providers;

    /// <summary>
    /// Class Program.
    /// </summary>
    [ExcludeFromCodeCoverage]
    internal class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        protected static void Main(string[] args)
        {
            ServiceLocator.Register<IConsoleLogAdapter, StandardConsoleLogAdapter>(
                Lifetime.Singleton
            );
            ServiceLocator.Register<IExceptionHandler, NullExceptionHandler>(Lifetime.Singleton);

            LogConsumer.AddProvider<ConsoleLogProvider>();

            LogConsumer.Warning("Hello World");

            LogConsumer.Info("Hello World");

            foreach (var arg in args)
            {
                LogConsumer.Info("Arg: {0}", arg);
            }
        }
    }
}
