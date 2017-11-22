using System;
using System.Collections.Generic;

namespace ExemploLista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cidades = new List<string>();
            cidades.Add("São Paulo");
            cidades.Add("Curitiba");
            cidades.Add("Osasco");
            cidades.Add("Manaus");

            Console.WriteLine(cidades[1].ToUpper());

            List<Usuarios> us = new List<Usuarios>();
            Usuarios Lucas = new Usuarios(){Id = 44, Login = "Lucas", Senha = "senhadolucas"};
            Usuarios Tuanny = new Usuarios(){Id = 2, Login = "Tuanny", Senha = "senhadatuanny"};

            us.Add(Lucas);
            us.Add(Tuanny);
            
            Console.WriteLine(us[0].Senha); //poderia fazer um foreach para ler todo mundo que tá ali dentro.

            List<Produto> sacola = new List<Produto>();

            HigienePessoal sabonete = new HigienePessoal(){Id = 2345234, Nome = "Dove", Preco = 12.50, NumeroMS = "32445.23345", Marca = "Unilever"};
            Bebidas cerveja = new Bebidas();
            cerveja.Id = 9423;
            cerveja.Nome = "Skol";
            cerveja.Preco = 7.00;
            cerveja.TeorAlcoolico = 4.5;
            cerveja.Tipo = "Alcoólica";

            sacola.Add(sabonete);
            sacola.Add(cerveja);

            Console.WriteLine(sacola[0].Nome);
            Console.WriteLine();
            
            foreach (var item in sacola)
            {
                string classe = item.GetType().ToString(); //vai retornar se o item é HigienePessoal ou Bebidas

                switch (classe)
                {
                    case "ExemploLista.HigienePessoal":
                    {
                        HigienePessoal higiene = (HigienePessoal)item; //Esse é o CAST
                        //preciso converter o PRODUTO em HIGIENE PESSOAL, 
                        //como não tem um "ConvertToHigienePessoal", tem que ser desse jeito.
                        //Só posso fazer isso pq a classe "HigienePessoal" é classe-filha de "Produto".
                        
                        Console.WriteLine("Higiene Pessoal: "+ higiene.Nome + " - "
                                                             + higiene.NumeroMS + " - "
                                                             + higiene.Marca + " - ");
                        break;
                    }
                    case "ExemploLista.Bebidas":
                    {
                        Bebidas bebida = (Bebidas)item;
                        Console.WriteLine("Bebidas: "   + bebida.Nome + " - "
                                                        + bebida.TeorAlcoolico + " - "
                                                        + bebida.Tipo);
                        break;
                    }
                        
                }
            }

            

            //Produto arroz = new Produto(){Id = 2, Nome = "Tio Juão", Preco = 12.00};

        }
    }
}
