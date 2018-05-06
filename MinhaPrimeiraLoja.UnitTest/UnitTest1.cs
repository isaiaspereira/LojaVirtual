using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MinhaPrimeiraLoja.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Take()
        {
            //exemplo usuando o operador Take em uma query
            int[] Numeros = { 5, 3, 6, 9, 8, 1, 4, 7 };
            var resultado = from num in Numeros.Take(5) select num;
            int[] Test = { 5, 3, 6, 9, 8 };
            CollectionAssert.AreEqual(resultado.ToArray(), Test);
        }

        [TestMethod]
        public void Skip()
        {
            //exemplo usuando o operador Take em uma query
            int[] Numeros = { 5, 3, 6, 9, 8, 1, 4, 7 };
            var resultado = from num in Numeros.Take(5).Skip(2) select num;
            int[] Test = { 6, 9, 8 };
            CollectionAssert.AreEqual(resultado.ToArray(), Test);
        }
    }
}
