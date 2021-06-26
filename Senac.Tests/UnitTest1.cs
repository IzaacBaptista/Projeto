using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Model{
    namespace Senac.Tests
    {
        [TestClass]
        public class UnitTest1
        {
            [TestMethod]
            [DataTestMethod]
            [DataRow("")]
            [DataRow(null)]
            [DataRow(" ")]
            /*public void Model_Customer(string value) {           
                Customer c = new Customer();
                var resultado = c.VerificaNome(value);
                Assert.IsFalse(resultado); 
            }*/

            public void Model_Customer_Nome(string value)
            {
                Customer c = new Customer(
                    value,
                    new System.DateTime(),
                    "123.456.789-01",
                    12
                );
                bool resultado = c.VerificaNome(value);
                Assert.IsFalse(resultado); 
            }
        }

        [TestClass]
        public class UnitTest2
        {
            [DataTestMethod]
            [DataRow("123.456.789-89")]
            [DataRow(" ")]

            public void Model_Customer_Cpf(string value)
            {
                Customer c = new Customer(
                    "Teste",
                    new System.DateTime(),
                    value,
                    11
                );
                bool resultado = c.VerificaCpf(value);
                Assert.IsFalse(resultado); 
            }
        }
    }
}

