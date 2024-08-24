using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefatorarObserver.Models
{
   public interface IObserver
    {
        void update(decimal percentual);
    }
}
