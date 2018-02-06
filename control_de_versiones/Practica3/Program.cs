using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            string nom="No Name", dataNaixement="", nif="";
            char sexe='H';
            double pes=0, alçada = 0;
            Console.WriteLine("Entra Nom: ");
            nom = Console.ReadLine();
            p.DataNaixement = dataNaixement;
            dataNaixement = p.DataNaixement;
            //dataNaixement = entrarAño(dataNaixement);

            p.Nif=nif;//set
            nif = p.Nif;//get
            Console.WriteLine("Entra Sexe: ");
            try
            {p.Sexe = Convert.ToChar(Console.ReadLine()); }catch (Exception) {p.Sexe='h';}

            p.Pes = pes;
            pes = p.Pes;
           //introducirDouble("Entra Pes");


            p.Alçada = alçada;  //introducirDouble("Entra Alçada");
            alçada = p.Alçada;
           
            
            menu(nom,dataNaixement,nif,sexe,pes,alçada);
        }
        private static void menu(string nom, string dataNaixement, string nif, char sexe, double pes, double alçada)
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("Elige una Opcion:\n1.Prova 1\n2.Prova 2\n3.Prova 3\n4.Salir");
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception) { Console.WriteLine("Tipo de Valor no valido"); }
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        
                        prova1(nom, dataNaixement, nif, sexe, pes, alçada);
                        break;
                    case 2:
                        prova2(nom, dataNaixement, nif, sexe, pes, alçada);
                        break;
                    case 3:
                        prova3(nom, dataNaixement, nif, sexe, pes, alçada);
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            } while (opcion!=4);
            
        }
        private static void prova3(string nom, string dataNaixement, string nif, char sexe, double pes, double alçada)
        {
            Persona p3 = new Persona(nom, dataNaixement, nif, sexe, pes, alçada);

            //Utilitza els mètodes CalcularIMC, Edat, EsMajorDeEdat mostrant el resultat per consola. 
            Console.WriteLine("\nProbando Metodes");
            Console.WriteLine("Resultado: " + p3.calcularIMC());
            Console.WriteLine("Edad: " + p3.edat());
            Console.WriteLine(p3.esMajorEdat() ? "Es Mayor de Edad" : "No es Mayor de Edad");

            //Utilitza el mètode ToString per mostrar les dades de la persona. 
            Console.WriteLine("\nProbando ToString");
            Console.WriteLine(p3);
        }
        private static void prova2(string nom, string dataNaixement, string nif, char sexe, double pes, double alçada)
        {
            //Crea un objecte instanciant-lo amb el constructor que té els arguments de nom, data
            Persona p2 = new Persona(nom, dataNaixement, sexe);
            p2.Nif = nif;
            p2.Pes = pes;
            p2.Alçada = alçada;

            //Utilitza els mètodes CalcularIMC, Edat, EsMajorDeEdat mostrant el resultat per consola. 
            Console.WriteLine("\nProbando Metodes");
            Console.WriteLine("Resultado: " + p2.calcularIMC());
            Console.WriteLine("Edad: " + p2.edat());
            Console.WriteLine(p2.esMajorEdat() ? "Es Mayor de Edad" : "No es Mayor de Edad");

            //Utilitza el mètode ToString per mostrar les dades de la persona. 
            Console.WriteLine("\nProbando ToString");
            Console.WriteLine(p2);
        }
        private static void prova1(string nom, string dataNaixement, string nif, char sexe, double pes, double alçada)
        {
            //Crea un objecte instanciant-lo amb el constructor sense paràmetres i demana les dades de la
            // persona per consola.Cal assignar-les a l’objecte mitjançant les propietats. 
            Persona p1 = new Persona();
            p1.Nom = nom;
            p1.DataNaixement = dataNaixement;
            p1.Nif = nif;
            
            p1.Sexe = sexe;
            p1.Pes = pes;
            p1.Alçada = alçada;

            //Utilitza els mètodes CalcularIMC, Edat, EsMajorDeEdat mostrant el resultat per consola. 
            Console.WriteLine("\nProbando Metodes");
            Console.WriteLine("Resultado: " + p1.calcularIMC());
            Console.WriteLine("Edad: " + p1.edat());
            Console.WriteLine(p1.esMajorEdat() ? "Es Mayor de Edad" : "No es Mayor de Edad");

            //Utilitza el mètode ToString per mostrar les dades de la persona. 
            Console.WriteLine("\nProbando ToString");
            Console.WriteLine(p1);
        }
        #region OtrosMetodos
        
        
        


        #endregion

    }
}
