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
        /// <summary>
        /// Test de connexion à la base de donnée, en récupérant des ligues.
        /// </summary>
        [TestMethod]
        public void TestConnexionBDD()
        {
            List<Ligue> ligues = LigueManager.GetLigues();
            Assert.IsFalse(ligues.Count == 0);
        }
    }
}
