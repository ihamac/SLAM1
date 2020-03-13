using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Déclaration
            string[] prenom = new string[6];
            string unEleve = " ";

            //Saisie du nom de l'élève
            Saisir(prenom, unEleve);

            //Position
            positionEleve(prenom);
        }
        static void Saisir(string[] prenomEleve, string unEleve)
        {
            for (int i = 0; i < prenomEleve.Length; i++)
            {
                Console.WriteLine("Quel est le prénom à rechercher ?");
                Console.WriteLine("Saisissez le prenom à rechercher : {0}", prenomEleve[i]);
                prenomEleve[i] = Console.ReadLine();
            }
        }
        static int positionEleve(string[] lesEleves)
        {
            int position = -1;

            for (int i = 0; position < lesEleves.Length; i++)
            {
                position = position + 1;
            }
            return position;
        }
    }
}
