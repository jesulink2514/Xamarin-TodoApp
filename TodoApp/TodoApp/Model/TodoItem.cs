using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace TodoApp
{
    public class TodoItem
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string ToDo { get; set; }
        public string Prioridad { get; set; }
        public DateTime FechaFin { get; set; }//Aqui uniremos Date & Time
        public bool Eliminado { get; set; }

        public TodoItem()
        {
        }

        public TodoItem(string todo,String prioridad,DateTime fechaFin,bool eliminado)
        {
            ToDo = todo;
            Prioridad = prioridad;
            FechaFin = fechaFin;
            Eliminado = eliminado;
        }
    }
}
