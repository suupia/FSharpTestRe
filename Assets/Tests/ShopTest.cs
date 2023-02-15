using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using FSharpTestRe;


public class ShopTest
{
    [Test]
    public void CalclationAddSholdAdd()
    {
       Assert.That(2,Is.EqualTo(Calculation.add(1,1)));
    }
}
