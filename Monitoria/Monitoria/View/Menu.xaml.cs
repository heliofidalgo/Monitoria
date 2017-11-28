
using System;
using Monitoria.Model;
using Monitoria.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Monitoria.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();

            //importando e reconhecendo as bindings no MenuViewmodel com o Menu da View 
            BindingContext = new MenuViewModel();
        }

        private void SelecionaItem(object sender, SelectedItemChangedEventArgs e)
        {
            // cria a vairavel que vai aguardar o evento do MenuLista e gravando o Cast
            var menu =(MenuLista) e.SelectedItem;

            // passou para ele a referencia da outra pagina
            Type pagina = menu.Pagina;

            // navegação das paginas a DETAIL vai receber a pagina do envento de click
            App.MasterDetail.Detail = new NavigationPage((Page) Activator.CreateInstance(pagina));

            // o menu precisa fechar e esse comando efetua esse close
            App.MasterDetail.IsPresented = false;

        }
    }
}