using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProvectoLogia
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuOP : MasterDetailPage
    {
        public MenuOP()
        {
            InitializeComponent();
            Detail = new NavigationPage(new Menu());
        }

        private void PaginaSobre_Tapped(object sender, EventArgs e)
        {
            // Criei errado ;---;
        }

        private void PaginaSobre_Tapped_1(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Sobre());
            IsPresented = false;//Fecha o menu
        }

        private void PaginaDeLeitor_Tapped(object sender, EventArgs e)
        {
            //Detail = new NavigationPage(new LeitorQR());
            //IsPresented = false;
        }

        private void PaginaContato_Tapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Contato());
            IsPresented = false;
        }

        private void PaginaGaleria_Tapped(object sender, EventArgs e)
        {
            //Detail = new NavigationPage(new Galeria());
            //IsPresented = false;
            //Esta em procedimento
            //Ainda não esta feito
        }

        private void PaginaAgendamento_Tapped(object sender, EventArgs e)
        {
            //Detail = new NavigationPage(new Agendamento());
            //IsPresented = false;
            //Esta em procedimento
            //Ainda não esta feito
        }
    }
}