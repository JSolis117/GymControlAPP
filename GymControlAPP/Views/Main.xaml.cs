namespace GymControlAPP.Views;

public partial class Main_page : ContentPage
{
    public Main_page()
    {
        InitializeComponent();
    }

    private async void BtnUserManagement_Clicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new Perfil());
    }


    private async void BtnClassScheduling_Clicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new Agenda());
    }


    private async void BtnSubscriptionManagement_Clicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new Subscripcion());
    }

}
