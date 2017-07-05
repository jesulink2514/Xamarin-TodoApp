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
    public partial class ListTasksPage : ContentPage
    {
        public string Nombre { get; set; }
        public ListTasksPage()
        {
            this.Nombre = "Jesus Angulo";
            this.BindingContext = this;
            InitializeComponent();
        }
    }
}