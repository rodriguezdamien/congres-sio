using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using congres.dll;
using congres.dll.Managers;

namespace Congres.Test
{
    [TestClass]
    public class ManagerTest
    {
        [TestMethod]
        public void TestGetLigues()
        {
            List<Ligue> ligues = LigueManager.GetLigues();
            Assert.IsFalse(ligues.Count == 0);
        }
    }
}
