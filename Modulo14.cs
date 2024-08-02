using System;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;


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

        public void AulaOrdenacao()
        {
            var numeros = new int[] { 10, 20, 6, 30, 50, 9, };

            var nomes = new string[] { "Douglas" , "Estevan" ,"Matheus"};
            // var resultado = numeros.OrderByDescending(p => p );
            var resultado = nomes.OrderByDescending(p => p);
            foreach (var numero in resultado)
            {
                Console.WriteLine(numero);
            }

        }
        public void AulaTake()
        {
            var numeros = new int[] { 10, 20, 6, 30, 50, 9, };
            var resultado = numeros.Where(p => p > 10).Take(5).OrderBy(p => p);
            foreach (var numero in resultado)
            {
                Console.WriteLine(numero);
            }

        }
        public void AulaCount()
        {
            var numeros = new int[] { 10, 20, 6, 30, 50, 9, };

            var resultados =  numeros.Count(p => p > 10);

            Console.WriteLine(resultados);
        }
        
        public void AulaFirstEFirstOrDefault()
        {
            var numeros = new int[] { 10, 20, 6, 30, 50, 9, };

            //  var resultados =  numeros.First();
            //var resultado = numeros.First(p => p > 100);
            var resultado = numeros.FirstOrDefault(p => p > 100 , -99);

            Console.WriteLine(resultado);
        }

   }
}
