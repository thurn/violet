using NUnit.Framework;
using System;
using PropJet;

namespace PropJet {

[TestFixture()]
public class Test {
  [Test()]
  public void TestCase() {
    MyClass myClass = new MyClass();
    Assert.AreEqual(4, myClass.sum());
  }
}

}