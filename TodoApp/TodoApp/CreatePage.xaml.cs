using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TodoApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreatePage : ContentPage
    {
        public List<TodoItem> ToDoItems = new List<TodoItem>();
        public CreatePage()
        {
            InitializeComponent();
        }

        private void OnGuardar(object o,EventArgs e)
        {
            this.ToDoItems.Add(new TodoItem(ToDo.Text,
                Prioridad.Text,
                GetFechaFin(FechaFin.Date,
                HoraFin.Time.Hours,
                HoraFin.Time.Minutes,
                HoraFin.Time.Seconds),
                false
                ));

            Limpiar();
        }
        private DateTime GetFechaFin(DateTime fecha,int horas,int minutos,int segundos)
        {
            return new DateTime(
                fecha.Year, fecha.Month, fecha.Day,
                horas,minutos,segundos
                );
        }

        private void Limpiar()
        {
            ToDo.Text = string.Empty;
            Prioridad.Text = string.Empty;
            FechaFin.Date = DateTime.Now;
            HoraFin.Time = DateTime.Now.TimeOfDay;
        }
        private void OnCancelar(object o, EventArgs e)
        {

        }
        private void OnRevisar(object o, EventArgs e)
        {
            var items = ToDoItems;
            Navigation.PushAsync(new ListTasksPage());
        }
    }
}