using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Industrial.Services;
using Industrial.Views;
using Industrial.Services.SupplyService;

namespace Industrial
{
    public partial class App : Application
    {
        public static SupplyManager supplyManager { get; private set; }
        public App()
        {
            InitializeComponent();

            supplyManager = new SupplyManager(new SupplyRest());
            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
