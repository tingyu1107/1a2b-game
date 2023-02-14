using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1A2B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool game = true;
            Random r = new Random();
            while (game)
            {
                Console.WriteLine("歡迎來到 1A2B 猜數字的遊戲～\r\n");
                string ans = "";
            
                while(ans.Length < 4)
                {
                    int r1 = r.Next(0, 10);
                    if (!ans.Contains(r1.ToString()))
                    {
                        ans += r1.ToString();
                    }
                }
                Console.WriteLine(ans);
                int a = 0, b = 0;
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("------");
                    Console.WriteLine("請輸入 4 個數字： ");
                    string guess = Console.ReadLine();
                    for(int j = 0; j < 4; j++)
                    {
                        for(int k = 0; k < 4; k++)
                        {
                            if (guess[j] == ans[k])
                            {
                                if (j == k) a++;
                                else b++;
                            }
                        }
                    }

                    Console.WriteLine($"判定結果是{a}A{b}B");
                    if(a == 4 && b == 0) {
                        Console.WriteLine("恭喜你！猜對了！！");
                        break;
                    }
                    a = 0;
                    b = 0;
                
                }
                Console.WriteLine("------\r\n");
                Console.WriteLine("你要繼續玩嗎？(y/n): ");
                string end = "";
                end = Console.ReadLine();

                if (end == "y") game = true;
                if (end == "n")
                {
                    game= false;
                    Console.WriteLine("遊戲結束，下次再來玩喔～\r\n");
                }
            }
            
            Console.ReadKey(); 
        }
    }
}
