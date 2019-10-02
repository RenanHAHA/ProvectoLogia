using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProvectoLogia
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonEntrar_Clicked(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(entryUsuario.Text) ||
             !string.IsNullOrEmpty(entrySenha.Text))
            {

                if ((entryUsuario.Text == "Admin") || (entrySenha.Text == "123"))
                {
                    Navigation.PushAsync(new MenuOP());
                }
                else
                {
                    DisplayAlert("Erro", "Não foi possivel entrar! \nErro no nome de Login ou Senha", "Ok");
                }

            }
            else
            {
                DisplayAlert("ERRO", "Não deixe os campos em branco", "OK");
            }

        }

        private void ButtonCadastrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroDeUsuario());
        }
    }
}
