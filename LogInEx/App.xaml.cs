using LogInEx.Views;

namespace LogInEx
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginView();
        }
    }
}