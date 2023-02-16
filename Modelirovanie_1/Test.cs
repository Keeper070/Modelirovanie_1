using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Modelirovanie_1
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void OperationPlusMinus()
        {
            var main = new MainForm();
            var result = main.TranslateToPostfix("2+3-5+213");
            Assert.AreEqual("AB+C-D+", result.ToString());
        }
        
        [TestMethod]
        public void OperationMultiplication()
        {
            var main = new MainForm();
            var result = main.TranslateToPostfix("2+(3-10)*212");
            Assert.AreEqual("ABC-D*+", result.ToString());
        }
        
        [TestMethod]
        public void OperationSinCosArcSinArcCos()
        {
            var main = new MainForm();
            var result = main.TranslateToPostfix("sin(cos(2+45/431))-90+11*(2*3-7)");
            Assert.AreEqual("ABC/+баD-EFG*H-*+", result.ToString());
        }
        
        [TestMethod]
        public void OperationDegree1()
        {
            var main = new MainForm();
            var result = main.TranslateToPostfix("2+4^5+1");
            Assert.AreEqual("ABCдD++", result.ToString());
        }
        
        [TestMethod]
        public void OperationDegree2()
        {
            var main = new MainForm();
            var result = main.TranslateToPostfix("2+4^5*1");
            Assert.AreEqual("ABCD*д+", result.ToString());
        }
        
        [TestMethod]
        public void OperationHard()
        {
            var main = new MainForm();
            var result = main.TranslateToPostfix("sin(cos(2+45/431))-90+11*(2*3-7)^45");
            Assert.AreEqual("ABC/+баD-EFG*H-Iд*+", result.ToString());
        }
    }
}