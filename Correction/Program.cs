using System;
using System.Collections.Generic;

namespace Maori_Quiz_NCEA
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                {
                    bool wants_to_restart = false;
                    while (wants_to_restart != true)

                    {


                        {
                            Console.WriteLine("thank you for playing");

                            /***************Starting the code****************/
                            Console.WriteLine("Welcome to the Maori quiz!!!");//welcoming user to the quiz
                            Console.WriteLine("What is your name");//Asking your for name
                            String name = Console.ReadLine(); // stores into a variable and presents your user the questioin
                            Console.WriteLine("How old are you"); // Asking user for age
                            int age = int.Parse(Console.ReadLine()); //stores into a variable and presents your user the questioin
                            Console.WriteLine("hello " + name + " you are " + age + " years old"); // presenting user name and age in one sentence


                            if (age < 18)// checking if age is right for quiz
                            {
                                Console.WriteLine("you are prefect for the quiz");
                            }

                            else if (age > 18 && age < 60) //if user is a bit to old

                            {
                                Console.WriteLine("You are perfect for the quiz");

                            }



                            else// if user is way too old for quiz
                            {
                                Console.WriteLine("You should be home resting");
                            }

                            //Question 1

                            Console.WriteLine("What is Hello in Maori?");// asking the first question


                            string[] HelloArray2 = { "kiaora", "Kiwi", "iwi" }; // possible answers to the question 
                            Console.WriteLine(string.Join(", ", HelloArray2));


                            string answer = Console.ReadLine();//storing a variable


                            if (answer == "kiaora")
                            {
                                Console.WriteLine("You got it right");// the right answer show this
                            }

                            else
                            {
                                Console.WriteLine("answer was kiaora");     //answer is wrong show this

                            }


                            // question 2

                            Console.WriteLine("What is tribe in Maori?"); // asking 2 question

                            string[] tribeArray = new string[4];
                            tribeArray[0] = "iwi";// possible answer to the question 
                            tribeArray[1] = "mako";// possible answer to the question 
                            tribeArray[2] = "kea";// possible answer to the question 
                            Console.WriteLine(string.Join(", ", tribeArray));

                            string answer2 = Console.ReadLine();//storing a variable

                            if (answer2 == "iwi")
                            {
                                Console.WriteLine("You got it right"); // If the answer is right show this
                            }


                            else
                            {
                                Console.WriteLine("answer was iwi"); // If the answer is wrong show this

                            }

                            // question 3

                            Console.WriteLine("What is love in Maori?");// asking the 3 question


                            string[] loveArray3 = { "hui", "aroha", "kai" }; // possible answers to the question 
                            Console.WriteLine(string.Join(", ", loveArray3));


                            string answer3 = Console.ReadLine();//storing a variable


                            if (answer3 == "aroha")
                            {
                                Console.WriteLine("You got it right");// the right answer show this
                            }

                            else
                            {
                                Console.WriteLine("answer was aroha");     //answer is wrong show this

                            }

                            // question 4

                            Console.WriteLine("What is the native bird of Aotearoa ?"); // asking fourth question

                            string[] mountainArray = new string[4];
                            mountainArray[0] = "moa";// possible answer to the question 
                            mountainArray[1] = "kikoi";// possible answer to the question 
                            mountainArray[2] = "kiwi";// possible answer to the question
                            Console.WriteLine(string.Join(", ", mountainArray));

                            string answer4 = Console.ReadLine();//storing a variable

                            if (answer4 == "kiwi")
                            {
                                Console.WriteLine("You got it right"); // If the answer is right show this
                            }


                            else
                            {
                                Console.WriteLine("answer was kiwi"); // If the answer is wrong show this

                            }

                            //question 5

                            Console.WriteLine("What is prayer in Maori?");// asking the 5 question


                            string[] prayerArray5 = { "kiaora", "karakia ", "kikoi" }; // possible answers to the question 
                            Console.WriteLine(string.Join(", ", prayerArray5));


                            string answer5 = Console.ReadLine();//storing a variable


                            if (answer5 == "karakia")
                            {
                                Console.WriteLine("You got it right");// the right answer show this
                            }

                            else
                            {
                                Console.WriteLine("answer was karakia");     //answer is wrong show this

                            }

                            //question 6

                            Console.WriteLine("What is the mountain in Maori?"); // asking fourth question

                            string[] mountainArray7 = new string[4];
                            mountainArray7[0] = "haka";// possible answer to the question
                            mountainArray7[1] = "iwi";// possible answer to the question
                            mountainArray7[2] = "maunga";// possible answer to the question
                            Console.WriteLine(string.Join(", ", mountainArray7));

                            string answer6 = Console.ReadLine();//storing a variable

                            if (answer6 == "maunga")
                            {
                                Console.WriteLine("You got it right"); // If the answer is right show this
                            }


                            else
                            {
                                Console.WriteLine("answer was maunga "); // If the answer is wrong show this

                            }

                            //question 7

                            Console.WriteLine("What is large in Maori?");// asking the 7 question


                            string[] prayerArray7 = { "kauri", "nui  ", "moana" }; // possible answers to the question 
                            Console.WriteLine(string.Join(", ", prayerArray7));


                            string answer7 = Console.ReadLine();//storing a variable


                            if (answer7 == "nui")
                            {
                                Console.WriteLine("You got it right");// the right answer show this
                            }

                            else
                            {
                                Console.WriteLine("answer was nui"); //answer is wrong show this

                            }

                            //question 8

                            Console.WriteLine("What is the sea in Maori?"); // asking 8 question

                            string[] seaArray8 = new string[4];
                            seaArray8[0] = "haka";// possible answer to the question
                            seaArray8[1] = "kiwi";// possible answer to the question
                            seaArray8[2] = "moana";// possible answer to the question
                            Console.WriteLine(string.Join(", ", seaArray8));

                            string answer8 = Console.ReadLine(); //storing a variable

                            if (answer8 == "moana")
                            {
                                Console.WriteLine("You got it right"); // If the answer is right show this
                            }


                            else
                            {
                                Console.WriteLine("answer was moana"); // If the answer is wrong show this

                            }

                            //question 9

                            Console.WriteLine("What is island in Maori?");// asking the 9 question


                            string[] islandArray9 = { "kohwai", "nui  ", "motu" }; // possible answers to the question 
                            Console.WriteLine(string.Join(", ", islandArray9));


                            string answer9 = Console.ReadLine();//storing a variable


                            if (answer9 == "motu")
                            {
                                Console.WriteLine("You got it right");// the right answer show ths
                            }

                            else
                            {
                                Console.WriteLine("answer was motu"); //answer is wrong show this

                            }

                            //question 10

                            Console.WriteLine("What is stomach in Maori?"); // asking 10 question

                            string[] stomachArray10 = new string[4];
                            stomachArray10[0] = "kauri";// possible answer to the question
                            stomachArray10[1] = "puku";// possible answer to the question
                            stomachArray10[2] = "iwi";// possible answer to the question
                            Console.WriteLine(string.Join(", ", stomachArray10));

                            string answer10 = Console.ReadLine();//storing a variable

                            if (answer10 == "puku")
                            {
                                Console.WriteLine("You got it right"); // If the answer is right show this
                            }


                            else
                            {
                                Console.WriteLine("answer was puku"); // If the answer is wrong show this

                            }

                            Console.WriteLine("Did you enjoy the quiz");
                            string[] enjoyedArray11 = { "enjoyed", "it was bad" }; // possible answers to the question 
                            Console.WriteLine(string.Join(", ", enjoyedArray11));

                            string answer11 = Console.ReadLine();//storing a variable

                            if (answer11 == "enjoyed")
                            {
                                Console.WriteLine("thank you for the feedback"); // If the answer is enjoyed show this
                            }


                            else
                            {
                                Console.WriteLine("thank i will try to make it better"); // If the answer is bad show this

                            }


                            Console.WriteLine("want to start");

                            string[] restartArray = { "restart", "leave" };
                            Console.WriteLine(string.Join(", ", restartArray));

                            string answer12 = Console.ReadLine();


                            if (answer12 == "restart")

                            {
                                wants_to_restart = true;
                                Console.WriteLine("restart");
                            }
                            else

                            {

                                Console.WriteLine("bye");
                            }


                        }





                    }
                }

                /***************Finish the code****************/


            }

        }

    }
}
