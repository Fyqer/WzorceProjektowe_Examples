using System;

namespace Obserwator
{
    class Program
    {
        static void Main(string[] args)
        {
            //tworzymy obiekt klasy Czujnik
            Czujnik czujnikNumerDwa = new Czujnik();

            //dodajemy obiekty zainteresowane odczytem z obiektu czujnikNumerDwa
            Urzadzenie urzadzenie1 = new Urzadzenie(czujnikNumerDwa);
            Urzadzenie urzadzenie2 = new Urzadzenie(czujnikNumerDwa);

            czujnikNumerDwa.dodajObserwatora(urzadzenie1);
            czujnikNumerDwa.dodajObserwatora(urzadzenie2);

            //odczytujemy temperature
            czujnikNumerDwa.dokonajPomiaru(22);

            //zaszla zmiana, wiec powiadamy obserwatorow
            czujnikNumerDwa.powiadomObserwatorow();

            //zalozmy ze jeden z obserwatorow nie jest juz zainteresowany temperatura
            czujnikNumerDwa.usunObserwator(urzadzenie1);

            //odczytujemy temperature
            czujnikNumerDwa.dokonajPomiaru(12);

            //zaszla zmiana, wiec powiadamy obserwatorow
            czujnikNumerDwa.powiadomObserwatorow();


            Console.ReadLine();
        }
    }
    }

