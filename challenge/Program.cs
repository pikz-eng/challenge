



using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Tipareste();
            int lungime = int.Parse(Console.ReadLine());

            int[] vectorElemente = new int[lungime];

            MesajPentruAdaugareElementeVector();
            AdaugaElementeVector(vectorElemente);

            AfisareMesajElementeIntroduseInVector();

            AfisareElementeDinVector(vectorElemente);
            SorteazaVectorCrescator(vectorElemente);
        }

        static void Tipareste()
        {
            string mesaj = "Introduceti lungimea vectorului  = ";

            Console.Write(mesaj);
        }
        static void MesajPentruAdaugareElementeVector()
        {
            string mesajElemente = "Introduceti elemente in vector : ";
            Console.WriteLine(mesajElemente);
        }

        static void AfisareMesajElementeIntroduseInVector()
        {
            string mesajRezultat = "Elementele introduse in vector sunt : ";
            Console.WriteLine(mesajRezultat);
        }

        static void AfisareMesajPentruVectorSortatCrescator()
        {
            string mesjVectorSortat = "Vectorul sortat crescator este : ";
            Console.Write(mesjVectorSortat);
        }
        static void AdaugaElementeVector(int[] vectorElemente)
        {

            for (int i = 0; i < vectorElemente.Length; i++)
            {
                vectorElemente[i] = int.Parse(Console.ReadLine());
            }

        }
        static void AfisareElementeDinVector(int[] vectorElemnte)
        {
            foreach (var elemente in vectorElemnte)
            {
                Console.WriteLine(elemente);
            }


        }
        /*sunt mai multe greseli
         1.vectorElemente.length - 1 este gresit punem ori -1 sa ne dea ultimul element ori ne folosim de metoda length
         2. nu trebuie sa punem <= doar < deoarece array ul incepe de la 0 si atunci ar merge in afara array ul (array ul are o dimensiune fixa)
         3. este  gresit sa comparam j < i deoarece ar merge in ordine descrescatoare doar ca iarasi iesim din array si ne arunca exceptia out of bound
        + ca era mai mic ar merge descrescator trebuie sa facem mai mare sa mergem crescator adica sa comparam elementul de pe pozitia 0 spre exemplu 
        cu cel de pe pozitia 1 daca cel de pozitia 0 este mai mare decat cel de pe pozitia 1 se face interschimbarea(mai explicit daca avem 10-8 atunci interschimbam  in 8-10)
         4. am facut si suma separat asta era problema si la tema mea:))   
         5.cand se printau vectorii cu for-ul de jos <= era folosit iarasi care din nou iesea din array
         */
        static void SorteazaVectorCrescator(int[] vectorElemnte)
        {
            int auxiliar;

            for (int i = 0; i < vectorElemnte.Length; i++)
            {
                for (int j = i + 1; j < vectorElemnte.Length; j++)
                {
                    if (vectorElemnte[i] > vectorElemnte[j])
                    {
                        auxiliar = vectorElemnte[i];
                        vectorElemnte[i] = vectorElemnte[j];
                        vectorElemnte[j] = auxiliar;
                    }

                }

            }
            AfisareMesajPentruVectorSortatCrescator();
            for (int i = 0; i < vectorElemnte.Length; i++)
            {
                Console.Write(vectorElemnte[i] + "");

            }

            int sum = 0;
            for (int i = 0; i < vectorElemnte.Length; i++)
            {
                sum += vectorElemnte[i];

            }

            Console.Write(" Suma elementelor este: " + sum);

        }
    }
}