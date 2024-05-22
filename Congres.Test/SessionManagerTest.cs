using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using congres.dll;
using congres.dll.Managers;

namespace Congres.Test
{
    [TestClass]
    public class SessionManagerTest
    {
        /// <summary>
        /// Test de la présence d'un congressiste participant à une session dans la fonction GetCongressistesNonParticipants
        /// Si le participant est présent dans la liste, le test échoue.
        /// </summary>
        [TestMethod]
        public void TestCongressisteNonParticipants()
        {
            Session uneSession = SessionManager.GetSessions()[1];
            List<Congressiste> congressistes = SessionManager.GetCongressistesNonParticipants(uneSession);
            bool found = false;
            foreach(Congressiste c in congressistes)
            {
                if(c.Id == 1)
                    found = true;
            }
            Assert.IsFalse(found);
            
        }
    }
}
