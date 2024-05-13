﻿using System;
using System.Diagnostics;


namespace Modulo11;

    public class TrabalhandoComDatas
    {
        public void AulaDateTime()
        {
            var date1 = new DateTime(2012, 12, 02, 19, 22, 23);
            var date2 = DateTime.Parse("2022/12/22 19:25:23");
            var date3 = DateTime.Now;
            var date4 = DateTime.Today;

        Console.WriteLine(date1);
        Console.WriteLine(date2);
        Console.WriteLine(date3);
        Console.WriteLine(date4);

        Console.WriteLine(date1.ToString("dd-MM-yyyy HH:mm:ss"));
        var dateOffset1 = new DateTimeOffset(DateTime.Now, new TimeSpan(-3, 0, 0));
        Console.WriteLine(dateOffset1.UtcDateTime);

        }
        
    public void AulaSubtraindoDatas()
    {
        var date = DateTime.Now;
        var date2 = DateTime.Parse("2022-01-01");

        var diff = date - date2;
        Console.WriteLine(diff.TotalDays);
        Console.WriteLine(diff.TotalHours);
    } 
    
    public void AulaAdicionandoDiasMesAno()
    {
        var date1 = DateTime.Now;

        Console.WriteLine(date1.AddDays(3).ToString("dd-MM-yyyy HH:mm:ss"));
        Console.WriteLine(date1.AddMonths(1).ToString("dd-MM-yyyy HH:mm:ss"));
        Console.WriteLine(date1.AddYears(2).ToString("dd-MM-yyyy HH:mm:ss"));
        
    }


    

    }