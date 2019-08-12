using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomatedTestingLibraryProject;
using System;

namespace AutomatedTestingMSTestProject {
    [TestClass]
    public class TestFunctions {  //All methods must be public, must return void and take no parameters. Only those annotated with TEST will run
    
            Functions functions = null;


            [TestInitialize]
            public void Setup() {
                functions = new Functions(); //creates a new instance of our functions class and stores it in a variable called functions
            }

            [TestMethod]
            public void Test1() { //Assert is a class of methods
                var answer = functions.Add1(0); //Adds actual answer
                Assert.AreEqual(1, answer); //(expected answer, actual answer) 
                answer = functions.Add1(-1);
                Assert.AreEqual(0, answer);
            }
            //[Test]
            //public void Test2() {
            //    var answer = functions.Add1(3);
            //    Assert.AreEqual(3, answer);

            // }
            [TestMethod]
            public void TestXSquaredPlus3() {
                var ans = functions.XSquaredPlus3(0); //test input 0
                Assert.AreEqual(3, ans);
                ans = functions.XSquaredPlus3(3); //test input 3
                Assert.AreEqual(12, ans);
                ans = functions.XSquaredPlus3(4);
                Assert.AreEqual(19, ans);
                ans = functions.XSquaredPlus3(5);
                Assert.AreEqual(28, ans);
            }
            [TestMethod]
            [ExpectedException(typeof(Exception))] //Allows a specific exception to be thrown and the test wil still pass
            public void X7X12() { // (i * i) - (7 * i) + 12;

                var answer = functions.X7X12(0); //input 0
                Assert.AreEqual(12, answer);
                answer = functions.X7X12(7); //input 7(domain)
                Assert.AreEqual(12, answer);
                answer = functions.X7X12(12); //input 12(domain)
                Assert.AreEqual(72, answer);
                answer = functions.X7X12(1); //input 1
                Assert.AreEqual(6, answer);
                answer = functions.X7X12(-1); //input -1
                Assert.AreEqual(20, answer);


            }
            [TestMethod]
        public void TestMethod1() {
        }
    }
}
