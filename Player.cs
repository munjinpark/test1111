using System.Threading.Tasks.Dataflow;

namespace ConsoleApp3
{
    public class Player
    {
        public string name;
        public string job;
        public int level;
        public int money;

        public void SetPlayerInfo(string name, string job, int level, int money)
        {
            this.name = name;
            this.job = job;
            this.level = level;
            this.money = money;
        }

        public void ShowPlayerInfo()
        {
            bool isRunning = true;    

            do
            {
                Console.Clear();
                Console.WriteLine("캐릭터 정보");
                Console.WriteLine($"이름 : {name}");
                Console.WriteLine($"직업 : {job}");
                Console.WriteLine($"레벨 : {level}");
                Console.WriteLine($"돈 : {money}");
                Console.WriteLine();
                Console.WriteLine("0. 나가기");
                Console.Write(">>");


                string Input = Console.ReadLine();

                switch (Input)
                {
                    case "0":
                        isRunning = false;
                        break;
                    default:
                        GameManager.ErrorMessage("잘못된 입력입니다.(나가기 : 0)");
                        break;
                }

            } while (isRunning);
            
        }
    }
}
