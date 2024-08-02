
using Modulo10;
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
        //AulaRecord();
        // Conversores();
        // TrabalhandoComStrings();
        // TrabalhandoComDatas();
        //TrabalhandoComExcesoes();
        //TrabalhandoComArquivos();
       TrabalhandoComlinq();
    }

    private static void TrabalhandoComlinq()
    {
        var linq = new Modulo14.TrabalhandoComLinq();
        // linq.AulaWhere();
        //linq.AulaOrdenacao();
        //linq.AulaTake();
        //linq.AulaCount();
        linq.AulaFirstEFirstOrDefault();
    } 
    
    private static void TrabalhandoComArquivos()
    {
        
    }
    private static void TrabalhandoComLinq()
    {
        var trabalhandoComArquivos = new Modulo13.TrabalhandoComArquivos();
        //trabalhandoComArquivos.AulaCriandoArquivos();
        //trabalhandoComArquivos.AulalendoArquivo();
        trabalhandoComArquivos.AulaExcluindoArquivo();

    }

    private static void TrabalhandoComExcesoes()
    {
        var trabalhandoComExececoes = new Modulo12.TrabalhandoComExecoes();
        //trabalhandoComExececoes.AulaGerandoException();
        trabalhandoComExececoes.AulatratandoException();
    }

    private static void TrabalhandoComDatas()
    {
        var trabalhandoComDatas = new Modulo11.TrabalhandoComDatas();
        //trabalhandoComDatas.AulaDateTime();
        // trabalhandoComDatas.AulaSubtraindoDatas();
        //trabalhandoComDatas.AulaAdicionandoDiasMesAno();
        // trabalhandoComDatas.AulaAdicionandoHoraMinutoSegundo();
        //  trabalhandoComDatas.AulaDiaDaSemana();
        //trabalhandoComDatas.AulaDateOnly();
        trabalhandoComDatas.AulaTimeOnly();
    }

    private static void TrabalhandoComStrings()
    {
        var trabalhandoComStrings = new Modulo10.TrabalhandoComStrings();
        //trabalhandoComStrings.ConverterParaLetrasminusculas();
        //trabalhandoComStrings.ConverterParaLetrasMaiuscula();.
        // trabalhandoComStrings.AulaSubstring();
        //trabalhandoComStrings.AulaRange();
        // trabalhandoComStrings.AulaContains();
        //trabalhandoComStrings.AulaTrim();
        // trabalhandoComStrings.AulaStartWithEndWith();
        //trabalhandoComStrings.AulaReplace();
        trabalhandoComStrings.Aulalength();
    }

    private static void Conversores()
    {
        var conversores = new Conversores.Conversor();
        // conversores.ConvertAndParse();
        conversores.AulaTryParse();
    }

    private static void AulaRecord()
    {
        var curso1 = new Cadastro.Curso(1, "curso");
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

    private static void AulaClasseSelada()
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