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
	public partial class CadastroDeUsuario : ContentPage
	{
		public CadastroDeUsuario ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new MainPage());

        }

        private void ButtonCadastroUsuario_Clicked(object sender, EventArgs e)
        {

            if (entryComfirmarSenhaUsuario.Text == entrySenhaUsuario.Text)
            {

                string sql = $"INSERT INTO Usuarios (NomeDeUsuario, SenhaDeUsuario) VALUES ('{entryNomeUsuario.Text}', '{entrySenhaUsuario.Text}')";
                ((App)Application.Current).conexao.Execute(sql);
                DisplayAlert("SUCESSO", "Seu Usuario foi cadastrado", "OK");

            }
            else
            {
                DisplayAlert("Erro", "As senhas estão diferentes", "OK");
            }
        }
    }
}