using System.Runtime.Serialization.Formatters;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 변수명 연습(변수 = 변하는 수)
            /*string name = "한진우";
            int age = 17;
            string job = "학생";
            bool coding = true;

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(job);
            Console.WriteLine(coding);*/


            // 연산자 연습
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


            // 비교 연산자 > < >= <= != ==
            /*int num1 = 8; 
            int num2 = 5;

            bool result = num1 > 10;
            result = num1 < 10;
            result = num1 == 8;
            result = num1 != 10;*/

            // 논리 연산자
            /*string name = "진우";
            bool result2 = name == "잎프";

            bool isTrue = true;
            bool isFalse = false;

            bool result isTrue || isFalse*/

            // 변수 퀴즈
            /*int magicianDamage = 50;
            int warrerDamage = 70;
            int enemyHp = 100;
            int result = enemyHp - warrerDamage - magicianDamage;

            Console.WriteLine(result);*/

            // 형 변환
            // 작은 데이터에서 큰 데이터로 변환 가능
            /*int myNumber = 65; //65는 아스키코드로 A

            char myChar = (char)myNumber; // int를 char로 바꿈
            Console.WriteLine(myChar);*/  // A를 출력

            // 상수(변하지 않는 수)
            /*const int Constant = 1;
            Console.WriteLine(Constant);*/

            // 반복문(while문)
            /*int count = 0;

            while (count > 5)
            {
                Console.WriteLine("카운트: " + count);
                count++;
            }*/

            // 반복문(for문)
            /*for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }*/

            // 반복문(do while문)
            /*int num = 0;
            
            do
            {
                num--;
                Console.WriteLine(num);
            } while (num < 5);*/

            // 반복문 퀴즈
            /*int count = 1;
            
            while (count < 11)
            {
                Console.WriteLine(count);
                count++;
            }

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }

            int count1 = 0;

            do
            {
                count1++;
                Console.WriteLine(count1);
            } while (count1 < 10);*/

            // 중첩 루프
            /*for(int i = 2; i < 10;  i++) // i 값 : 2
            {
                for (int j = 0; j < 10; j++) // j값 : 1
                {
                    Console.WriteLine(i + "*" + j + "= i * j = " + (i * j)); // i * j -> 2*1
                }
            }*/

            // 조건문(if문)
            /*int score = 10;

            if (score >= 90)
            { 
               // 90 이상이라면 if문 옆 조건이 True라면 실행
                Console.WriteLine("A 학점");
            }*/

            // 조건문 (else if)
            /*int score = 10;

            if (score >= 90)
            {
                // 90 이상이라면 if문 옆 조건이 True라면 실행
                Console.WriteLine("A 학점");
            }
            else if (score >= 80)
            {

                Console.WriteLine("B 학점");
            }*/

            // 조건문 (else)
            /*int score = 10;
            if (score >= 90)
            {
                // 90 이상이라면 if문 옆 조건이 True라면 실행
                Console.WriteLine("A 학점");
            }
            else if (score >= 80)
            {
                // 80 이상이라면 if문 옆 조건이 True라면 실행
                Console.WriteLine("B 학점");
            }
            else
            {
                // 둘다 아니라면 실행
                Console.WriteLine("F 학점");
            }*/

            // 조건문 퀴즈
            /*int score = 57;
            
            if (score >= 90)
            {
                Console.WriteLine("A 학점");
            }
            else if (score >= 80)
            {
                Console.WriteLine("B 학점");
            }
            else if (score >= 70)
            {
                Console.WriteLine("C 학점");
            }
            else if (score >= 60)
            {
                Console.WriteLine("D 학점");
            }
            else
            {
                Console.WriteLine("F 학점");
            }

            if(score % 2 == 0)
            {
                Console.WriteLine("짝수");
            }
            else
            {
                Console.WriteLine("홀수");
            }*/

            // 조건문 (switch 문)
            /*string day = "월요일";

            switch (day)
            {
                case "월요일":
                    Console.WriteLine("월요일");
                    break;
                case "화요일":
                    Console.WriteLine("화요일");
                    break;
                case "수요일":
                    Console.WriteLine("수요일");
                    break;
                default:
                    Console.WriteLine("다른 요일");
                    break;
            }*/

            // switch 문 바깥 -> break 즁괄호 바깥으로 빠져나옴 그 밑은 실행 안함

            // break 문
            /*for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("반복문을 종료합니다");
                    break;
                }
                Console.WriteLine(i);
            }*/

            // continue 문
            /*for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("짝수는 패스");
                    continue;
                }
                Console.WriteLine(i);
            }*/

            //for문 퀴즈
            /*for (int i = 1; i < 11; i++) // 1~10까지 출력
            {
                if (i >= 5) // 5보다 큰 수를 출력
                {
                    Console.WriteLine(i);
                }

                if(i == 8) // 그 수가 8이면 반복문 종료
                {
                    Console.WriteLine("반복문 종료");
                    break;
                }           
            }*/

            //for문 퀴즈
            /*for (int i = 1; i < 21; i++) // 1~20까지 출력
            {
                if(i % 2 == 0) // 짝수만 출력
                {
                    if (i == 12) // 12는 출력 건너뜀
                    {
                        Console.WriteLine("패스");
                        continue;
                    }
                    Console.WriteLine(i);
                }
            }*/

            // switch 퀴즈
            /*int score = 88;
            
            switch (score / 10)
            {
                case 9:
                    Console.WriteLine("A");
                    break;
                case 8:
                    Console.WriteLine("A");
                    break;
                case 7:
                    Console.WriteLine("A");
                    break;
                case 6:
                    Console.WriteLine("A");
                    break;
                default:
                    Console.WriteLine("F");
                    break;
            }*/

            // 배열 (Array)       // 배열의 크기 (몇개를 넣을건가)
            /*int[] studentArray = new int[6] { 1, 2, 3, 4, 5, 6 }; 
            Console.WriteLine(studentArray.Length); // 배열의 길이 출력

            Console.WriteLine(studentArray[3]); // index 사용 0부터 시작 0, 1, 2, 3... 3출력 = 4
            studentArray[3] = 20;
            Console.WriteLine(studentArray[3]);*/

            // 배열 퀴즈
            /*int[] student = new int[] { 1, 2, 3, 4, 5, 6 };

            for (int i = 0; i < student.Length; i++)
            {
                student[i]++;
                Console.WriteLine("i의 값 : " + i + "student["+i+"] = "+ student);
            }*/
           
            // 유니티(C#) 기초 1일차 끝
        }
    }
}
