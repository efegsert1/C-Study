namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //변수명 연습
            /*string name = "한진우";
            int age = 17;
            string job = "학생";
            bool coding = true;

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(job);
            Console.WriteLine(coding);*/


            //연산자 연습
            /*int num1 = 8;
            int num2 = 5;

            int result = num1 + num2;
            int result2 = num1 - num2;
            int result3 = num1 * num2;
            int result4 = num1 / num2;
            int result5 = num1 % num2;

            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(result5);*/


            /*비교 연산자 > < >= <= != ==
            int num1 = 8; 
            int num2 = 5;

            bool result = num1 > 10;
            result = num1 < 10;
            result = num1 == 8;
            result = num1 != 10;*/

            /*string name = "진우";
            bool result2 = name == "잎프";

            bool isTrue = true;
            bool isFalse = false;

            bool result isTrue || isFalse*/

            int magicianDamage = 50;
            int warrerDamage = 70;
            int enemyHp = 100;
            int result = enemyHp - warrerDamage - magicianDamage;

            Console.WriteLine(result);
        }
    }
}
