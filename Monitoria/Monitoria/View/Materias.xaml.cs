using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Monitoria.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Materias : ContentPage
    {
        public Materias()
        {
            InitializeComponent();
        }

        private void SelecionaMateria(object sender, SelectedItemChangedEventArgs e)
        {
            //// cria a vairavel que vai aguardar o evento do MenuLista e gravando o Cast
            //var menu = ()e.SelectedItem;

            //// passou para ele a referencia da outra pagina
            //Type pagina = menu.Pagina;

            //// navegação das paginas a DETAIL vai receber a pagina do envento de click
            //App.MasterDetail.Detail = new NavigationPage((Page)Activator.CreateInstance(pagina));

            //// o menu precisa fechar e esse comando efetua esse close
            //App.MasterDetail.IsPresented = false;
        }
    }
}