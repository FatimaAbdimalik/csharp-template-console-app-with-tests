using NUnit.Framework;
using FluentAssertions;
using System.Collections.Generic;
using System;
using TemplateConsoleApp;

namespace TemplateConsoleApp.Tests
{
    public class Tests
    {
        private Solution solution;

        [SetUp]
        public void Setup()
        {
            solution = new Solution();
        }

        [Test]
        // Replace this test with the first real test
        public void DummyTest()
        {
            Assert.AreEqual(true, true);
            Assert.AreNotEqual(true, false);
        }
       

        
       
    }
}
