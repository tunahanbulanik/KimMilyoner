using System;

namespace KimMilyoner
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogruCevap = 0;  //Dogru cevap sayisini takip etmek icin
            int yanlisCevap = 0;  //Yanlis cevap sayisini takip etmek icin

            Console.WriteLine("1 - Kızınca tükürün hayvan hangisidir? \n A-) Lama  B-) Deve");
            string cevap1 = Console.ReadLine().ToLower(); //Ben yinede ToLower kullandim
            switch (cevap1)
            {
                case "a":
                    dogruCevap++;
                    Console.WriteLine("Doğru cevap!");
                    break;
                    case "b":
                    yanlisCevap++;
                    Console.WriteLine("Yanlış cevap...");
                    break;
            }

            Console.WriteLine("2 - Dünyaya en yakın gezegen hangisidir? \n A-) Venüs  B-) Mars");
            string cevap2 = Console.ReadLine().ToLower();
            switch (cevap2)
            {
                case "a":
                    dogruCevap++;
                    Console.WriteLine("Doğru cevap!");
                    break;
                    case "b":
                    yanlisCevap++;
                    Console.WriteLine("Yanlış cevap...");
                    break;

            }

            if (yanlisCevap >= 2)
            {
                Console.WriteLine("2 yanlıştan dolayı elendiniz...");
            } else
            {
             if (dogruCevap >= 2)
            {
                Console.WriteLine("Yarışmayı kazandınız!");
            } else
            {
                Console.WriteLine("3 - 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır? \n A-) 7  B-) 12");
                string cevap3 = Console.ReadLine().ToLower();
                switch (cevap3)
                {
                    case "a":
                        dogruCevap++;
                        Console.WriteLine("Doğru cevap!");
                        break;
                        case "b":
                        Console.WriteLine("Yanlış cevap...");
                        break;
                }
                    if(dogruCevap >= 2)
                    {
                        Console.WriteLine("Kazandınız!");
                    }
                    else
                    {
                        Console.WriteLine("Maalesef elendiniz...");
                    }
            }
            }
        }    
    }
}
