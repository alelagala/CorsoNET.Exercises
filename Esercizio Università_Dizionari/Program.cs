using System;
using System.Collections.Generic;

namespace Esercizio_Università_Dizionari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<DIPARTIMENTI, Dictionary<Matricola, List<Esame>>> università = new Dictionary<DIPARTIMENTI, Dictionary<Matricola, List<Esame>>>();
            //Creo 5 matricole, una per dipartimento
            Matricola matricola1 = new Matricola("Ale", 192391);
            Matricola matricola2 = new Matricola("Marco", 941397);
            Matricola matricola3 = new Matricola("Lucia", 356755);
            Matricola matricola4 = new Matricola("Antonio", 105535);
            Matricola matricola5 = new Matricola("Sandra", 333658);

            //Creo 5 esami, uno per matricola
            Esame analisi = new Esame(1901, "Analisi Matematica", -1);
            Esame chimicaOrganica = new Esame(1901, "Chimica Organica", -1);
            Esame cinematica = new Esame(1901, "Cinematica", -1);
            Esame chimicaInorganica = new Esame(1901, "Chimica Inorganica", -1);
            Esame ingegneriaDelSoftware = new Esame(1901, "Ingegneria del Software", -1);

            //Aggiungo le chiavi "dipartimento" al dizionario
            università.Add(DIPARTIMENTI.FISICA, new());
            università.Add(DIPARTIMENTI.MATEMATICA, new());
            università.Add(DIPARTIMENTI.BIOLOGIA, new());
            università.Add(DIPARTIMENTI.CHIMICA, new());
            università.Add(DIPARTIMENTI.INFORMATICA, new());

            //Aggiungo le chiavi "matricola" al dizionario
            università[DIPARTIMENTI.FISICA].Add(matricola1, new());
            università[DIPARTIMENTI.MATEMATICA].Add(matricola2, new());
            università[DIPARTIMENTI.BIOLOGIA].Add(matricola3, new());
            università[DIPARTIMENTI.CHIMICA].Add(matricola4, new());
            università[DIPARTIMENTI.INFORMATICA].Add(matricola5, new());

            //Aggiungo gli esami alla lista di esami di ogni matricola
            università[DIPARTIMENTI.FISICA][matricola1].Add(cinematica);
            università[DIPARTIMENTI.MATEMATICA][matricola2].Add(analisi);
            università[DIPARTIMENTI.BIOLOGIA][matricola3].Add(chimicaOrganica);
            università[DIPARTIMENTI.CHIMICA][matricola4].Add(chimicaInorganica);
            università[DIPARTIMENTI.INFORMATICA][matricola5].Add(ingegneriaDelSoftware);

            Console.WriteLine("--Tutte le facoltà:");
            foreach (var item in università)
            {                
                    Console.WriteLine(item.Key);       
            }

            Console.WriteLine("--Tutti gli esami di ogni facoltà:");
            Console.WriteLine(università[DIPARTIMENTI.FISICA][matricola1][0].Nome);
            Console.WriteLine(università[DIPARTIMENTI.MATEMATICA][matricola2][0].Nome);
            Console.WriteLine(università[DIPARTIMENTI.BIOLOGIA][matricola3][0].Nome);
            Console.WriteLine(università[DIPARTIMENTI.CHIMICA][matricola4][0].Nome);
            Console.WriteLine(università[DIPARTIMENTI.INFORMATICA][matricola5][0].Nome);

        }
    }
}


public class Matricola
{
    public string Nome { get; set; }
    public int numeroMatricola { get; set; }
    public Matricola(string nome, int numeroMatricola)
    {
        Nome = nome;
        this.numeroMatricola = numeroMatricola;
    }
}

public class Esame
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Voto { get; set; }
    public Esame(int id, string nome, int voto)
    {
        Id = id;
        Nome = nome;
        Voto = voto;
    }
}

public enum DIPARTIMENTI
{
    FISICA,
    MATEMATICA,
    BIOLOGIA,
    CHIMICA,
    INFORMATICA
}