using System;

namespace prjConsCs2Chap123
{
    class Program
    {
        static void Main(string[] args)
        {
            double miS, examF, projetF, moyenne;
            string nom;
            Console.WriteLine("\t COLLEGE TECCART");
            Console.Write("Entrez votre nom  ");
            nom = Console.ReadLine();
            Console.Write("Entrez vos notes suivantes  ");
            Console.Write("Examen Mi-session(25%) : ");
            miS = Convert.ToDouble(Console.ReadLine());
            Console.Write("Examen Final(40%) : : ");
            examF = Convert.ToDouble(Console.ReadLine());
            Console.Write("Examen final(35%) : ");
            projetF = Convert.ToDouble(Console.ReadLine());
            moyenne = (((25 * miS) + (40 * examF) * (35*projetF))/100)/3;
            Console.Write(
                "Merci..t \n" + 
                "Mme ou M. " + nom + " ,\n" +
                "Avec les notes suivantes (" +miS+", "+examF+", "+ projetF+")\n" +
                "Votre moyenne generale est " + moyenne);
        }
    }
}
