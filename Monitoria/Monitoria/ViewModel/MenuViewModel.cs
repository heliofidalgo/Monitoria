
using System.Collections.ObjectModel;
using Monitoria.Model;
using Monitoria.View;

namespace Monitoria.ViewModel
{
     public class MenuViewModel
    {
        // criando uma lista publica da classe MenuLista passando somente o GET
        public ObservableCollection<MenuLista> ListaMenu { get; }

        public MenuViewModel()
        {
            // instanciando a ListaMenu
            ListaMenu = new ObservableCollection<MenuLista>();

            // Chamando o metodo para adicionar o item na lista
            AdListItem();
        }

        public void AdListItem()
        {
            ListaMenu.Add(new MenuLista() { Titulo = "Home", Icone = "ic_home_black_18dp", Pagina = typeof(Home) });
            ListaMenu.Add(new MenuLista() { Titulo = "Administrador", Icone = "ic_home_black_18dp", Pagina = typeof(Home) });
            ListaMenu.Add(new MenuLista() { Titulo = "Matérias", Icone = "ic_home_black_18dp", Pagina = typeof(Home) });
            ListaMenu.Add(new MenuLista() { Titulo = "Monitorias", Icone = "ic_home_black_18dp", Pagina = typeof(Home) });
            ListaMenu.Add(new MenuLista() { Titulo = "Ratings", Icone = "ic_home_black_18dp", Pagina = typeof(Home) });
            ListaMenu.Add(new MenuLista() { Titulo = "Editar Perfil", Icone = "ic_home_black_18dp", Pagina = typeof(Home) });
            ListaMenu.Add(new MenuLista() { Titulo = "Suporte", Icone = "ic_home_black_18dp", Pagina = typeof(Home) });
            ListaMenu.Add(new MenuLista() { Titulo = "Denúncia", Icone = "ic_home_black_18dp", Pagina = typeof(Home) });
        }
    }
}
