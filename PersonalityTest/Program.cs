using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt mis on tema lemmikvärv;
            //kui kasutaja sisestab "punane", konsool kuvab "Oled romantiline.";
            //kui kasutaja sisestab "sinine", konsool kuvab "Oled töökas.";
            //kui kasutaja sisestab "roheline", konsool kuvab "Oled loodusesõber.";
            //kui kasutaja sisestab midagi muud, konsool kuvab "Oled {userColor} ükssarvik."

            Console.WriteLine("Palun sisestage oma lemmikvärv");
            string userColor = Console.ReadLine();

            if(userColor == "punane")
            {
                Console.WriteLine("Oled romantiline.");
            }
            else if(userColor == "sinine")
            {
                Console.WriteLine("Oled töökas.");
            }
            else if(userColor == "roheline")
            {
                Console.WriteLine("Oled loodusesõber.");
            }
            else
            {
                Console.WriteLine($"Oled {userColor} ükssarvik.");
            }
            Console.WriteLine("Kena päeva!");


        }
    }
}
