using System;
using System.Media;

namespace HCI_Mini_Bot
{
    internal class Program
    {
        public string Name { get; set; }
        public int Rate { get; set; }


        public void Welcome()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("WELCOME TO HUMAN COMPUTER INTERACTION BOT");
            Console.WriteLine("====================================");


            try
            {
                string filePath = "welcome.wav.wav";
                SoundPlayer player = new SoundPlayer(filePath);
                player.Play();
            }
            catch
            {
                Console.WriteLine("(Voice file not found)");
            }

            Console.Write("\nEnter your name: ");
            Name = Console.ReadLine();

            Console.Write("Rate yourself in HCI (1 - 10): ");
            Rate = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nHello {Name}! Welcome to the HCI Mini Bot.");
        }

        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("\n========= MENU =========");
                Console.WriteLine("1. Knowledge Check");
                Console.WriteLine("2. Assessment");
                Console.WriteLine("3. Exit");
                Console.Write("Choose option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        KnowledgeCheck();
                        break;
                    case "2":
                        Assessment();
                        break;
                    case "3":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }


        public void KnowledgeCheck()
        {
            Console.WriteLine("\n===== HCI KNOWLEDGE CHECK =====");

            Console.WriteLine("Usability: Easy and efficient to use.");
            Console.WriteLine("Learnability: Easy to learn.");
            Console.WriteLine("Memorability: Easy to remember.");
            Console.WriteLine("Feedback: System gives clear responses.");
            Console.WriteLine("Consistency: Same design and behavior.");
            Console.WriteLine("Visibility: Functions are visible.");
            Console.WriteLine("Affordance: Design suggests usage.");
            Console.WriteLine("Error Prevention: Avoid mistakes.");
            Console.WriteLine("Flexibility: Works for all users.");
            Console.WriteLine("Accessibility: Usable by everyone.");
        }


        public void Assessment()
        {
            int score = 0;

            if (Rate < 6)
            {
                Console.WriteLine("\n===== EASY QUIZ =====");


                score += AskQuestion(
                    "1. What does HCI stand for?\n" +
                    "a) Human Communication Interface\n" +
                    "b) Human Computer Interface\n" +
                    "c) Human-Computer Interaction\n" +
                    "d) Human Connection Interface",
                    "c");

                score += AskQuestion(
                    "2. Primary goal of HCI?\n" +
                    "a) Improve user experience\n" +
                    "b) Faster computers\n" +
                    "c) Reduce cost\n" +
                    "d) Limit tech",
                    "a");

                score += AskQuestion(
                    "3. Example of UI?\n" +
                    "a) Desktop background\n" +
                    "b) Power button\n" +
                    "c) Mouse pointer\n" +
                    "d) Keyboard",
                    "c");

                score += AskQuestion(
                    "4. Pointing device?\n" +
                    "a) Keyboard\nb) Mouse\nc) Microphone\nd) Printer",
                    "b");

                score += AskQuestion(
                    "5. Usability means?\n" +
                    "a) Many functions\n" +
                    "b) Easy to use\n" +
                    "c) Hardware design\n" +
                    "d) Speed",
                    "b");
            }
            else
            {
                Console.WriteLine("\n===== HARD QUIZ =====");


                score += AskQuestion(
                    "1. Cognitive model?\n" +
                    "a) GOMS\nb) KLM\nc) Fitts\nd) Gestalt",
                    "a");

                score += AskQuestion(
                    "2. Author of Design of Everyday Things?\n" +
                    "a) Shneiderman\nb) Norman\nc) Fitts\nd) Card",
                    "b");

                score += AskQuestion(
                    "3. Cursor movement law?\n" +
                    "a) Hick\nb) Fitts\nc) Gestalt\nd) Weber",
                    "b");

                score += AskQuestion(
                    "4. Personalization term?\n" +
                    "a) Usability\nb) Accessibility\nc) Customization\nd) Affordance",
                    "c");

                score += AskQuestion(
                    "5. Gesture-based UI?\n" +
                    "a) Command\nb) Graphical\nc) Tangible\nd) Natural",
                    "d");
            }

            double percentage = (score / 5.0) * 100;
            Console.WriteLine($"\nYour Score: {percentage}%");
        }


        public int AskQuestion(string question, string correctAnswer)
        {
            Console.WriteLine("\n" + question);
            Console.Write("Answer: ");
            string userAnswer = Console.ReadLine().ToLower();

            if (userAnswer == correctAnswer)
            {
                Console.WriteLine("Correct!");
                return 1;
            }
            else
            {
                Console.WriteLine("Wrong!");
                return 0;
            }
        }


        static void Main(string[] args)
        {
            Program bot = new Program();
            bot.Welcome();
            bot.Menu();
        }
    }
}