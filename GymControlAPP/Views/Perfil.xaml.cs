using System.ComponentModel;

namespace GymControlAPP.Views;

public partial class Perfil : ContentPage
{
	public Perfil()
	{
		InitializeComponent();
	}

    private async void BtnUsuario_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Continuara());
    }

    private async void BtnLogin_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }

 
}