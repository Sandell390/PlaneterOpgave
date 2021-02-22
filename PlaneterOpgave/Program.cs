using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneterOpgave
{
    class Program
    {
        static void Main(string[] args)
        {

            //Opg 2
            List<Planeter> ListPlanet = new List<Planeter>();

            Planeter Merkur = new Planeter();
            Merkur.Navn = "Merkur";
            Merkur.Diamenter = 4879;
            Merkur.Gravity = 3.7;
            Merkur.Temperature = 167;
            ListPlanet.Add(Merkur);

            Planeter Jorden = new Planeter();
            Jorden.Navn = "Jorden";
            Jorden.Diamenter = 12756;
            Jorden.Gravity = 9.8;
            Jorden.Temperature = 15;
            ListPlanet.Add(Jorden);

            Planeter Mars = new Planeter();
            Mars.Navn = "Mars";
            Mars.Diamenter = 6792;
            Mars.Gravity = 3.7;
            Mars.Temperature = -65;
            ListPlanet.Add(Mars);


            Planeter Jupiter = new Planeter();
            Jupiter.Navn = "Jupiter";
            Jupiter.Diamenter = 142984;
            Jupiter.Gravity = 23.1;
            Jupiter.Temperature = -110;
            ListPlanet.Add(Jupiter);

            Planeter Saturn = new Planeter();
            Saturn.Navn = "Saturn";
            Saturn.Diamenter = 120536;
            Saturn.Gravity = 9.0;
            Saturn.Temperature = -140;
            ListPlanet.Add(Saturn);

            Planeter Uranus = new Planeter();
            Uranus.Navn = "Uranus";
            Uranus.Diamenter = 51118;
            Uranus.Gravity = 8.7;
            Uranus.Temperature = -195;
            ListPlanet.Add(Uranus);

            Planeter Neptune = new Planeter();
            Neptune.Navn = "Neptune";
            Neptune.Diamenter = 49528;
            Neptune.Gravity = 11.0;
            Neptune.Temperature = -200;
            ListPlanet.Add(Neptune);

            Planeter Pluto = new Planeter();
            Pluto.Navn = "Pluto";
            Pluto.Diamenter = 2370;
            Pluto.Gravity = 0.7;
            Pluto.Temperature = -225;
            ListPlanet.Add(Pluto);

            //Opg 3
            Console.WriteLine("Planeter: ");
            foreach (Planeter plante in ListPlanet) //ListPlanet er listen over planeter
            {
                Console.WriteLine(plante.Navn);
            }
            Console.WriteLine();

            //Opg 4
            Planeter Venus = new Planeter();
            Venus.Navn = "Venus";
            Venus.Diamenter = 12104;
            Venus.Gravity = 8.9;
            Venus.Temperature = 464;

            ListPlanet.Insert(1, Venus);

            //Opg 5
            Console.WriteLine("Planeter: ");
            foreach (Planeter plante in ListPlanet) //ListPlanet er listen over planeter
            {
                Console.WriteLine(plante.Navn);
            }
            Console.WriteLine();

            //Opg 6
            ListPlanet.Remove(Pluto);

            /*
            foreach (Planeter planet in ListPlanet)
            {
                if (planet == Pluto) 
                {
                    ListPlanet.Remove(planet);
                }
            }
            */

            //Opg 7
            Console.WriteLine("Planeter: ");
            foreach (Planeter plante in ListPlanet) //ListPlanet er listen over planeter
            {
                Console.WriteLine(plante.Navn);
            }
            Console.WriteLine();

            //Opg 8
            ListPlanet.Add(Pluto);

            //Opg 9
            Console.WriteLine("Antal planeter: " + ListPlanet.Count);
            Console.WriteLine();

            //Opg 10
            List<Planeter> NewListTemperature = new List<Planeter>();

            NewListTemperature.AddRange(ListPlanet.Where(x => x.Temperature < 0));

            Console.WriteLine("Mean Temperature under 0");
            foreach (Planeter plante in NewListTemperature) //ListPlanet er listen over planeter
            {
                Console.WriteLine(plante.Navn);
            }
            Console.WriteLine();

            //Opg 11
            List<Planeter> NewListDiameter = new List<Planeter>();

            NewListDiameter.AddRange(ListPlanet.Where(x => x.Diamenter > 10000 && x.Diamenter < 50000));

            Console.WriteLine("Diameter 10.000 - 50.000");
            foreach (Planeter plante in NewListDiameter) //ListPlanet er listen over planeter
            {
                Console.WriteLine(plante.Navn);
            }
            Console.WriteLine();

            //Opg 12
            ListPlanet.Clear();

            Console.ReadLine();

        }
    }
}
