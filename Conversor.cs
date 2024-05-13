using System;

    namespace Conversores;

public class Conversor
{
    public void ConvertAndParse()
    {
        //int numero = int.Parse("1");
        int numero = Convert.ToInt32(null);
        bool verdadeiro = bool.Parse("true");
        Console.WriteLine(verdadeiro);

       // Console.WriteLine(numero);
    }

    public void AulaTryParse()
    {
        var numero = "123456";

        int numeroConvertido;

        if (int.TryParse(numero, out  numeroConvertido))
        {
            Console.WriteLine(" Numero foi  Convertido");
        }
        
        Console.WriteLine(numeroConvertido);
        
    }
}
