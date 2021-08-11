using System;
using System.Collections.Generic;
using System.Text;

namespace Obserwator
{
  
        public interface IObserwowany
        {
            int jakasWlasciwosc { get; set; }

          void dodajObserwatora(IObserwator o);
            void usunObserwator(IObserwator o);
            void powiadomObserwatorow();
        }
    }

