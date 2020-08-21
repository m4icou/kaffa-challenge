using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio5.Models
{
    public class Todo
    {
        //This project was made using the MVC standart, and connect with a localDb using Entity Framework.
        //Here are some relevant properties for the Todo List
        public int Id { get; set; }
        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Data Limite")]
        [DataType(DataType.Date)]
        public DateTime DataEntrega { get; set; }

        public bool Concluido { get; set; }
    }
}
