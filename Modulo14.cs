using System;


namespace Modulo14
{
   public class TrabalhandoComLinq 
    {
        public void AulaWhere()
        {
            //string nomeCompleto = "Douglas Andrade";

            //Func<char, bool> filtro = c => c == 'A';

            //// var resultado = nomeCompleto.Where(filtro);
            ////var resultado = nomeCompleto.Where(p => p == 'A');
            //var resultado = from c in nomeCompleto where c == 'D' select c;

            //foreach (var letra in resultado)
            //{
            //    Console.WriteLine(letra);
            //}

            var numeros = new int[] { 10, 20, 6, 30, 50, 9, };
            var resultado = numeros.Where(p => p >= 10);
            foreach (var numero in resultado) 
            {
                Console.WriteLine(numero);
            }
        }
    }
}
