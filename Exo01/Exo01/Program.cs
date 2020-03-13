using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdressageIP;

namespace Exo01
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCICE 1 
            //Déclaration 
            /*AdresseIP ip1, ip2, ip3;*/
            /*ip1 = new AdresseIP(0, 0, 0, 0);
            ip2 = new AdresseIP(128, 0, 0, 0);
            ip3 = new AdresseIP(192, 0, 0, 0);*/

            /*Afficher le contenu des 3 adresse sIP en utilisant les accesseurs Get
            Console.WriteLine("{0}.{1}.{2}.{3}",ip1.GetOctet1(),ip1.GetOctet2(),ip1.GetOctet3(),ip1.GetOctet4());
            Console.WriteLine("{0}.{1}.{2}.{3}", ip2.GetOctet1(), ip2.GetOctet2(), ip2.GetOctet3(), ip2.GetOctet4());
            Console.WriteLine("{0}.{1}.{2}.{3}", ip3.GetOctet1(), ip3.GetOctet2(), ip3.GetOctet3(), ip3.GetOctet4()); */

            /*Afficher le contenu des 3 adresses IP en utilisant la méthode ToString
            Console.WriteLine("{0}", ip1.ToString());
            Console.WriteLine("{0}", ip2.ToString());
            Console.WriteLine("{0}", ip3.ToString());   */      
            
            /*Affichage 3 objets avec leur classe + leur masque + adresse en binaire
            Console.WriteLine("{0} : Classe - {1} : {2} : {3}", ip1.ToString(), ip1.ClasseReseau(), ip1.Masque(), ip1.AdresseIpBinaire());
            Console.WriteLine("{0} : Classe - {1} : {2} : {3}", ip2.ToString(), ip2.ClasseReseau(), ip2.Masque(), ip2.AdresseIpBinaire());
            Console.WriteLine("{0} : Classe - {1} : {2} : {3}", ip3.ToString(), ip3.ClasseReseau(), ip3.Masque(), ip3.AdresseIpBinaire()); */


           //EXERCICE 2
           //Déclaration 
           /*AdresseIP ip1, ip2, ip3;
            ip1 = new AdresseIP(172, 10, 15, 17);
            ip2 = new AdresseIP(255, 255, 0, 0);
            ip3 = new AdresseIP(172, 10, 0, 0);

            //Affichage de l'adresse IP en binaire
            Console.WriteLine("{0}", ip1.AdresseIpBinaire());
            Console.WriteLine("{0}", ip2.AdresseIpBinaire());
            Console.WriteLine("{0}", ip3.AdresseIpBinaire());
            Console.ReadLine();*/

            //EXERCICE 3
            //Déclaration
            /*AdresseIP ip1,ip2;

            //Saisie de l'adresse IP en string
            Console.WriteLine("Saisissez une adresse IP : ");
            ip1 = new AdresseIP(Console.ReadLine());

            //Saisie de l'adresse Ip + Affichage octet par octet
            Console.WriteLine("Saisissez une seconde adresse IP : ");
            ip2 = new AdresseIP(Console.ReadLine());
            Console.WriteLine("Octet 1 = {0}", ip2.GetOctet1());
            Console.WriteLine("Octet 2 = {0}", ip2.GetOctet2());
            Console.WriteLine("Octet 3 = {0}", ip2.GetOctet3());
            Console.WriteLine("Octet 4 = {0}", ip2.GetOctet4());

            Console.ReadLine();*/
            
            //EXERCICE 4

            AdresseIP[] tableau = new AdresseIP[3];
            tableau[0] = new AdresseIP(0, 0, 0, 0);
            tableau[1] = new AdresseIP(128, 0, 0, 0);
            tableau[2] = new AdresseIP(192, 0, 0, 0);

            Console.WriteLine(""tableau[0].AdresseIpBinaireTableau());
            Console.WriteLine(tableau[1].AdresseIpBinaireTableau());
            Console.WriteLine(tableau[2].AdresseIpBinaireTableau());
            Console.ReadLine();
        }
    }
}
