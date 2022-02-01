using System;

namespace prjConsCsChap123
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaration des variables
            double salaireT, tauxH, heureT, heureS;
            string nom;
            Console.WriteLine("\t COLLEGE TECCART");
            Console.Write("Entrez votre nom  ");
            nom = Console.ReadLine();
            Console.Write("Entrez votre taux horaire : ");
            tauxH = Convert.ToDouble(Console.ReadLine());
            Console.Write("Entrez le nombres d'heures supplementaires : ");
            heureT = Convert.ToDouble(Console.ReadLine());
            Console.Write("Entrez le nombre d'heures supplementaires : ");
            heureS = Convert.ToDouble(Console.ReadLine());
            salaireT = (tauxH * heureT) + (1.5 * tauxH) * heureS;
            Console.Write("Mme ou M. "+nom+" ,\n" +
                "Votre salaire hebdomadaire est "+(tauxH*heureT)+"\n" +
                "Votre salaire supplementaire est "+(1.5*tauxH)*heureS+"\n" +
                "Votre revenu total est "+salaireT);
            
        }
    }
}
