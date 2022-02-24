using System;

namespace PersonalityTestSwitch
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
            string userColor = Console.ReadLine().ToLower();

            switch (userColor)
            {
                case "punane":
                    Console.WriteLine("Oled romantiline.");
                    break;
                case "sinine":
                    Console.WriteLine("Oled töökas.");
                    break;
                case "roheline":
                    Console.WriteLine("Oled loodusesõber.");
                    break;
                default:
                    Console.WriteLine($"Oled {userColor} ükssarvik.");
                    break;

            }
            Console.WriteLine("Kena päeva!");



        }
    }
}
