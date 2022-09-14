using System.Text;
using System.Collections.Generic;

namespace ConsoleAppGroup1
{
    internal class Program
    {
        private static object kvp;

        static void Main(string[] args)
        {
            bool loop = true;
            do
            {
                Console.Clear();

                Console.WriteLine("---- Menu ----\n1: ArrayEx\n2: ListEx\n3: DictionaryEx\n4: \n5: StringBuilder \n6: SpeedTest\n7: ExceptionsEx\n8: RandomEx\n0: Exit\n\nPress number to run Example.\n\n");
                char selection = Console.ReadKey(true).KeyChar;
                switch (selection)
                {
                    case '1':
                        ArrayEx();
                        break;

                    case '2':
                        List<int> MyNumbers = new List<int> { 1, 2, 3 };
                        foreach (int i in MyNumbers)
                        { Console.WriteLine(i); }
                        break;

                    case '3':
                        DictionaryEx();
                        break;

                    case '4':
                        int startNumber = 13;
                        int result = PrimitivVarible(startNumber);
                        Console.WriteLine($"start number = {startNumber}\nresult number = {result}");
                        break;

                    case '5':
                        StringBuilder stringBuilder = new StringBuilder();
                        stringBuilder = stringBuilder.Insert(0, "hello ");
                        AddWorld(stringBuilder);
                        Console.WriteLine(stringBuilder);
                        // the word hello
                        break;

                    case '6':
                        SpeedTest();
                        break;

                    case '7':
                        ExceptionsEx();
                        break;

                    case '8':
                        RandomEx();
                        break;

                    case '0':
                        loop = false;
                        break;

                    default:
                        Console.WriteLine("Invalid selection");
                        break;
                }

                Console.WriteLine("Press any key to continue.");
                Console.ReadKey(true);
            } while (loop);

        }// End of Main

        //----------------------------------------------------------------------------------------------------------------------------------------------------
        static void ArrayEx()                                                                                                                    //case1
        {
            string[] NamesOfDogs = { "Woof", "Floof", "Doggo" };
            for (int i = 0; i < NamesOfDogs.Length; i++)
            {
                Console.WriteLine(NamesOfDogs[i]);
            }


            //sort

        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------
        static void ListEx()                                                                                                                     //case2
        {
            List<double> tempeturs = new List<double>();


        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------
        static void DictionaryEx()                                                                                                               //case3
        {
            IDictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(2001, "Alex");
            numberNames.Add(2000, "Alexander");
            numberNames.Add(1999, "Alexis");
            numberNames.Add(1998, "Aladdin");
            numberNames.Add(1997, "Ahmad");

            foreach (KeyValuePair<int, string> kvp in numberNames)
                Console.WriteLine("Name: {0}, Born: {1}", kvp.Value, kvp.Key);



        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------
        static int PrimitivVarible(int numberIn)//int is a copy                                                                                  //case4
        {
            numberIn = numberIn + 12;

            return numberIn;
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------
        private static void AddWorld(StringBuilder stringBuilder)
        {
            stringBuilder.Append("world!");
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------
        private static void SpeedTest()                                                                                                          //case6
        {
            string starsString = "";
            DateTime stringStart = DateTime.Now;

            for (int i = 0; i < 10000; i++)
            {
                starsString += "*";
            }

            DateTime stringEnd = DateTime.Now;

            StringBuilder sb = new StringBuilder();
            DateTime sbStart = DateTime.Now;

            for (int i = 0; i < 10000; i++)
            {
                sb.Append("*");
            }

            DateTime sbEnd = DateTime.Now;

            Console.WriteLine($"string time: {stringEnd - stringStart}");
            Console.WriteLine($"StringBuilder time: {sbEnd - sbStart}");
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------
        private static void ExceptionsEx()                                                                                                        //case7
        {
            bool notNumber = true;
            int testnumber = 0;
            while (notNumber)
            {


                try
                {
                    testnumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The number that you are using is correct");
                    //testnumber = testnumber * 1;
                    notNumber = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The type of variable is wrong, We're using Integer number");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The number is too big");
                }
                catch (Exception)
                {
                    Console.WriteLine("You have to insert a number");
                }
                finally//will always run this part
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Thank you for using our system");

        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------
        private static void RandomEx()                                                                                                           //case8
        {
            //Random random = new Random(1);//seed number tells the random what table of random numbers to use
            Random random = new Random();//uses the computer clock to get as a seed number
            //Random random = new Random(DateTime.Now.Ticks)//same as new Random()
            int testnumber = 0;
            //testnumber = random.Next(1, 13);
            //Console.WriteLine(testnumber);
            int randomNumber = random.Next();

            Console.WriteLine("Random Number was: " + randomNumber); //0 to 2.1B


            Console.WriteLine("0 to 10");
            Console.WriteLine("***********************************");
            for (int i = 0; i < 10; i++)
            {
                testnumber = random.Next(10);
                Console.WriteLine("+++++++++++++++++++++++++++++++");
                Console.WriteLine(testnumber);

            }
            Console.WriteLine("1 to 10");
            Console.WriteLine("***********************************");
            for (int i = 0; i < 10; i++)
            {
                //min and max 1 - 10
                testnumber = random.Next(1, 10);
                Console.WriteLine("+++++++++++++++++++++++++++++++");
                Console.WriteLine(testnumber);
            }














        } //End of class-------------------------------------------------------------------------------------------------------------------------------------------
    }
}