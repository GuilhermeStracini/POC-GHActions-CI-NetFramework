// ***********************************************************************
// Assembly         : GHActionsCI.UnitTests
// Author           : Guilherme Branco Stracini
// Created          : 23/03/2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 23/03/2023
// ***********************************************************************
// <copyright file="SampleClassTests.cs" company="GHActionsCI.UnitTests">
//     Copyright (c) Guilherme Branco Stracini ME. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace GHActionsCI.UnitTests
{
    using System;
    using NUnit.Framework;

    /// <summary>
    /// Class Tests.
    /// </summary>
    [TestFixture]
    public class Tests
    {
        /// <summary>
        /// Defines the test method Test1.
        /// </summary>
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        /// <summary>
        /// Defines the test method Test2.
        /// </summary>
        [Test]
        public void Test2()
        {
            var date = DateTime.Now;
            var instance = new SampleClass(date);

            Assert.That(instance, Is.Not.Null);
            Assert.That(instance.Date, Is.EqualTo(date));
        }
    }
}
