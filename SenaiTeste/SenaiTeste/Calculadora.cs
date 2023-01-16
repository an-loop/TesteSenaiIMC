namespace CalculadoraSenai
{
    public class Calculadora
    {
        public static double CalcularIMC(double peso, double altura)
        {
            double resultado = peso / (altura * altura);

            if(resultado < 19)
            {
                return "abaixo do peso";
            }
            if(resultado < 25)
            {
                return "peso normal";
            }
            if (resultado < 30)
            {
                return "sobrepeso";
            }
            if(resultado < 40)
            {
                return "obesidade do tipo I";
            }
            else
            {
                return "obesidade mórbida";
            }
        }
    }




}