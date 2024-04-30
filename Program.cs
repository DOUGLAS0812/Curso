
using System;

public class Program
{
    static void Main(string[] args)
    {
        // AulaClasses();
        //  AulaPropriedadeSomenteleitura();
        // AulaHeranca();
        // AulaClasseSelada();
        // AulaClasseAbstrata();
        AulaRecord();

    }

    private static void AulaRecord()
    {
         var curso1 = new Cadastro.Curso(1,"curso" );
        var curso2 = curso1 with { Descricao = "Teste Novo" };

        //var curso2 = new Cadastro.Curso { Id = 1, Descricao = "curso" };
       // var curso1 = new Cadastro.CursoTeste { Id = 1,  Descricao = "Curso" };
        // var curso2 = curso1;
        // curso2.Descricao = "TESTE TESTE";
       // var curso2 = new Cadastro.CursoTeste();
       // curso2.Id = curso1.Id;
       // curso2.Descricao = "Nova descricao";

        Console.WriteLine(curso2.Descricao);
        Console.WriteLine(curso2.Descricao);



        //Console.WriteLine(curso1 ==  curso2);
        Console.WriteLine(curso1 == curso2);
    }

    private static void AulaClasseAbstrata()
    {
        var cachorro = new Cadastro.Cachorro();
        cachorro.ImprimirDados();
    }

    private static void  AulaClasseSelada()
    {
        /*var configuracao = new Cadastro.Configuracao();
        configuracao.Host = "localhost";
        */

        var configuracao = new Cadastro.Configuracao
        {
            Host = "localhost"
        };

        Console.WriteLine(configuracao.Host);

    }

    private static void AulaHeranca()
    {
        var pessoaFisica = new Cadastro.PessoaFisica();
        pessoaFisica.Id = 1;
        pessoaFisica.Endereco = "Endereco teste";
        pessoaFisica.Cidade = "Cidade Teste";
        pessoaFisica.Cep = "123456";

        pessoaFisica.ImprimirDados();

    }

    private static void AulaClasses()
    {
        var resultado = Cadastro.Calculos.SomarNumeros(2, 3);
        Console.WriteLine(resultado);

        /* var produto = new Cadastro.Produto();
         produto.Descricao = "Teclado";

         produto.ImprimirDescricao();
         Console.WriteLine(produto.GetId());
        */
    }

    private static void AulaPropriedadeSomenteleitura()
    {
        var produto = new Cadastro.Produto();
        produto.Descricao = "Mouse";
        //produto.Estoque = 1;
        Console.WriteLine(produto.Estoque);
    }
}