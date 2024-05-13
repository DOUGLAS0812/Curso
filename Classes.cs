using System;


namespace Cadastro
{

    public static class Calculos
    {
        public static int SomarNumeros(int a , int b)
        {
            return a+b;
        }
    }
    public class Produto
    {
        private int Id; 

        public string Descricao { get; set;}

        //  public readonly int Estoque; -- pode ser usado para somente leitura 
        public  int Estoque { get; set;}
        public Produto()
        {
            Estoque = 1;
        }
        public void ImprimirDescricao()
        {
            Console.WriteLine(GetId() + " - " + Descricao);

        }

        public void SetId(int id)
        { 
            this.Id = id; 
        }
        public int  GetId()
        {
            return Id; 
        }

    }

    public class Pessoa
    {
        public int Id { get; set; }
        public string Endereco { get; set; }

        public string Cidade { get; set; }

        public string Cep { get; set; }

        public void ImprimirDados()
        {

            Console.WriteLine("Codigo: " + Id);
            Console.WriteLine("Endereco: " + Endereco);
            Console.WriteLine("Cidade: " + Cidade);
            Console.WriteLine("Cep: " + Cep);
        }

       
    }

    public class Funcionario : PessoaFisica
    {
        public string Matricula { get; set; }
    }

    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }

    }

    public sealed class Configuracao
    {
        public string  Host { get; set; }
    }

    public abstract class Animal
    {
        public string Nome { get; set; }

        public abstract string GetInformacoes();

        public void ImprimirDados()
        {
            Console.WriteLine("Nome animal: " + Nome);
            Console.WriteLine("Informacoes : " + GetInformacoes());
        }

     
    }
    public class Cachorro : Animal
    {
        public override string GetInformacoes()
        {
            return "Cachorro é um bom amigo";
        }
    }
    public record Curso(int Id, string Descricao);

    public class CursoTeste
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
    }

    /*
    public record Curso
    {
        public int Id { get; set; }
        public string  Descricao { get; set; }

       /* public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            if ( obj is Curso curso)
            {
                return Id == curso.Id && Descricao == curso.Descricao; 
            }
            return base.Equals(obj);
        }

        public static bool operator == (Curso a, Curso b)
        {
            return a.Equals(b);
        }

        public static bool operator != (Curso a, Curso b)
        {
            return !(a == b);
        }
       
    }
    
    */
    
}
