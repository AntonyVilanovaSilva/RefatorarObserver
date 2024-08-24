using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefatorarObserver.Models
{
    public class Produto :IObserver
    {
        [Column("Codigo")]
        public int Id { get; set; }

        [Column("Nome")]
        public string Name { get; set; }

        [Column("Preco")]
        public decimal Preco { get; set;}

        [Column("PermitirEmMassa")]
        public bool PermitirEmMassa { get; set;}

        public Produto(int id, string name, decimal preco)
        {
            Id = id;
            Name = name;
            Preco = preco;
        }
        public void update(decimal percentual)
        {
            Preco = Preco + (percentual * Preco) / 100;
            //Preco += (percentual * Preco) /100;

        }
    }
}








