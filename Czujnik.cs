using System;
using System.Collections.Generic;
using System.Text;

namespace Obserwator
{
    class Czujnik : IObserwowany
    {
        //lista obiektów, które będą obserwować obiekty tej klasy 
        private List<IObserwator> _listaObserwatorow = new List<IObserwator>();

        public int jakasWlasciwosc { get; set; }
        private int temperatura;

        public void dodajObserwatora(IObserwator o)
        {
            _listaObserwatorow.Add(o);
        }

        public void usunObserwator(IObserwator o)
        {
            _listaObserwatorow.Remove(o);
        }

        public void powiadomObserwatorow()
        {
            foreach (var item in _listaObserwatorow)
            {
                item.aktualizacjaDanych();
            }
        }

        public int pobierzTemperature()
        {
            return temperatura + 15;
        }

        public void dokonajPomiaru(int wartosc)
        {
            temperatura = wartosc;
        }
    }
}

