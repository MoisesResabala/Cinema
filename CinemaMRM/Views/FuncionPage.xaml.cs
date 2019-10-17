using CinemaMRM.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CinemaMRM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FuncionPage : ContentPage
    {
        public FuncionPage()
        {
            InitializeComponent();
        }

        public FuncionPage(Cartelera cartelera)
        {
            InitializeComponent();
            LoadData(cartelera);

        }
        private void LoadData(Cartelera cartelera)
        {
            gridDatos.BindingContext = cartelera;
        }
    }
}