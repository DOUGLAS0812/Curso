using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;


namespace Modulo12;


public class TrabalhandoComExecoes()
{
    public void AulaGerandoException()
    {

        while (true)
        {

            Console.Write("Informe um numero: ");
            var numero = Console.ReadLine();
            var resultado = 500 / int.Parse(numero);
            Console.WriteLine("resultado" + resultado);
        }
    }

    public void AulatratandoException()
    {

        while (true)
        {
            try
            {
                Console.Write("Informe um numero: ");
                var numero = Console.ReadLine();
                var resultado = 500 / int.Parse(numero);
                Console.WriteLine("resultado" + resultado);

            }
            catch(DivideByZeroException execepion) 
            {
                Console.WriteLine("Ocorreu um erro de divisao: " + execepion.Message);
                Console.WriteLine("Ocorreu um erro: " + execepion.StackTrace);
            }
            catch(Exception execepion)
            {
                Console.WriteLine("Ocorreu um erro: " + execepion.Message);
                Console.WriteLine("Ocorreu um erro: " + execepion.StackTrace);
            }

        }
    }

}
