using System;
using System.Collections.Generic;

namespace Pracownicy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pracownik> pracownicy = new List<Pracownik>();
            string loginOsoby, hasloOsoby, nazwiskoOsoby, departamentOsoby;
            bool isWorker;
            
            pracownicy.Add(new Pracownik() { login = "kamnsk" , haslo = "password" , nazwisko = "Kamiński", department = "IT" });
            pracownicy.Add(new Pracownik() { login = "kulczyk" , haslo = "dolary$$$" , nazwisko = "Kulczyk", department = "HR" });
            
            foreach (Pracownik p in pracownicy)
                Console.WriteLine($"{p.nazwisko} ,który pracuje w {p.departament} ma login {p.login} i hasło {p.haslo} przechowywane jako jawny tekst, a co.");

            Console.Read(); 
        }

        class Osoba
        {
            public string login { get; set; }
            public string haslo { get; set;}
            public string nazwisko { get; set; }
        }

        class Pracownik : Osoba
        {   
            private string haslo 
            { 
                get; 
                set
                {
                    if (value.length >= 6) 
                        haslo.value = value;
                    else
                        throw (new Exception("Hasło ma długość:", value,"Hasło pracownika musi być dłuższe niż 6 znaków."));
                }
            }

            public string department { get; set; }

            // public Pracownik()
            // {
                
            // }
        }
    }
}