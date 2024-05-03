using congres.dll;
using congres.dll.Managers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Congres.Test
{
    /// <summary>
    /// Description résumée pour UnitTest1
    /// </summary>
    [TestClass]
    public class CongressisteManagerTest
    {
        [TestMethod]
        public void TestGetCongressiste()
        {
            List<Congressiste> lesCongressistes = CongressisteManager.GetCongressistes();
            Assert.IsNotNull(lesCongressistes);
        }
    }
}
