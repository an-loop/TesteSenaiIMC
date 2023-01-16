
using CalculadoraSenai;

namespace MsTest
{
    [TestClass]
    public class TesteCalcMstest
    {
        [TestMethod]
        public void IMCcalculo()
        {
            //Arrange - preparação

            double peso = 50;
            double altura = 1.62;
            string resp = "abaixo do peso";

            //Act - Ação

            var resultado = Calculadora.CalcularIMC(peso, altura);


            //Assert - Verificação

            Assert.AreEqual(resp, resultado);


        }

        [DataTestMethod]
        [DataRow(40 , 1.49, "Abaixo do Peso")]
        [DataRow(50 , 1.45, "Peso Normal")]
        [DataRow(69 , 1.64, "Sobrepeso")]
        [DataRow(89 , 1.72, "Obesidade de tipo I")]
        [DataRow(99 , 1.68, "Obesidade Mórbida")]


        public void IMCLista(double peso, double altura, string resp)
        {
            //AA
            //Act
            var resultado = Calculadora.CalcularIMC(peso, altura);

            //Assert
            Assert.AreEqual(peso, resultado);
        }
    }
}