using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefatorarObserver.Models
{
    public interface ISubject
    {
        void add(IObserver observer);
        void remove(IObserver observer);
        void notify(decimal percentual);

    }
}
