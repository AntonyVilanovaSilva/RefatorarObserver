using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefatorarObserver.Models
{
    public class AumentarPreco : ISubject
    {
        private List<IObserver> _observers;

        public AumentarPreco() 
        { 
          _observers = new List<IObserver>();
        }
        public void add(IObserver observer)
        {
           _observers.Add(observer);
        }

        public void notify(decimal percentual)
        {
            foreach (IObserver observer in _observers)
            {
                observer.update(percentual);
            }
        }

        public void AplicarAumento(decimal percentual)
        {
            //Salvar no banco...
            notify(percentual);
        }


        public void remove(IObserver observer)
        {
            _observers.Remove(observer);
        }
    }
}
