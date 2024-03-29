﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProvectoLogia
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Agendamento : ContentPage
	{
		public Agendamento ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void ButtonAgendarHorario_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AgendamentoHorarios());
        }

        private void ButtonVoltar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MenuOP());
        }
    }
}