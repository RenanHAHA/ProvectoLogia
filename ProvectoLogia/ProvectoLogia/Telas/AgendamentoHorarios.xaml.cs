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
	public partial class AgendamentoHorarios : ContentPage
	{

		public AgendamentoHorarios ()
		{
			InitializeComponent ();
            CarregarInformacoes();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void CarregarInformacoes()
        {
            
            string sql = "SELECT * FROM DataHora";
            var lista = ((App)Application.Current).conexao.Query<Model_s.Data_Hora>(sql);
            listViewAgendar.ItemsSource = lista;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Agendamento());
        }

        private void ButtomConfirmarAgendamento_Clicked(object sender, EventArgs e)
        {
            var mi = (MenuItem)sender;
            var model = (Model_s.Data_Hora)mi.CommandParameter;
            var sql = $"UPDATE DataHora Set Opcao = 'Indisponivel' WHERE id = '{model.ID}'";


            CarregarInformacoes();
        }


    }
}