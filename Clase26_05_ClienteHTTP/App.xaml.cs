namespace Clase26_05_ClienteHTTP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new MainPage()) { Title = "Clase26_05_ClienteHTTP" };
        }
    }
}
