using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paulina_Kusmierz_48706
{
    class Program
    {
        static void Main(string[] args)
        {

            // dekleracja lokalna
            ConsoleKeyInfo WybranaFunkcjonalność;
            // wypisanie metryki programu
            Console.WriteLine("\n\n\tProgram PrototypProjektuNr1 umożliwia" +
                " wielokrotne obliczanie wybranych wielkości matematycznych ");
            // zapis wielokrotnego powtarzania obliczeń 
            do
            { //Wypisanie funkcjonalnego menu programu
                Console.WriteLine("\n\tFunkcjonalne menu programu: ");
                Console.WriteLine("\n\tA.  Obliczenie sumy (in-line)");
                Console.WriteLine("\n\tB.  Obliczenie sumy (method-line)");
                Console.WriteLine("\n\tC.  Obliczenie iloczynu (in-line)");
                Console.WriteLine("\n\tD.  Obliczenie iloczynu (method-call)");
                Console.WriteLine("\n\tE.  Obliczenie średniej arytmetycznej (in-line)");
                Console.WriteLine("\n\tF.  Obliczenie średniej arytmetycznej (method-line)");
                Console.WriteLine("\n\tG.  Obliczenie średniej ważonej (in-line)");
                Console.WriteLine("\n\tH.  Obliczenie średniej ważonej (method-call)");
                Console.WriteLine("\n\tI.  Obliczenie ceny jednostki paszy (in-line)");
                Console.WriteLine("\n\tJ.  Obliczenie ceny jednostki paszy (method-call)");
                Console.WriteLine("\n\tK.  Obliczenie średniej harmonicznej in-line)");
                Console.WriteLine("\n\tL.  Obliczenie średniej harmonicznej (method-call)");
                Console.WriteLine("\n\tM.  Obliczenie średniej geometrycznej (in-line)");
                Console.WriteLine("\n\tN.  Obliczenie średniej geometrycznej method-call)");
                Console.WriteLine("\n\tO.  Obliczenie średniej kwadratowej (in-line)");
                Console.WriteLine("\n\tP.  Obliczenie średniej kwadratowej (method-call)");
                Console.WriteLine("\n\tQ.  Obliczenie średniej potęgowej (in-line)");
                Console.WriteLine("\n\tR.  Obliczenie średniej potęgowej (method-call)");
                Console.WriteLine("\n\tX.  Zakończenie wyjście z programu");
                // Wypisanie informacji dla użytkownika: co ma teraz zrobić


                Console.Write("\n\tNaciśnij klawisz odpowiadający wymaganej funkcjonalności: ");
                // wczytanie wybranej funkcjonalności 
                WybranaFunkcjonalność = Console.ReadKey();

                // rozpoznać wybraną funkcjonalość i ją obsłużyć


                //obsługa funkcjonalności: A obliczenie sumy wyrazów ciągu  


                if (WybranaFunkcjonalność.Key == ConsoleKey.A)
                {
                    int pkn, pki;
                    double pka;
                    double pkSuma = 0.0;

                    Console.WriteLine("\n\n\t Witaj w programie do obliczania sumy");
                    //Pobranie od użytkownika z ilu liczb chciałbyś wyciągnąć sume
                    do
                    {//wpisz n 

                        Console.WriteLine("\n\n\t Wpisz z ilu liczb chciałbyś obliczyć sumę?");
                        while (!int.TryParse(Console.ReadLine(), out pkn))
                        { //sygnalizacja błedu 
                            Console.WriteLine("\n\n\tERROR wpisałeś nie coś źle");
                            //wpisz n ponownie

                            Console.WriteLine("\n\n\tPodaj ponownie lliość liczb które chcesz zsumować:");
                        }
                        if (pkn <= 1) // N<0 
                            Console.WriteLine("\n\n\tWartość n musi być > 1:");

                    } while (pkn <= 1);


                    for (pki = 0; pki < pkn; pki++)
                    {
                        //Pobranie od użytownika liczb z które chcesz zsumować 
                        Console.WriteLine("\n\n\tPodaj proszę {0} liczbę z której chciałbyś obliczyć sumę?", pki + 1);
                        while (!double.TryParse(Console.ReadLine(), out pka))
                        {//sygnalizacja błędy w zapisie a
                            Console.WriteLine("\n\n\tERROR: wystąpił niedozwolony znak w zapisie wartośći {0} ", pki);
                            //ponownie wpisz 
                            Console.WriteLine("Podaj ponownie {0} wartość wyrazu ciągu liczbowego", pki);
                        };

                        pkSuma += pka;
                    }

                    //Pokaz wynik
                    Console.WriteLine("\n\n\t Oto suma: ");
                    Console.WriteLine(pkSuma);

                    Console.ReadKey();

                }



                else
                    if (WybranaFunkcjonalność.Key == ConsoleKey.B)

                // obsługa funkcjonalności: B obliczenie sumy wyrazów ciągu 

                {
                    {
                        int pkn; //wczytanie n
                        pkn = pkWczytajIloscWyrazowDoSumowania();
                        double pkSuma;
                        pkSuma = pkSumaWyrazówCiąguLiczbowego(pkn);
                        //wypisanie wyniku obliczeń
                        Console.WriteLine("\n\n\tWYNIKI OBLICZEŃ: suma {0} wyrazów jest równa: {1}", pkn, pkSuma);
                        Console.ReadKey();
                    }


                    int pkWczytajIloscWyrazowDoSumowania()
                    {
                        int pkn;
                        //wczytanie n
                        do
                        {// wpisz n 
                            Console.WriteLine("\n\n\tPodaj liość wyrazów, które chcesz zsumować: ");
                            while (!int.TryParse(Console.ReadLine(), out pkn))
                            { //sygnalizacja błedu
                                Console.WriteLine("\n\n\tERROR wpisałeś nie coś źle");
                                //wpisz n ponownie

                                Console.WriteLine("\n\n\tPodaj ponownie lliość liczb które chcesz zsumować:");
                            }
                            if (pkn <= 1) // N<1
                                Console.WriteLine("\n\n\tWartość n musi być > 1:");

                        } while (pkn <= 1);

                        //zwrot wyniku
                        return pkn;
                    }

                    double pkSumaWyrazówCiąguLiczbowego(int pkn)
                    {
                        double pka, pkSuma = 0.0;
                        //sumowanie wyrazów ciągu
                        for (int pki = 1; pki <= pkn; pki++)
                        {//wycztanie wyrazów sumy 
                            Console.WriteLine("\n\n\tPodaj proszę {0} liczbę z której chciałbyś obliczyć sumę?", pki);
                            while (!double.TryParse(Console.ReadLine(), out pka))
                            {//sygnalizacja błędy w zapisie a
                                Console.WriteLine("\n\n\tERROR: wystąpił niedozwolony znak w zapisie wartośći {0} ", pki);
                                //ponownie wpisz 
                                Console.WriteLine("Podaj ponownie {0} wartość wyrazu ciągu liczbowego", pki);
                            };
                            //OK i dodajemy 

                            pkSuma = pkSuma += pka;
                        }
                        return pkSuma;


                    }
                }


                else
                if (WybranaFunkcjonalność.Key == ConsoleKey.C)
                {// obsługa funkcjonalności: C obliczenie sumy wyrazów ciągu 




                    int pka, pkn, pki;
                    double pkw = 1;


                    Console.WriteLine("\n\n\t Witaj w programie do obliczania iloczynu");
                    Console.WriteLine("\n\n\t Wpisz z ilu liczb chciałbyś obliczyć iloczyn?");
                    pkn = int.Parse(Console.ReadLine());

                    for (pki = 0; pki < pkn; pki++)
                    {

                        Console.WriteLine("\n\n\tPodaj proszę {0} liczbę z której chciałbyś obliczyć iloczyn?", pki + 1);
                        pka = int.Parse(Console.ReadLine());
                        pkw *= pka;
                    }

                    //Pokaz wynik
                    Console.WriteLine("\n\n\t Oto iloczyn: ");
                    Console.WriteLine(pkw);

                    Console.ReadKey();






                }
                else
                if (WybranaFunkcjonalność.Key == ConsoleKey.D)
                {
                    {




                        int pkn; //wczytanie n
                        pkn = pkWczytajIloscWyrazowDoIloczynowania();
                        double pkIloczyn;
                        pkIloczyn = pkIloczynWyrazówCiąguLiczbowego(pkn);
                        //wypisanie wyniku obliczeń
                        Console.WriteLine("\n\n\tWYNIKI OBLICZEŃ: Iloczyn {0} wyrazów jest równy: {1}", pkn, pkIloczyn);
                        Console.ReadKey();
                    }


                    int pkWczytajIloscWyrazowDoIloczynowania()
                    {
                        int pkn;
                        //wczytanie n
                        do
                        {// wpisz n 
                            Console.WriteLine("\n\n\tPodaj ilość wyrazów, których iloczyn chcesz wyznaczyć: ");
                            while (!int.TryParse(Console.ReadLine(), out pkn))
                            { //sygnalizacja błedu 
                                Console.WriteLine("\n\n\tERROR wpisano coś źle");
                                //wpisz n ponownie

                                Console.WriteLine("\n\n\tPodaj ponownie ilość liczb których iloczyn chcesz wyznaczyć:");
                            }
                            if (pkn <= 1) // N<1
                                Console.WriteLine("\n\n\tWartość n musi być > 1:");

                        } while (pkn <= 1);

                        //zwrot wyniku
                        return pkn;
                    }

                    double pkIloczynWyrazówCiąguLiczbowego(int pkn)
                    {
                        double a, Iloczyn = 1.0;
                        //sumowanie wyrazów ciągu
                        for (int pki = 1; pki <= pkn; pki++)
                        {//wycztanie wyrazów sumy 
                            Console.WriteLine("\n\n\tPodaj proszę {0} liczbę z której chciałbyś obliczyć iloczyn?", pki);
                            while (!double.TryParse(Console.ReadLine(), out a))
                            {//sygnalizacja błędy w zapisie a
                                Console.WriteLine("\n\n\tERROR: wystąpił niedozwolony znak w zapisie wartośći {0} ", pki);
                                //ponownie wpisz 
                                Console.WriteLine("Podaj ponownie {0} wartość wyrazu ciągu liczbowego", pki);
                            };
                            //OK i mnożymy 

                            Iloczyn = Iloczyn *= a;
                        }
                        return Iloczyn;


                    }
                }

                else
                if (WybranaFunkcjonalność.Key == ConsoleKey.E)

                {






                    int pka, pkn, pki;
                    double pkw = 0.0;

                    //Pobranie od użytkownika z ilu liczb chciałbyś wyciągnąć średnią arytmetyczną
                    Console.WriteLine("\n\n\t Witaj w programie do obliczania średniej arytmetycznej");
                    Console.WriteLine("\n\n\t Wpisz z ilu liczb chciałbyś wyciągnąć średnią arytmetyczną?");
                    pkn = int.Parse(Console.ReadLine());

                    for (pki = 0; pki < pkn; pki++)
                    {
                        //Pobranie od użytownika liczb z których chcesz wyciągnąć średnią arytmetyczną
                        Console.WriteLine("\n\n\tPodaj proszę {0} liczbę z której chcesz wyciągnąć średnią arytmetyczną", pki + 1);
                        pka = int.Parse(Console.ReadLine());
                        pkw += pka;
                    }

                    //Pokaz wynik
                    Console.WriteLine("\n\n\t Oto średnia arytmetyczna: ");
                    Console.WriteLine(pkw / pkn);

                    Console.ReadKey();







                }
                else
                if (WybranaFunkcjonalność.Key == ConsoleKey.F)
                {
                    {// obsługa funkcjonalności: F obliczenie sumy wyrazów ciągu 


                        int pkn; //wczytanie n
                        pkn = pkWczytajIloscWyrazowDoŚredniejArytmetycznej();
                        double pkŚredniaArytmetyczna;
                        pkŚredniaArytmetyczna = pkŚredniaArytmetycznaWyrazówCiąguLiczbowego(pkn);
                        //wypisanie wyniku obliczeń
                        Console.WriteLine("\n\n\tWYNIKI OBLICZEŃ: Średnia Arytmetyczna {0} wyrazów jest równy: {1}", pkn, pkŚredniaArytmetyczna);
                        Console.ReadKey();
                    }


                    int pkWczytajIloscWyrazowDoŚredniejArytmetycznej()
                    {
                        int pkn;
                        //wczytanie n
                        do
                        {// wpisz n 
                            Console.WriteLine("\n\n\tPodaj ilość wyrazów, których średnią arytmetyczną chcesz wyznaczyć: ");
                            while (!int.TryParse(Console.ReadLine(), out pkn))
                            { //sygnalizacja błedu 
                                Console.WriteLine("\n\n\tERROR wpisano coś źle");
                                //wpisz n ponownie

                                Console.WriteLine("\n\n\tPodaj ponownie ilość liczb których średnią arytmetyczną chcesz wyznaczyć:");
                            }
                            if (pkn <= 1) // N<0 
                                Console.WriteLine("\n\n\tWartość n musi być > 1:");

                        } while (pkn <= 1);

                        //zwrot wyniku
                        return pkn;
                    }

                    double pkŚredniaArytmetycznaWyrazówCiąguLiczbowego(int pkn)
                    {
                        double pka, pkŚredniaArytmetyczna = 0.0;
                        //sumowanie wyrazów ciągu
                        for (int pki = 1; pki <= pkn; pki++)
                        {//wycztanie wyrazów sumy 
                            Console.WriteLine("\n\n\tPodaj proszę {0} liczbę z której chciałbyś obliczyć średnią arytmetyczną?", pki);
                            while (!double.TryParse(Console.ReadLine(), out pka))
                            {//sygnalizacja błędy w zapisie a
                                Console.WriteLine("\n\n\tERROR: wystąpił niedozwolony znak w zapisie wartośći {0} ", pki);
                                //ponownie wpisz 
                                Console.WriteLine("Podaj ponownie {0} wartość wyrazu ciągu liczbowego", pki);
                            };
                            //OK zwraca średnią 

                            pkŚredniaArytmetyczna = (pkŚredniaArytmetyczna += pka);
                        }
                        return pkŚredniaArytmetyczna / pkn;


                    }


                }
                else
                if (WybranaFunkcjonalność.Key == ConsoleKey.G)
                {// obsługa funkcjonalności: G obliczenie sumy wyrazów ciągu 
                    {
                        int pkn;
                        double pka, pki, pkw;
                        double pklicznik = 0.0;
                        double pkmianownik = 0.0;



                    Start:

                        //Pobranie od użytkownika z ilu liczb chciałbyś wyciągnąć średnią ważoną
                        Console.WriteLine("\n\n\t Witaj w programie do obliczania średniej ważonej");
                        do
                        {//wpisz n 
                            Console.WriteLine("\n\n\t Wpisz z ilu liczb chciałbyś wyciągnąć średnią ważoną?");
                            while (!int.TryParse(Console.ReadLine(), out pkn))
                            { //sygnalizacja błedu 
                                Console.WriteLine("\n\n\tERROR wpisałeś nie coś źle");
                                //wpisz n ponownie

                                Console.WriteLine("\n\n\tPodaj ponownie z ilu liczb chciałbyś wyciągnąć średnią ważoną:");
                            }
                            if (pkn <= 1) // N<1
                                Console.WriteLine("\n\n\tWartość n musi być > 1:");

                        } while (pkn <= 1);

                        for (pki = 0; pki < pkn; pki++)
                        {
                            //Pobranie od użytownika liczb z których chcesz wyciągnąć średnią ważoną
                            Console.WriteLine("\n\n\tPodaj proszę {0} liczbę z której chcesz wyciągnąć średnią ważoną:", pki + 1);
                            while (!double.TryParse(Console.ReadLine(), out pka))
                            {//sygnalizacja błędy
                                Console.WriteLine("\n\n\tERROR: wystąpił niedozwolony znak w zapisie wartośći {0} ", pki);
                                //ponownie wpisz 
                                Console.WriteLine("Podaj ponownie {0} liczbę z której chcesz wyciągnąć średnią ważoną", pki);
                            };

                            do
                            {//wpisz n 

                                Console.WriteLine("\n\n\tPodaj wagę liczby {0} którą wpisałeś: ", pki + 1);
                                while (!double.TryParse(Console.ReadLine(), out pkw))
                                { //sygnalizacja błedu 
                                    Console.WriteLine("\n\n\tERROR wpisałeś nie coś źle");

                                    //wpisz n ponownie
                                    Console.WriteLine("\n\n\tPodaj ponownie wagę liczby :");
                                }
                                if (pkw < 0) // N<0 
                                    Console.WriteLine("\n\n\tWartość wagi musi być > 0:");

                            } while (pkw < 0);

                            pklicznik = pklicznik + pkw * pka;
                            pkmianownik = pkmianownik + pkw;


                        }

                        //Pokaz wynik
                        if (pkmianownik == 0)
                        {
                            Console.WriteLine("ERROR: suma wag nie może być równa 0");

                            Console.ReadKey();

                            goto Start;

                        }
                        else

                            Console.WriteLine("\n\n\t Oto średnia ważona: ");
                        Console.WriteLine(pklicznik / pkmianownik);
                        Console.ReadKey();
                        Console.Clear();

                    }



                }
                else
                if (WybranaFunkcjonalność.Key == ConsoleKey.H)
                {
                    {



                        int pkn; //wczytanie n
                        pkn = pkWczytajIloscWyrazowDoŚredniejWażonej();
                        double pkŚredniaWażona;
                        pkŚredniaWażona = pkŚredniaWażonaWyrazówCiąguLiczbowego(pkn);
                        //wypisanie wyniku obliczeń
                        Console.WriteLine("\n\n\tWYNIKI OBLICZEŃ: Średnia ważona {0} wyrazów jest równa: {1}", pkn, pkŚredniaWażona);
                        Console.ReadKey();
                    }



                    int pkWczytajIloscWyrazowDoŚredniejWażonej()
                    {



                        int pkn;
                        //wczytanie n
                        do
                        {// wpisz n 
                            Console.WriteLine("\n\n\tPodaj ilość wyrazów, których średnią ważoną chcesz wyznaczyć: ");
                            while (!int.TryParse(Console.ReadLine(), out pkn))
                            { //sygnalizacja błedu 
                                Console.WriteLine("\n\n\tERROR wpisano coś źle");
                                //wpisz n ponownie

                                Console.WriteLine("\n\n\tPodaj ponownie ilość liczb których średnią ważoną chcesz wyznaczyć:");
                            }
                            if (pkn <= 1) // N<1
                                Console.WriteLine("\n\n\tWartość n musi być > 1:");

                        } while (pkn <= 1);

                        //zwrot wyniku
                        return pkn;
                    }

                    double
                       pkŚredniaWażonaWyrazówCiąguLiczbowego(int pkn)
                    {
                        double pka, pkw, pkmianownik = 0.0, pklicznik = 0.0, pkŚredniaWażona = 0.0;
                    //sumowanie wyrazów ciągu

                    Start:

                        for (int pki = 1; pki <= pkn; pki++)
                        {//wycztanie  wyrazów sumy 
                            Console.WriteLine("\n\n\tPodaj proszę {0} liczbę z której chciałbyś obliczyć średnią ważoną?", pki);
                            while (!double.TryParse(Console.ReadLine(), out pka))
                            {//sygnalizacja błędy w zapisie a
                                Console.WriteLine("\n\n\tERROR: wystąpił niedozwolony znak w zapisie wartośći {0} ", pki);
                                //ponownie wpisz 
                                Console.WriteLine("Podaj ponownie {0} liczbę z której chciałbyś obliczyć średnią ważoną?", pki);
                            }


                            do
                            {
                                Console.WriteLine("\n\n\tPodaj proszę wagę {0} liczby z której chciałbyś obliczyć średnią ważoną?", pki);
                                while (!double.TryParse(Console.ReadLine(), out pkw))
                                {//sygnalizacja błędy w zapisie a
                                    Console.WriteLine("\n\n\tERROR: wystąpił niedozwolony znak w zapisie wagi {0} ", pki);
                                    //ponownie wpisz 
                                    Console.WriteLine("Podaj ponownie wagę {0} wyrazu ciągu liczbowego", pki);
                                }
                                if (pkw < 0.0) // N<0 
                                {
                                    Console.WriteLine("\n\n\tWartość wagi musi być > 0:", pki);
                                    Console.WriteLine("Podaj ponownie wagę {0}  wyrazu ciągu liczbowego", pki);
                                }


                            } while (pkw < 0.0);




                            pklicznik = pklicznik += pkw * pka;
                            pkmianownik = pkmianownik += pkw;


                        }


                        if (pkmianownik == 0.0)
                        {
                            Console.WriteLine("\n\n\tERROR suma wag nie może być równa 0 ");
                            goto Start;
                        }
                        else
                        {
                            pkŚredniaWażona = pklicznik / pkmianownik;

                            return pkŚredniaWażona;

                        }

                    }

                }
                else
                if (WybranaFunkcjonalność.Key == ConsoleKey.I)
                {// obsługa funkcjonalności: I obliczenie sumy wyrazów ciągu 

                    {

                        int pkn;
                        double pkc, pki, pkm;
                        double pklicznik = 0.0;
                        double pkmianownik = 0.0;



                    Start:

                        //Pobranie od użytkownika danych
                        Console.WriteLine("\n\n\t Witaj w programie do obliczania ceny paszy");
                        do
                        {//wpisz n 
                            Console.WriteLine("\n\n\t Podaj z ilu składników chcesz wyznaczyć cenę jednostki paszy");
                            while (!int.TryParse(Console.ReadLine(), out pkn))
                            { //sygnalizacja błedu 
                                Console.WriteLine("\n\n\tERROR wpisałeś coś źle");
                                //wpisz n ponownie

                                Console.WriteLine("\n\n\tPodaj ponownie z ilu składników chcesz wyznaczyć cenę jednostki paszy:");
                            }
                            if (pkn <= 0) // N<0 
                                Console.WriteLine("\n\n\tWartość ta musi być > 1:");

                        } while (pkn <= 0);

                        for (pki = 0; pki < pkn; pki++)
                        {
                            //Pobranie od użytownika danych o masie składników
                            do
                            {
                                Console.WriteLine("\n\n\tPodaj cenę {0} składnika paszy", pki + 1);
                                while (!double.TryParse(Console.ReadLine(), out pkc))
                                {//sygnalizacja błędy
                                    Console.WriteLine("\n\n\tERROR: wystąpił niedozwolony znak w zapisie wartośći {0} ", pki);
                                    //ponownie wpisz 
                                    Console.WriteLine(" Podaj ponownie cene {0}  składnika paszy", pki);
                                }
                                if (pkc <= 0)
                                    Console.WriteLine("\n\n\tWartość musi być > 0");
                            } while (pkc <= 0);

                            do
                            {//wpisz n 

                                Console.WriteLine("\n\n\tPodaj proszę masę {0} składnika paszy: ", pki + 1);
                                while (!double.TryParse(Console.ReadLine(), out pkm))
                                { //sygnalizacja błedu 
                                    Console.WriteLine("\n\n\tERROR wpisałeś nie coś źle");

                                    //wpisz n ponownie
                                    Console.WriteLine("\n\n\tPodaj ponownie masę składnika paszy  :");
                                }
                                if (pkm < 0) //m < 0 
                                    Console.WriteLine("\n\n\tWartość wagi musi być > 0:");

                            } while (pkm < 0);

                            pklicznik = pklicznik + pkm * pkc;
                            pkmianownik = pkmianownik + pkm;


                        }

                        //Pokaz wynik a jeśli masa paszy jest 0 to restartuj program 
                        if (pkmianownik == 0)
                        {
                            Console.WriteLine("ERROR: suma mas nie może być równa 0");

                            Console.ReadKey();

                            goto Start;

                        }
                        else

                            Console.WriteLine("\n\n\t Oto cena paszy: ");
                        Console.WriteLine(pklicznik / pkmianownik);
                        Console.ReadKey();
                        Console.Clear();

                    }



                }
                else
                if (WybranaFunkcjonalność.Key == ConsoleKey.J)
                {// obsługa funkcjonalności: J obliczenie sumy wyrazów ciągu 

                    {
                        {
                            {

                                // if (WybranaFunkcjonalność.Key == ConsoleKey.B) //method call

                                int pkn; //wczytanie n
                                pkn = pkWczytajIloscWyrazowMasyPaszy();
                                double pkMasaPaszy;
                                pkMasaPaszy = pkMasaPaszyWyrazówCiąguLiczbowego(pkn);
                                //wypisanie wyniku obliczeń
                                Console.WriteLine("\n\n\tWYNIKI OBLICZEŃ: Średnia ważona {0} wyrazów jest równa: {1}", pkn, pkMasaPaszy);
                                Console.ReadKey();
                            }



                            int pkWczytajIloscWyrazowMasyPaszy()
                            {



                                int pkn;
                                //wczytanie n
                                do
                                {// wpisz n 
                                    Console.WriteLine("\n\n\tPodaj z ilu składników chcesz wyznaczyć cenę jednostki paszy: ");
                                    while (!int.TryParse(Console.ReadLine(), out pkn))
                                    { //sygnalizacja błedu 
                                        Console.WriteLine("\n\n\tERROR wpisano coś źle");
                                        //wpisz n ponownie

                                        Console.WriteLine("\n\n\tPodaj ponownie z ilu składników chcesz wyznaczyć cenę jednostki paszy:");
                                    }
                                    if (pkn <= 1) // N<1
                                        Console.WriteLine("\n\n\ttWartość ta musi być > 1:");

                                } while (pkn <= 1);

                                //zwrot wyniku
                                return pkn;
                            }

                            double
                               pkMasaPaszyWyrazówCiąguLiczbowego(int pkn)
                            {
                                double pkc, pkm, pkmianownik = 0.0, pklicznik = 0.0, pkMasaPaszy = 0.0;
                            //sumowanie wyrazów ciągu

                            Start:

                                for (int pki = 1; pki <= pkn; pki++)
                                {//wycztanie  wyrazów sumy 
                                    do
                                    {
                                        Console.WriteLine("\n\n\tPodaj proszę cene {0} składnika paszy", pki);
                                        while (!double.TryParse(Console.ReadLine(), out pkc))
                                        {//sygnalizacja błędy w zapisie a
                                            Console.WriteLine("\n\n\tERROR: wystąpił niedozwolony znak w  zapisie składnika paszy {0} ", pki);
                                            //ponownie wpisz 
                                            Console.WriteLine("Podaj ponownie cene {0} składnika paszy", pki);
                                        }
                                        if (pkn <= 1) // N<1
                                            Console.WriteLine("\n\n\ttWartość ta musi być > 1:");

                                    } while (pkn <= 1);

                                    do
                                    {
                                        Console.WriteLine("\n\n\tPodaj proszę mase {0} składnika paszy", pki);
                                        while (!double.TryParse(Console.ReadLine(), out pkm))
                                        {//sygnalizacja błędy w zapisie a
                                            Console.WriteLine("\n\n\tERROR: wystąpił niedozwolony znak w zapisie masy {0} ", pki);
                                            //ponownie wpisz 
                                            Console.WriteLine("Podaj ponownie mase {0} składnika paszy", pki);
                                        }
                                        if (pkm < 0.0) // N<0 
                                        {
                                            Console.WriteLine("\n\n\tWartość masy musi być > 0:", pki);
                                            Console.WriteLine("Podaj ponownie mase {0}  wyrazu ciągu liczbowego", pki);
                                        }


                                    } while (pkm < 0.0);




                                    pklicznik = pklicznik += pkm * pkc;
                                    pkmianownik = pkmianownik += pkm;


                                }


                                if (pkmianownik == 0.0)
                                {
                                    Console.WriteLine("\n\n\tERROR suma mas nie może być równa 0 ");
                                    goto Start;
                                }
                                else
                                {
                                    pkMasaPaszy = pklicznik / pkmianownik;

                                    return pkMasaPaszy;

                                }

                            }

                        }
                    }


                }
                else
                if (WybranaFunkcjonalność.Key == ConsoleKey.K)
                {// obsługa funkcjonalności: K obliczenie sumy wyrazów ciągu 
                    {

                        float pka, pkn, pki;
                        double pkw = 0.0;
                        Console.WriteLine("\n\n\t Witaj w programie do obliczania średniej harmonicznej");
                        do
                        {// wpisz n 
                         //Pobranie od użytkownika z ilu liczb chciałbyś wyciągnąć średnią 

                            Console.WriteLine("\n\n\t Wpisz z ilu liczb chciałbyś wyciągnąć średnią harmoniczną?");
                            while (!float.TryParse(Console.ReadLine(), out pkn))
                            { //sygnalizacja błedu 'ojojojojo' złe n
                                Console.WriteLine("\n\n\tERROR wpisano coś źle");
                                //wpisz n ponownie

                                Console.WriteLine("\n\n\tPodaj ponownie ilość liczb których średnią harmoniczną chcesz wyznaczyć:");
                            }
                            if (pkn <= 1) // N<0 
                                Console.WriteLine("\n\n\tWartość n musi być > 1:");

                        } while (pkn <= 1);


                        for (pki = 0; pki < pkn; pki++)
                        {
                            //Pobranie od użytownika liczb z których chcesz wyciągnąć średnią 
                            Console.WriteLine("\n\n\tPodaj proszę {0} liczbę z której chcesz wyciągnąć średnią harmoniczną", pki + 1);
                            while (!float.TryParse(Console.ReadLine(), out pka))
                            {//sygnalizacja błędy w zapisie a
                                Console.WriteLine("\n\n\tERROR: wystąpił niedozwolony znak w zapisie wartośći {0} ", pki);
                                //ponownie wpisz 
                                Console.WriteLine("Podaj ponownie {0} wartość wyrazu ciągu liczbowego", pki);
                            };
                            pkw += (1 / pka);

                        }

                        //Pokaz wynik
                        Console.WriteLine("\n\n\t Oto średnia harmoniczną: ");
                        Console.WriteLine(pkn / pkw);

                        Console.ReadKey();



                    }
                }

                else
                if (WybranaFunkcjonalność.Key == ConsoleKey.L)
                {
                    {// obsługa funkcjonalności: L obliczenie sumy wyrazów ciągu 



                        int pkn; //wczytanie n
                        pkn = pkWczytajIloscWyrazowDoŚredniejHarmonicznej();
                        double pkŚredniaHarmoniczna;
                        pkŚredniaHarmoniczna = pkŚredniaHarmonicznaWyrazówCiąguLiczbowego(pkn);
                        //wypisanie wyniku obliczeń
                        Console.WriteLine("\n\n\tWYNIKI OBLICZEŃ: ŚredniaHarmoniczna {0} wyrazów jest równy: {1}", pkn, pkŚredniaHarmoniczna);
                        Console.ReadKey();
                    }


                    int pkWczytajIloscWyrazowDoŚredniejHarmonicznej()
                    {
                        int pkn;
                        //wczytanie n
                        do
                        {// wpisz n 
                            Console.WriteLine("\n\n\tPodaj ilość wyrazów, których średnią harmoniczną chcesz wyznaczyć: ");
                            while (!int.TryParse(Console.ReadLine(), out pkn))
                            { //sygnalizacja błedu 
                                Console.WriteLine("\n\n\tERROR wpisano coś źle");
                                //wpisz n ponownie

                                Console.WriteLine("\n\n\tPodaj ponownie ilość liczb których średnią harmoniczną chcesz wyznaczyć:");
                            }
                            if (pkn <= 1) // N<1
                                Console.WriteLine("\n\n\tWartość n musi być > 1:");

                        } while (pkn <= 1);

                        //zwrot wyniku
                        return pkn;
                    }

                    double pkŚredniaHarmonicznaWyrazówCiąguLiczbowego(int pkn)
                    {
                        double pka, pkŚredniaHarmoniczna = 0.0;
                        //sumowanie wyrazów ciągu
                        for (int pki = 1; pki <= pkn; pki++)
                        {//wycztanie wyrazów sumy 
                            Console.WriteLine("\n\n\tPodaj proszę {0} liczbę z której chciałbyś obliczyć średnią harmoniczną?", pki);
                            while (!double.TryParse(Console.ReadLine(), out pka))
                            {//sygnalizacja błędy w zapisie a
                                Console.WriteLine("\n\n\tERROR: wystąpił niedozwolony znak w zapisie wartośći {0} ", pki);
                                //ponownie wpisz 
                                Console.WriteLine("Podaj ponownie {0} liczbę z której chciałbyś obliczyć średnią harmoniczną?", pki);
                            };
                            //OK i mnożymy 

                            pkŚredniaHarmoniczna = (pkŚredniaHarmoniczna += (1 / pka));
                        }
                        return (pkn / pkŚredniaHarmoniczna);




                    }
                }



                else
                if (WybranaFunkcjonalność.Key == ConsoleKey.M)
                {// obsługa funkcjonalności: M obliczenie sumy wyrazów ciągu 





                    int pka, pkn, pki;
                    double pkw = 1;


                    Console.WriteLine("\n\n\t Witaj w programie do obliczania średniej geometrycznej");

                    do
                    {// wpisz n
                     //Pobranie od użytkownika z ilu liczb chciałbyś wyciągnąć średnią 

                        Console.WriteLine("\n\n\t Wpisz z ilu liczb chciałbyś wyciągnąć średnią geometryczną?");
                        while (!int.TryParse(Console.ReadLine(), out pkn))
                        { //sygnalizacja błedu 'ojojojojo' złe n
                            Console.WriteLine("\n\n\tERROR wpisano coś źle");
                            //wpisz n ponownie

                            Console.WriteLine("\n\n\tPodaj ponownie ilość liczb których średnią geometryczną chcesz wyznaczyć:");
                        }
                        if (pkn <= 1) // N<0 
                            Console.WriteLine("\n\n\tWartość n musi być > 1:");

                    } while (pkn <= 1);

                    for (pki = 0; pki < pkn; pki++)
                    {
                        //Pobranie od użytownika liczb z których chcesz wyciągnąć średnią 
                        Console.WriteLine("\n\n\tPodaj proszę {0} liczbę z której chcesz wyciągnąć średnią geometryczną", pki + 1);
                        while (!int.TryParse(Console.ReadLine(), out pka))
                        {//sygnalizacja błędy w zapisie a
                            Console.WriteLine("\n\n\tERROR: wystąpił niedozwolony znak w zapisie wartośći {0} ", pki);
                            //ponownie wpisz 
                            Console.WriteLine("Podaj ponownie {0} wartość wyrazu ciągu liczbowego", pki);
                        };
                        pkw *= pka;

                    }

                    //Pokaz wynik
                    Console.WriteLine("\n\n\t Oto średnia geometryczną: ");

                    Console.WriteLine(Math.Pow(pkw, 1.0 / pkn));

                    Console.ReadKey();



                }
                else
                if (WybranaFunkcjonalność.Key == ConsoleKey.N)
                {// obsługa funkcjonalności: N obliczenie sumy wyrazów ciągu 


                    {


                        int pkn; //wczytanie n
                        pkn = pkWczytajIloscWyrazowDoŚredniejGeometrycznej();
                        double pkŚredniaGeometryczna;
                        pkŚredniaGeometryczna = pkŚredniaGeometrycznaWyrazówCiąguLiczbowego(pkn);
                        //wypisanie wyniku obliczeń
                        Console.WriteLine("\n\n\tWYNIKI OBLICZEŃ: Średnia Geometryczna {0} wyrazów jest równa: {1}", pkn, pkŚredniaGeometryczna);
                        Console.ReadKey();
                    }


                    int pkWczytajIloscWyrazowDoŚredniejGeometrycznej()
                    {
                        int pkn;
                        //wczytanie n
                        do
                        {// wpisz n 
                            Console.WriteLine("\n\n\tPodaj ilość wyrazów, których średnią geometryczną chcesz wyznaczyć: ");
                            while (!int.TryParse(Console.ReadLine(), out pkn))
                            { //sygnalizacja błedu 
                                Console.WriteLine("\n\n\tERROR wpisano coś źle");
                                //wpisz n ponownie

                                Console.WriteLine("\n\n\tPodaj ponownie ilość liczb których średnią geometryczną chcesz wyznaczyć:");
                            }
                            if (pkn <= 1) // N<1
                                Console.WriteLine("\n\n\tWartość n musi być > 1:");

                        } while (pkn <= 1);

                        //zwrot wyniku
                        return pkn;
                    }

                    double pkŚredniaGeometrycznaWyrazówCiąguLiczbowego(int pkn)
                    {
                        double pka, pkŚredniaGeometryczna = 1.0;
                        //sumowanie wyrazów ciągu
                        for (int pki = 1; pki <= pkn; pki++)
                        {//wycztanie wyrazów sumy 
                            Console.WriteLine("\n\n\tPodaj proszę {0} liczbę z której chciałbyś obliczyć średnią geometryczną?", pki);
                            while (!double.TryParse(Console.ReadLine(), out pka))
                            {//sygnalizacja błędy w zapisie a
                                Console.WriteLine("\n\n\tERROR: wystąpił niedozwolony znak w zapisie wartośći {0} ", pki);
                                //ponownie wpisz 
                                Console.WriteLine("Podaj ponownie {0} wartość wyrazu ciągu liczbowego", pki);
                            };
                            //OK i mnożymy 

                            pkŚredniaGeometryczna = (pkŚredniaGeometryczna * pka);
                        }
                        return (Math.Pow(pkŚredniaGeometryczna, 1.0 / pkn));





                    }





                }
                else
                if (WybranaFunkcjonalność.Key == ConsoleKey.O)
                {// obsługa funkcjonalności: O obliczenie sumy wyrazów ciągu 



                    int pka, pkn, pki;
                    double pkw = 0;

                    Console.WriteLine("\n\n\t Witaj w programie do obliczania średniej kwadratowa");

                    //Pobranie od użytkownika z ilu liczb chciałbyś wyciągnąć średnią 
                    do
                    {
                        Console.WriteLine("\n\n\t Wpisz z ilu liczb chciałbyś wyciągnąć średnią kwadratową?");
                        while (!int.TryParse(Console.ReadLine(), out pkn))
                        { //sygnalizacja błedu 
                            Console.WriteLine("\n\n\tERROR wpisano coś źle");
                            //wpisz n ponownie

                            Console.WriteLine("\n\n\tPodaj ponownie ilość liczb których średnią kwadratową chcesz wyznaczyć:");
                        }
                        if (pkn <= 1) // N<0 
                            Console.WriteLine("\n\n\tWartość n musi być > 1:");

                    } while (pkn <= 1);


                    for (pki = 0; pki < pkn; pki++)
                    {
                        //Pobranie od użytownika liczb z których chcesz wyciągnąć średnią 
                        Console.WriteLine("\n\n\tPodaj proszę {0} liczbę z której chcesz wyciągnąć średnią kwadratową", pki + 1);
                        while (!int.TryParse(Console.ReadLine(), out pka))
                        {//sygnalizacja błędy w zapisie a
                            Console.WriteLine("\n\n\tERROR: wystąpił niedozwolony znak w zapisie wartośći {0} ", pki);
                            //ponownie wpisz 
                            Console.WriteLine("Podaj ponownie {0} wartość wyrazu ciągu liczbowego", pki);
                        };
                        pkw += Math.Pow(pka, 2);

                    }

                    //Pokaz wynik
                    Console.WriteLine("\n\n\t Oto średnia kwadratowa: ");

                    Console.WriteLine(pkw);
                    Console.WriteLine(Math.Sqrt(pkw / pkn));

                    Console.ReadKey();





                }
                else
                if (WybranaFunkcjonalność.Key == ConsoleKey.P)
                {// obsługa funkcjonalności: P obliczenie sumy wyrazów ciągu 
                    {



                        int pkn;
                        //wczytanie n

                        pkn = pkWczytajIloscWyrazowDoŚredniejKwadratowej();

                        double pkŚredniaKwadratowa;
                        pkŚredniaKwadratowa = pkŚredniaKwadratowaWyrazówCiąguLiczbowego(pkn);
                        //wypisanie wyniku obliczeń
                        Console.WriteLine("\n\n\tWYNIKI OBLICZEŃ: ŚredniaKwadratowa{0} wyrazów jest równa: {1}", pkn, pkŚredniaKwadratowa);
                        Console.ReadKey();
                    }


                    int pkWczytajIloscWyrazowDoŚredniejKwadratowej()
                    {
                        int pkn;
                        //wczytanie n
                        do
                        {// wpisz n 
                            Console.WriteLine("\n\n\tPodaj ilość wyrazów, których średnią kwadratową chcesz wyznaczyć: ");
                            while (!int.TryParse(Console.ReadLine(), out pkn))
                            { //sygnalizacja błedu 
                                Console.WriteLine("\n\n\tERROR wpisano coś źle");
                                //wpisz n ponownie

                                Console.WriteLine("\n\n\tPodaj ponownie ilość liczb których średnią kwadratową chcesz wyznaczyć:");
                            }
                            if (pkn <= 1) // N<1
                                Console.WriteLine("\n\n\tWartość n musi być > 1:");

                        } while (pkn <= 1);



                        //zwrot wyniku
                        return pkn;
                    }






                    double pkŚredniaKwadratowaWyrazówCiąguLiczbowego(int pkn)
                    {
                        double pka, pkŚredniaKwadratowa = 0.0;
                        //sumowanie wyrazów ciągu
                        for (int pki = 1; pki <= pkn; pki++)
                        {//wycztanie wyrazów sumy 
                            Console.WriteLine("\n\n\tPodaj proszę {0} liczbę z której chciałbyś obliczyć średnią kwadratową?", pki);
                            while (!double.TryParse(Console.ReadLine(), out pka))
                            {//sygnalizacja błędy w zapisie a
                                Console.WriteLine("\n\n\tERROR: wystąpił niedozwolony znak w zapisie wartośći {0} ", pki);
                                //ponownie wpisz 
                                Console.WriteLine("Podaj ponownie {0} wartość wyrazu ciągu liczbowego", pki);

                            };


                            pkŚredniaKwadratowa += Math.Pow(pka, 2);
                        }
                        return (Math.Sqrt(pkŚredniaKwadratowa / pkn));




                    }



                }
                else
                if (WybranaFunkcjonalność.Key == ConsoleKey.Q)
                {// obsługa funkcjonalności: Q obliczenie sumy wyrazów ciągu 

                    {

                        int pkn, pkk;
                        double pka, pki;
                        double pkŚredniaPotęgowa = 0.0;

                        //Pobranie od użytkownika z ilu liczb chciałbyś wyciągnąć średnią 
                        Console.WriteLine("\n\n\t Witaj w programie do obliczania średniej potęgowej");

                        do
                        {// wpisz n 

                            Console.WriteLine("\n\n\t Wpisz z ilu liczb chciałbyś wyciągnąć średnią potęgową?");
                            while (!int.TryParse(Console.ReadLine(), out pkn))
                            { //sygnalizacja błedu 
                                Console.WriteLine("\n\n\tERROR podana wartość nie jest liczbą");
                                //wpisz n ponownie

                                Console.WriteLine("\n\n\tPodaj ponownie ilość liczb których średnią potęgową chcesz wyznaczyć:");
                            }
                            if (pkn <= 1) // N<1
                                Console.WriteLine("\n\n\tWartość n musi być > 1:");

                        } while (pkn <= 1);



                        do
                        {// wpisz k
                            Console.WriteLine("\n\n\tPodaj rząd potęgi: ");
                            while (!int.TryParse(Console.ReadLine(), out pkk))
                            { //sygnalizacja błedu 
                                Console.WriteLine("\n\n\tERROR: Podana wartość nie jest liczbą całkowitą");
                                //wpisz n ponownie

                                Console.WriteLine("\n\n\tPodaj ponownie rząd potęgi, której średnią potęgową chcesz wyznaczyć:");
                            }
                            if (pkk < 1) // k<0 
                                Console.WriteLine("\n\n\tWartość k musi być większa lub równa 1:");

                        } while (pkk < 1);



                        for (pki = 0; pki < pkn; pki++)
                        {
                            //Pobranie od użytownika liczb z których chcesz wyciągnąć średnią 
                            Console.WriteLine("\n\n\tPodaj proszę {0} liczbę z której chcesz wyciągnąć średnią potęgową ", pki + 1);
                            while (!double.TryParse(Console.ReadLine(), out pka))
                            {//sygnalizacja błędy w zapisie a
                                Console.WriteLine("\n\n\tERROR: wystąpił niedozwolony znak w zapisie wartośći {0} ", pki);
                                //ponownie wpisz 
                                Console.WriteLine("Podaj ponownie {0} wartość wyrazu ciągu liczbowego", pki);
                            };

                            pkŚredniaPotęgowa += Math.Pow(pka, pkk);

                        }

                        //Pokaz wynik
                        Console.WriteLine("\n\tŚrednia Potęgowa: ");
                        Console.WriteLine(Math.Pow(pkŚredniaPotęgowa / pkn, 1.0 / pkk));

                        Console.ReadKey();






                    }





                }
                else
                if (WybranaFunkcjonalność.Key == ConsoleKey.R)
                {// obsługa funkcjonalności: I obliczenie sumy wyrazów ciągu 
                    {


                        {



                            int pkn, pkk;
                            //wczytanie n i k

                            pkn = pkWczytajIloscWyrazowDoŚredniejPotegowej();

                            pkk = pkWczytajRzadPotegi();

                            double pkŚredniaPotegowa;

                            pkŚredniaPotegowa = pkŚredniaPotegowaWyrazówCiąguLiczbowego(pkn, pkk);

                            //wypisanie wyniku obliczeń
                            Console.WriteLine("\n\n\tWYNIKI OBLICZEŃ: Średnia Potegowa {0} wyrazów jest równa: {1}", pkn, pkŚredniaPotegowa);
                            Console.ReadKey();
                        }


                        int pkWczytajIloscWyrazowDoŚredniejPotegowej()
                        {
                            int pkn;
                            //wczytanie n
                            do
                            {// wpisz n 
                                Console.WriteLine("\n\n\tPodaj ilość wyrazów, których średnią potęgową chcesz wyznaczyć: ");
                                while (!int.TryParse(Console.ReadLine(), out pkn))
                                { //sygnalizacja błedu 
                                    Console.WriteLine("\n\n\tERROR: Podana wartość nie jest liczbą całkowitą");
                                    //wpisz n ponownie

                                    Console.WriteLine("\n\n\tPodaj ponownie ilość liczb, których średnią potęgową chcesz wyznaczyć:");
                                }
                                if (pkn <= 1) // N<0 
                                    Console.WriteLine("\n\n\tWartość n musi być > 1:");

                            } while (pkn <= 1);



                            //zwrot wyniku
                            return pkn;
                        }


                        int pkWczytajRzadPotegi()

                        {
                            int pkk;
                            //wczytanie k
                            do
                            {// wpisz k
                                Console.WriteLine("\n\n\tPodaj rząd potęgi: ");
                                while (!int.TryParse(Console.ReadLine(), out pkk))
                                { //sygnalizacja błedu 
                                    Console.WriteLine("\n\n\tERROR: Podana wartość nie jest liczbą całkowitą");
                                    //wpisz n ponownie

                                    Console.WriteLine("\n\n\tPodaj ponownie rząd potęgi, której średnią potęgową chcesz wyznaczyć:");
                                }
                                if (pkk < 1) // k<1
                                    Console.WriteLine("\n\n\tWartość k musi być większa lub równa 1:");

                            } while (pkk < 1);
                            return pkk;
                        }



                        double pkŚredniaPotegowaWyrazówCiąguLiczbowego(int pkn, int pkk)

                        {
                            double pka, pkŚredniaPotegowa = 0.0;
                            //sumowanie wyrazów ciągu

                            for (int pki = 1; pki <= pkn; pki++)
                            {//wycztanie wyrazów sumy 
                                Console.WriteLine("\n\n\tPodaj {0} liczbę z której chciałbyś obliczyć średnią potęgowa?", pki);
                                while (!double.TryParse(Console.ReadLine(), out pka))
                                {//sygnalizacja błędy w zapisie a
                                    Console.WriteLine("\n\n\tERROR: wystąpił niedozwolony znak w zapisie wartośći {0} ", pki);
                                    //ponownie wpisz 
                                    Console.WriteLine("Podaj ponownie {0} wartość wyrazu ciągu liczbowego", pki);

                                };

                                pkŚredniaPotegowa = pkŚredniaPotegowa += Math.Pow(pka, pkk);
                            }

                            return Math.Pow(pkŚredniaPotegowa / pkn, 1.0 / pkk);

                            //return Math.Pow((ŚredniaPotegowa/n),(1/k));


                        }



                    }



                }
                else
                if (WybranaFunkcjonalność.Key != ConsoleKey.E)
                {// sygnalizacja błędy
                    Console.WriteLine("\n\tERROR: nacisnąłeś klawisz, który nie odpowiada żadnej z moich funkcjonalności");
                    Console.WriteLine("Wybierz ponownie wymaganą funkcjonalność");

                    //chwilowe zatrzymanie programu

                    Console.WriteLine("\n\tDla kontynuacji programu naciśnij dowolony klawisz. . .");
                    Console.ReadKey();

                }
            } while (WybranaFunkcjonalność.Key != ConsoleKey.X);
            // nacisnął klawisz z literą Z



            //wypisanie danych o autorze programu

            Console.WriteLine("\n\tAutor Programu: Paulina Kuśmierz, Grupa 1 - sobota");
            //chwilowe zatrzymanie programu
            Console.WriteLine("\n\tDla zakończenia programu naciśnij dowolony klawisz. . .");
            Console.ReadKey();






        }
    }
}
