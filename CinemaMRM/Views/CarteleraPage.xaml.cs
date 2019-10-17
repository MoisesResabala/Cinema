using CinemaMRM.Domain;
using CinemaMRM.Services;
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
    public partial class CarteleraPage : ContentPage
    {
        public CarteleraPage()
        {
            InitializeComponent();
            var cartelera = CarteleraService.GetCartelera();
             lsCartelera.BindingContext = CarteleraService.GetCartelera();
        }
        // private void LoadCartelera()
        //{
        //   var carteleraList = new List<Cartelera>
        // {
        //     new Cartelera { Nombre= "Juan Perez", FechaEstreno="juan@gmail.com", Genero = "juanpa", Recomendacion = "3045568990", Duracion= "juanpm", ImageUrl="login.png" },

        //   };
        // lsCartelera.ItemsSource = carteleraList;


        //}

        private async void Cartelera_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            var carteleraSelected = (Cartelera)e.SelectedItem;
            await Navigation.PushAsync(new FuncionPage(carteleraSelected));
        }
    }
}