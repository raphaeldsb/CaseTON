using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using CarregaCSV.Dominio;

namespace CarregaCSV
{
    public class CSV
    {
        private List<Cases> listCases = new List<Cases>();
        private List<Creds> listCreds = new List<Creds>();
        
        string[] path = Directory.GetParent(Directory.GetCurrentDirectory()).ToString().Split("\\");
        
        public List<Cases> CarregaCases()
        {
            string pathCSV = path[0] + "\\" + path[1] + "\\" + path[2] + "\\" + path[3] + "\\" + path[4] + "\\Arquivos CSV\\";
            string linha = "";
            string[] linhaseparada = null;

            StreamReader reader = new StreamReader(pathCSV + "cases.csv", Encoding.UTF8, true);
            while (true)
            {
                linha = reader.ReadLine();
                if (linha == null) break;
                linhaseparada = linha.Split(',');

                if (linhaseparada[1] != "" && linhaseparada[1] != "accountid")
                {
                    Console.WriteLine(linha);
                    var assunto = linhaseparada[7].Split(":");
                    listCases.Add(new Cases()
                    {
                        id = Convert.ToInt32(linhaseparada[0]),
                        accountId = linhaseparada[1],
                        dateRef = linhaseparada[2],
                        channelId = Convert.ToInt32(linhaseparada[3]),
                        waitingTime = Convert.ToInt32(linhaseparada[4]),
                        missed = linhaseparada[5],
                        feedback = linhaseparada[6],
                        category_1 = assunto[0],
                        category_2 = assunto[1],
                        category_3 = assunto[2]

                    });
                }
                
            }

            return listCases;
        }


        public List<Creds> CarregaCreds()
        {
            string pathCSV = path[0] + "\\" + path[1] + "\\" + path[2] + "\\" + path[3] + "\\" + path[4] + "\\Arquivos CSV\\";
            string linha = "";
            string[] linhaseparada = null;

            StreamReader reader = new StreamReader(pathCSV + "creds.csv", Encoding.UTF8, true);
            while (true)
            {
                linha = reader.ReadLine();
                if (linha == null) break;
                linhaseparada = linha.Split(',');
                Console.WriteLine(linha);

                if (linhaseparada[1] != "cred_date" && linhaseparada[5] != "")
                {
                    listCreds.Add(new Creds()
                    {
                        credDate = linhaseparada[1],
                        shippingAddressCity = linhaseparada[2],
                        shippingAddressState = linhaseparada[3],
                        product = linhaseparada[4],
                        accountid = linhaseparada[5]
                    });
                }

            }

            return listCreds;
        }


    }
}
