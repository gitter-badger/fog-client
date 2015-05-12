﻿using FOG.Handlers.CommunicationHandler;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HandlersTest.Communication
{
    [TestClass]
    public class CommunicationTest
    {

        [TestMethod]
        public void Authenticate()
        {
            var success = CommunicationHandler.Authenticate();

            Assert.AreEqual(true, success);
        }

    }
}