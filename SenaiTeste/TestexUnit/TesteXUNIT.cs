using CalculadoraSenai;

namespace TestexUnit
{
    public class TesteXUNIT
    {
        [Fact]
        public void CalculaIMC()
        {
            //Arrange - Preparação

            double peso = 50;
            double altura = 1.62;
            string resp = 3;


            //Act - Ação
            var resultado = Calculadora.CalcularIMC(peso, altura);

            //Assert - Verificação
            Assert.Equal(peso, resultado);
        }


        [Theory]
        [InlineData(40 , 1.49, "Abaixo do Peso")]
        [InlineData(50 , 1.45, "Peso Normal")]
        [InlineData(69 , 1.64, "Sobrepeso")]
        [InlineData(89 , 1.72, "Obesidade de tipo I")]
        [InlineData(99 , 1.68, "Obesidade Mórbida")]

        public void CalculaIMCLista(double peso, double altura, string resp)
        {
            //Act 
            var resultado = Calculadora.CalcularIMC(peso, altura);

            //Assert
            Assert.Equal(peso, resultado);
        }


    }
}