using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using NUnit.Framework;

namespace CoolPackage.Tests
{
    [TestFixture]
    public class CoolTests : MonoBehaviour
    {
        public void WHOA()
        {
            Assert.IsTrue(true);
        }

        public void WHOA2()
        {
            Assert.IsFalse(false);
        }
    } 
}
