namespace GymControlAPP.Views;
public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    public async void SwShowPassword_Toggled(object sender, ToggledEventArgs e)
    {
        TxtPassword.IsPassword = true;

        if (SwShowPassword.IsToggled)
        {
            TxtPassword.IsPassword = false;
        }

    }

    private async void BtnSignUp_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new UserSignUpPage());
    }

}

