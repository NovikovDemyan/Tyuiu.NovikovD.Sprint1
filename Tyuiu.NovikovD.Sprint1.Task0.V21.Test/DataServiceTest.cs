﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NovikovD.Sprint1.Task0.V21.Lib;

namespace Tyuiu.NovikovD.Sprint1.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(17, res);
        }
    }
}
