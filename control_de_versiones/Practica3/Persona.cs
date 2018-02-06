using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    class Persona
    {
        //atributos
        private string nom="";
        private string dataNaixement="";
        private string nif="";
        private char sexe='H';
        private double pes = 0;
        private double alçada = 0;
        #region MetodosPublicos
        public string calcularIMC()
        {
            double resultat = pes / (Math.Pow(alçada,2));
            string cadena = "";
            if (resultat < 18)
                cadena = "Baix";
            if (resultat > 18 && resultat < 24.9)
                cadena = "Normal";
            else if (resultat > 25 && resultat < 26.9)
                cadena = "Sobrepes";
            else
                cadena = "Obes";
            return cadena;
        }
        public int edat() {
            DateTime fecha = DateTime.Now;
            int año = fecha.Year;
            int AñoNacimiento = Int32.Parse(dataNaixement.Split('/')[2]);
            return (año - AñoNacimiento);
        }
        public bool esMajorEdat() {
            return (edat()>18)?true:false;
        }
        //metods publicos mios
        public string entrarNif()
        {
            while (!nifCorrecte(nif))
            {
                Console.WriteLine("Entra Nif 11111111H: ");
                nif = Console.ReadLine();
                //nif = (nifCorrecte(nif)) ? nif : nif;
            }
            return nif;
        }
        public bool esHoD(char sexe)
        {
            bool trobat = false;
            if (sexe.ToString().ToUpper() == "H" || sexe.ToString().ToUpper() == "D")
            {
                trobat = true;
            }
            return trobat;
        }
        private string entrarAño(string dataNaixement)
        {
            bool trobat = false;
            DateTime fecha = DateTime.Now;
            int añoActual = fecha.Year;
            while (!trobat)
            {
                Console.WriteLine("Entra Data Naixement DD/MM/AAAA: ");
                dataNaixement = Console.ReadLine();
                string[] camposFecha = dataNaixement.Split('/');
                try
                {
                    
                    int dia = Int32.Parse(camposFecha[0]);
                    int mes = Int32.Parse(camposFecha[1]);
                    int año = Int32.Parse(camposFecha[2]);
                    int diasMes = DateTime.DaysInMonth(año, mes);
                    if (dia <= diasMes && mes < 13 && año <= añoActual)
                    {
                        trobat = true;
                    }
                }
                catch (Exception) { }

            }
            return dataNaixement;
        }
        private  double introducirDouble(string cadena)
        {
            double numero = -1;
            while (!(valorPositivo(numero)))
            {
                Console.WriteLine(cadena);
                try { numero = Convert.ToDouble(Console.ReadLine()); }
                catch (Exception) { }
            }
            return numero;
        }
        private static bool valorPositivo(double valor)
        {
            return (valor > 0) ? true : false;
        }
        #endregion
        #region Propietats
        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string DataNaixement
        {
            get
            {
                return dataNaixement;
            }

            set
            {
                if (value == "")
                    dataNaixement = entrarAño(value);
                else
                    dataNaixement = value;
            }
        }

        public string Nif
        {
            get
            {
                return nif;
            }

            set
            {
                if (nifCorrecte(value))
                    nif = value;
                else
                    entrarNif();
            }
        }

        public char Sexe
        {
            get
            {
                return sexe;
            }

            set
            {
                sexe = esHoD(value) ? value : 'H';
            }
        }

        public double Pes
        {
            get
            {
                return pes;
            }

            set
            {
                    pes = (value == 0)?introducirDouble("Entra Pes"): value;
            }
        }

        public double Alçada
        {
            get
            {
                return alçada;
            }

            set
            {
                alçada = (value == 0) ? introducirDouble("Entra Altura") : value; ;
            }
        }
        #endregion
        #region Contructores
        public Persona() {//constructor sin parametros
        }
        public Persona(string nif)
        {
            this.nif = (nifCorrecte(nif)) ? nif : "Nif Invalido";
        }
        public Persona(string nom, string dataNaixement, char sexe)
        {
            this.nom = nom;
            this.dataNaixement = dataNaixement;
            this.sexe = sexe;
        }
        public Persona(string nom, string dataNaixement, string nif, char sexe, double pes, double alçada) {
            this.nom = nom;
            this.dataNaixement = dataNaixement;
            this.nif = (nifCorrecte(nif)) ? nif : "Nif Invalido";
            this.sexe = sexe;
            this.pes = pes;
            this.alçada = alçada;
        }
        #endregion
        #region metodes privats
        private static bool nifCorrecte(string nif)
        {
            char lletra='.';
            bool trobat = false;
            int maxIndiceNif = nif.Length - 1;
            int numero = 0;
            try
            {
                numero = Int32.Parse(nif.Substring(0, maxIndiceNif));
                lletra = nif[maxIndiceNif].ToString().ToUpper()[0];
            }
            catch (Exception) {}
            return trobat = (lletraM(numero, lletra)) ? true : false; ;
        }

        static bool lletraM(int numero, char lletra)
        {
            string lletresDNI = "TRWAGMYFPDXBNJZSQVHLCKE";
            return (lletra == lletresDNI[numero % 23]) ? true : false;
        }
        


        #endregion
        #region override
        public override string ToString()
        {
            string cadena = "Datos de la Persona:" +
                "\nNom: " + nom +
                "\nData Naixement: " + dataNaixement +
                "\nNif: " + nif +
                "\nSexe: " + sexe +
                "\npes: " + pes +
                "\nalçada: " + alçada;

            return cadena;
        }
        #endregion
    }
}
