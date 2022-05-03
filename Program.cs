using System;

namespace exercitiiLaborator2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            Ex3();
        }
        static void Ex1()
        {
            //Scrieti un program care va afisa factorialul unui numar n, n fiind citit
            //de la tastatura.
            Console.WriteLine("Introduceti un numar ");
            int numar = int.Parse(Console.ReadLine());
            if (numar < 0)
            {
                Console.WriteLine("Fara nuere negative!");
                return;
            }
            if (numar == 0 || numar == 1)
            {
                Console.WriteLine("Factorialul numarului introdus este 1.");
                return;
            }
            int n = numar;
            decimal numarFactorial = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (i == 0)
                {
                    numarFactorial = numar * (numar - 1);
                    numar = numar - 2;
                    continue;
                }
                numarFactorial *= numar;
                numar--;
            }
            Console.WriteLine("Factorialul numarului introdus este " + numarFactorial);
        }
        static void Ex2()
        {
            //Să se scrie un program care citeşte de la tastatură un şir de numere
            //naturale şi determină media aritmetică a celor pare.
            Console.WriteLine("Introduceti un sir de numere de maxim 3 cifre, despartite de spatiu.");
            string numere = (Console.ReadLine());
            string cifrePlusSpatiu = "01234 56789";
            for (int i = 0; i < numere.Length; i++)
            {
                if (cifrePlusSpatiu.Contains(numere[i]))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Introduceti doar numere pozitive! Nu introduceti litere sau alte caractere!");
                    return;
                }
            }
            int numerotareCifre = 0;
            for (int i = 0; i < numere.Length; i++)
            {
                if (numere[i]!=' ')
                {
                    numerotareCifre++;
                }
                if (numerotareCifre>3)
                {
                    Console.WriteLine("Introduceti numere de cel mult 3 cifre!");
                    return;
                }
                if (numere[i]==' ')
                {
                    numerotareCifre = 0;
                }
            }
            int suma = 0;
            int counter = 0;
            int medieAritmetica;
            for (int i = 0; i < numere.Length; i++)
            {
                if (numere[i]==' ')
                {
                    continue;
                }
                else if (i== numere.Length-1 && numere[i]!=' ')
                {
                    int numarSir = int.Parse(numere[i].ToString());
                    if (numarSir == 0)
                    {
                        Console.WriteLine("Introduceti doar numere pozitive!");
                        return;
                    }
                    if (numarSir % 2 == 0)
                    {
                        suma += numarSir;
                        counter++;
                    }
                }
                else if (i < numere.Length - 1 && numere[i+1]==' ' || i + 1 >= numere.Length)
                {
                    int numarSir = int.Parse(numere[i].ToString());
                    if (numarSir==0)
                    {
                        Console.WriteLine("Introduceti doar numere pozitive!");
                        return;
                    }
                    if (numarSir%2==0)
                    {
                        suma += numarSir;
                        counter++;
                    }
                }
                else if (i < numere.Length - 2 && numere[i+2]==' '|| i+2>= numere.Length)
                {
                    string sirTemporar = numere[i].ToString() + numere[i + 1].ToString();
                    int numarSir = int.Parse(sirTemporar);
                    if (numarSir % 2 == 0)
                    {
                        suma += numarSir;
                        counter++;
                        i = i + 1;
                    }
                    else
                    {
                        i = i + 1;
                    }
                }
                else if (i < numere.Length - 2 && numere[i+2]!=' ' || i + 2 >= numere.Length)
                {
                    string sirTemporar = numere[i].ToString() + numere[i + 1].ToString()+ numere[i+2].ToString();
                    int numarSir = int.Parse(sirTemporar);
                    if (numarSir % 2 == 0)
                    {
                        suma += numarSir;
                        counter++;
                        i = i + 2;
                    }
                    else
                    {
                        i = i + 2;
                    }
                }
            }
            if (counter<2)
            {
                Console.WriteLine("Nu au fost introduse cel putin 2 numere pare.");
                return;
            }
            medieAritmetica = suma / counter;
            Console.WriteLine("Media aritmetica a numerelor pare introduse este " + medieAritmetica);
        }
        static void Ex3()
        {
            //Scrieti un program care va determina daca un numar este sau nu
            //palindrom
            Console.WriteLine("Introduceti un numar.");
            int numar = int.Parse(Console.ReadLine());
            string sirNumar = numar.ToString();
            string intors = "";
            for (int i = sirNumar.Length-1; i >= 0; i--)
            {
                intors = intors + sirNumar[i];
            }
            if (sirNumar==intors)
            {
                Console.WriteLine("Numarul introdus este un palindrom.");
            }
            else
            {
                Console.WriteLine("Numarul introdus NU este un palindrom.");
            }
        }

    }
}
