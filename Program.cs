namespace Haklı_TahminOyunu
{
    internal class Program
    {

        //Oyuncu isim girişi, puanlama, can, aşağı/yukarı, sıcak/soğuk, win/lose.
        //Menü, Hakkında, Kurallar.
        static void Main(string[] args)
        {

            Console.Write("Lütfen Oyuncu adını giriniz: ");
            string name = Console.ReadLine();
            Console.Beep(1000,1500);
            string choice = "";

            do
            {
                Console.WriteLine("Tahmin Oyununa Hoşgeldin!\n═════════════════════════\nMenü\n════\n\n1 - Yeni Oyun\n2 - Kurallar\n3 - Hakkında\n0 - Çıkış");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Game();
                        break;
                    case "2":
                        Rules();
                        break;
                    case "3":
                        About();
                        break;
                }

            } while (choice != "0");
            Console.WriteLine($"Tekrar görüşmek üzere {name}!");

            Console.ReadKey();

        }

        static void Game()
        {

            string gameCikis = "";
            do
            {
                Random random = new Random();
                int correctAnswer = random.Next(1, 101);
                int answer = 0;
                int health = 5;
                int point = 500;

                do
                {
                    Console.Write("Tahminini gir: ");
                    2answer = int.Parse(Console.ReadLine());
                    int diff = correctAnswer - answer;

                    if (health > 1)
                    {
                        if (diff >= 25 || diff <= -25)
                            Console.WriteLine("Çok soğuk...");
                        else if ((diff >= 15 && diff < 25) || (diff <= -15 && diff > -25))
                            Console.WriteLine("Soğuk...");
                        else if ((diff >= 6 && diff < 15) || (diff <= -6 && diff > -15))
                            Console.WriteLine("Ilık...");
                        else if ((diff >= 1 && diff < 6) || (diff <= -1 && diff > -6))
                            Console.WriteLine("YA-NI-YOR!");
                    }

                    if (answer > correctAnswer)
                    {
                        if (health > 1)
                        {
                            health--;
                            Console.WriteLine($"Aşağıya in! Kalan hak: {health}");
                        }
                        else if (health > 0)
                        {
                            health--;
                        }
                    }
                    else if (answer < correctAnswer)
                    {
                        if (health > 1)
                        {
                            health--;
                            Console.WriteLine($"Yukarı çık! Kalan hak: {health}");
                        }
                        else if (health > 0)
                        {
                            health--;
                        }
                    }
                } while (health > 0 && correctAnswer != answer);
                point = health * 100;
                if (answer == correctAnswer)
                    Console.WriteLine($"Tebrikler doğru cevap! Kazandın. Puanın: {point}");
                else if (health == 0)
                {
                    Console.WriteLine($"Üzgünüm oyunu kaybettin! Doğru cevap: {correctAnswer}. Puanın: {point}");
                }

                Console.WriteLine("ANAMENÜ'YE DÖNMEK İÇİN 0'A BASIN!");
                gameCikis = Console.ReadLine();
            } while (gameCikis != "0");
            Console.Clear();

        }
        static void Rules()
        {
            string rulesCikis = "";
            do
            {  
                Console.WriteLine("1 ile 100 arasındaki sayıyı tahmin etmeniz gerekmektedir.\n5 canınız vardır. Tüm canlarınız biterse oyunu kaybedersiniz.\nGirdiğiniz sayıya göre oyun Aşağı/Yukarı yönlendirmesi yapacaktır.\nEğer Fark;\n25 ve üzeriyse; Çok soğuk...\n15'ten 25'e kadar; Soğuk...\n6'dan 15'e kadar; Ilık...\n1'den 6'ya kadar; YA-NI-YOR! uyarısı alacaksınız.\nEn fazla 500 puan kazanabilirsiniz.\nDeniz Ceylan iyi oyunlar diler...\n\nANAMENÜ'YE DÖNMEK İÇİN 0'A BASIN!");
                rulesCikis = Console.ReadLine();

            } while (rulesCikis != "0");
            Console.Clear();
        }
        static void About()
        {
            string aboutCikis = "";
            do
            {
                Console.Write("╔");
                Console.Write("═════════╗╔═════════");
                Console.WriteLine("╗");
                Console.WriteLine($"║         ║║         ║\n║         ║║         ║\n║   ╔═════╝╚═════╗   ║");
                Console.WriteLine("╠═══╣Deniz Ceylan╠═══╣");
                Console.WriteLine($"║   ╚═════╗╔═════╝   ║\n║         ║║         ║\n║         ║║         ║");
                Console.Write("╚");
                Console.Write("═════════╝╚═════════");
                Console.Write("╝");

                Console.WriteLine("\n\nANAMENÜ'YE DÖNMEK İÇİN 0'A BASIN!");
                aboutCikis = Console.ReadLine();

            } while (aboutCikis != "0");
            Console.Clear();
        }
    }
}