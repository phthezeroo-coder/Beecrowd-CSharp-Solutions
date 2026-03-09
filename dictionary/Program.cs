using System; 
using System.Collections.Generic;

class URI {

    static void Main(string[] args) { 

        int ddd = int.Parse(Console.ReadLine());
         
        Dictionary<int , string> tabeladdd = new Dictionary<int, string>(); 
        tabeladdd.Add(61 , "Brasilia");
        tabeladdd.Add(71 , "Salvador");
        tabeladdd.Add(11 , "Sao Paulo");
        tabeladdd.Add(21 , "Rio de Janeiro");
        tabeladdd.Add(32 , "Juiz de Fora");
        tabeladdd.Add(19 , "Campinas");
        tabeladdd.Add(27 , "Vitoria");
        tabeladdd.Add(31 , "Belo Horizinote");

        if (tabeladdd.ContainsKey(ddd))
        {
            Console.WriteLine(tabeladdd[ddd]);
        }
        else
        {
            Console.WriteLine("DDD nao cadastrado");
        }



    }

}