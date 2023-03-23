// ***********************************************************************
// Assembly         : GHActionsCI
// Author           : Guilherme Branco Stracini
// Created          : 23/03/2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 23/03/2023
// ***********************************************************************
// <copyright file="SampleClass.cs" company="Guilherme Branco Stracini ME">
//     Copyright ©  2020
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace GHActionsCI
{
    using System;

    /// <summary>
    /// Class SampleClass.
    /// </summary>
    public class SampleClass
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleClass" /> class.
        /// </summary>
        /// <param name="date">The date.</param>
        public SampleClass(DateTime date) => Date = date;

        /// <summary>
        /// Gets the date.
        /// </summary>
        /// <value>The date.</value>
        public DateTime Date { get; }
        /// <summary>
        /// Gets or sets the test.
        /// </summary>
        /// <value>The test.</value>
        public string Test { get; set; }
    }
}
