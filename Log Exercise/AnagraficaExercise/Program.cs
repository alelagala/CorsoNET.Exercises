using System;
using System.Collections.Generic;

namespace AnagraficaExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {



            string cf = "LGLLSN9873425DHFS";
            Dictionary<string, Dictionary<DEPARTMENT, List<string>>> anagrafica = new Dictionary<string, Dictionary<DEPARTMENT, List<string>>>();

            anagrafica.Add(cf, new());
            anagrafica[cf].Add(DEPARTMENT.ASL, new List<string> { "Referto ritirato il 20/21","Ticket Pagato correttamente"});

            anagrafica[cf].Add(DEPARTMENT.COMUNE, new List<string> { "Prenotazione effettuata il 1/09/2022" });

            anagrafica[cf].Add(DEPARTMENT.POLIZIA, new List<string> { "Denuncia effettuata il 5/9/1999", "Denuncia Ricevuta il 14/07/2019" });

            anagrafica[cf].Add(DEPARTMENT.INPS, new List<string> {"Pensione ritirata correttamente","Avviso di servizio n.12914","Tessera sanitaria in scadenza!" });

            anagrafica[cf].Add(DEPARTMENT.SCUOLA, new List<string> { "Tasse scolastiche arretrate, pagare subito", "Conseguito diploma il 06/2001" });

            Console.WriteLine($"Accesso effettuato come ${cf}");
            string input;
            do
            {
                Console.Clear();
                Console.WriteLine("Scegliere tra\n -Asl\n -Comune\n -Polizia\n -Inps\n -Scuola\n -q per uscire");
                input = Console.ReadLine();
                if (anagrafica[cf].ContainsKey(DEPARTMENT.ASL) && input.ToLower() == "asl")
                {
                    Console.Clear(); Console.WriteLine("Anagrafica ASL:");
                    foreach (var item in anagrafica[cf][DEPARTMENT.ASL])
                    {
                        Console.WriteLine(item);
                    }
                    Console.ReadKey();
                }
                else if (anagrafica[cf].ContainsKey(DEPARTMENT.COMUNE) && input.ToLower() == "comune")
                {
                    Console.Clear(); Console.WriteLine("Anagrafica Comunale:");
                    foreach (var item in anagrafica[cf][DEPARTMENT.COMUNE])
                    {
                        Console.WriteLine(item);
                    }
                    Console.ReadKey();
                }
                else if (anagrafica[cf].ContainsKey(DEPARTMENT.POLIZIA) && input.ToLower() == "polizia")
                {
                    Console.Clear(); Console.WriteLine("Anagrafica Dipartimento di Polizia:");
                    foreach (var item in anagrafica[cf][DEPARTMENT.POLIZIA])
                    {
                        Console.WriteLine(item);
                    }
                    Console.ReadKey();
                }
                else if (anagrafica[cf].ContainsKey(DEPARTMENT.INPS) && input.ToLower() == "inps")
                {
                    Console.Clear(); Console.WriteLine("Anagrafica INPS:");
                    foreach (var item in anagrafica[cf][DEPARTMENT.INPS])
                    {
                        Console.WriteLine(item);
                    }
                    Console.ReadKey();
                }
                else if (anagrafica[cf].ContainsKey(DEPARTMENT.SCUOLA) && input.ToLower() == "scuola")
                {
                    Console.Clear(); Console.WriteLine("Anagrafica Scuola");
                    foreach (var item in anagrafica[cf][DEPARTMENT.SCUOLA])
                    {
                        Console.WriteLine(item);
                    }
                    Console.ReadKey();
                }
                else if(input!="q")
                {
                    Console.Clear(); Console.WriteLine("Anagrafica non presente provare a reinserire il dipartimento desiderato");
                    Console.ReadKey();
                }
            } while (input != "q");



        }
    }
    
    public enum DEPARTMENT
    {
        ASL,
        COMUNE,
        POLIZIA,
        INPS,
        SCUOLA
    }







}
