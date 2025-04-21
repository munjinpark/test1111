using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp3
{
    public class Shop
    {
        public void ShowShopInfo()
        {
            bool isRunning = true;

            do
            {
                Console.Clear();
                Console.WriteLine("상점입니다.");
                Console.WriteLine($"1. 구매하기");
                Console.WriteLine($"2. 판매하기");
                Console.WriteLine();
                Console.WriteLine("0. 나가기");
                Console.Write(">>");


                string Input = Console.ReadLine();

                switch (Input)
                {
                    case "1":
                        Console.WriteLine("구매하기");
                        break;
                    case "2":
                        Console.WriteLine("판매하기");
                        break;
                    case "0":
                        isRunning = false;
                        break;
                    default:
                        GameManager.ErrorMessage("잘못된 입력입니다.(구매:1, 판매2,  나가기 : 0)");
                        break;
                }

            } while (isRunning);

        }
    }
}
