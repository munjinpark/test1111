using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Menu
    {
        private Player? player = null;
        private Shop? shop = null;

        public Menu()
        {
            player = new Player();
            player.SetPlayerInfo("홍길동", "전사", 1, 1000);
            shop = new Shop();
        }


        public void DisplayMenu()
        {
            bool isRunning = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Menu!");
                Console.WriteLine("1. 캐릭터 정보");
                Console.WriteLine("2. 인벤토리");
                Console.WriteLine("3. 상점");

                Console.WriteLine();
                Console.WriteLine("q. 종료");
                Console.Write(">>");


                string Input = Console.ReadLine();

                switch (Input)
                {
                    case "1":
                        if (player != null)
                            player.ShowPlayerInfo();
                        break;
                    case "2":
                        if(shop!= null)
                            shop.ShowShopInfo();
                        break;
                    case "3":
                        Console.WriteLine("상점");
                        break;
                    case "q":
                        isRunning = false;
                        break;
                    default:
                        GameManager.ErrorMessage("잘못된 입력입니다.(옳바른키 : 1~3, 종료 : q)");
                        break;
                }
            } while (isRunning);
        }
    }
}
