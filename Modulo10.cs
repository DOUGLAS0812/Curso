using System;


namespace Modulo10;

public class TrabalhandoComStrings
{
    public void ConverterParaLetrasminusculas()
    {
        Console.Write("Por favor Digitar alguma informacao: ");
        var linha = Console.ReadLine();
        Console.WriteLine(linha.ToLower());
    }

    public void ConverterParaLetrasMaiuscula()
    {
        Console.Write("Por favor Digitar alguma informacao: ");
        var linha = Console.ReadLine();
        Console.WriteLine(linha.ToUpper());
    }

    public void AulaSubstring()
    {
        Console.Write("Por favor Digitar alguma informacao: ");
        var linha = Console.ReadLine();
        Console.WriteLine(linha.Substring(6, 5));
    }
    public void AulaRange()
    {
        string nomeArquivo = "2022_12_01_backup.bak";
        var ano = nomeArquivo[..4];
        Console.WriteLine(ano);
        var extensao = nomeArquivo[^3..];
        Console.WriteLine(extensao);
        var nome = nomeArquivo[11..^4];
        Console.WriteLine(nomeArquivo); 
        var apenasNome = nomeArquivo[11..^4];
        Console.WriteLine(apenasNome);
    }
    
    public void AulaContains()
    {
        string nomeArquivo = "2022_12_01_backup.bak";
        if(nomeArquivo.Contains("backup"))
        {
            Console.WriteLine("palavra encontrada");

        }
        else
        {
            Console.WriteLine("Palavra nao encontrada ");
        }
        
    }
      
    public void AulaTrim()
    {
        string teste = "**Douglas Andrade**";

        Console.WriteLine("Trim:"  + teste.Trim('*'));
        Console.WriteLine("Inicio:" + teste.TrimStart('*'));
        Console.WriteLine("Inicio:" + teste.TrimEnd('*'));

    }

    public void AulaStartWithEndWith()
    {
        string teste = "Douglas Andrade";


        Console.WriteLine("Inicio:" + teste.StartsWith("Douglas"));
        Console.WriteLine("Final:" + teste.EndsWith("Andrade01"));

    } 
    
    public void AulaReplace()
    {
        string teste = "Douglas Andrade";


        Console.WriteLine(teste);
        Console.WriteLine(teste.Replace("Douglas", "Antonio")); 


    }
    public void Aulalength()
    {
        string teste = Console.ReadLine();
        Console.WriteLine(teste);
        Console.WriteLine(teste.Length); 


    }




}
