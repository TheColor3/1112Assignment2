using System;

namespace _1112Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int silasTotal = 0;
            int noahTotal = 0;
            int chrisTotal = 0;
            string progDone = "N";
            while(progDone == "N"){
                Console.WriteLine("Select Silas, Noah or Chris (S, N, C), or Z to end program.");
                string agent = Console.ReadLine();
                if(agent.ToUpper() == "S"){
                    Console.WriteLine("Input sale amount for Silas");
                    silasTotal+=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("New Total for Silas is $" + silasTotal);
                    }
                else if(agent.ToUpper() == "N"){
                    Console.WriteLine("Input sale amount for Noah");
                    noahTotal+=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("New Total for Noah is $" + noahTotal);
                    }
                else if(agent.ToUpper() == "C"){
                    Console.WriteLine("Input sale amount for Chris");
                    chrisTotal+=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("New Total for Chris is $" + chrisTotal);
                    }
                else if(agent.ToUpper() == "Z"){
                    Console.WriteLine("Totals by agent are as follows:");
                    Console.WriteLine("Silas: $" + silasTotal);
                    Console.WriteLine("Noah: $" + noahTotal);
                    Console.WriteLine("Chris: $" + chrisTotal);
                    Console.WriteLine("Total of all agents: $" + (silasTotal+noahTotal+chrisTotal));
                    int highest = 0;
                    if(silasTotal > highest){
                        highest = silasTotal;
                        if(noahTotal > highest){
                            highest = noahTotal;
                            if(chrisTotal > highest){
                                highest = chrisTotal;
                                Console.WriteLine("Highest total is Chris with $"+chrisTotal);
                            }else{
                                Console.WriteLine("Highest total is Noah with $"+noahTotal);
                            }
                        }else{
                            Console.WriteLine("Highest total is Silas with $"+silasTotal);
                        }
                    }
                    progDone = "Y";
                }
                else{
                    Console.WriteLine("invalid option, please enter S, N or C");
                    agent = Console.ReadLine();
                }
            }
        }
    }
}
