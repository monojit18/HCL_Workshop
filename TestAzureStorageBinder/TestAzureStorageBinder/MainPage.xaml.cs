using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestAzureStorageBinder
{
    public partial class MainPage : ContentPage
    {

        private async Task TestStortageAsync()
        {
            
            var platformService = DependencyService.Get<IRegisterPlatformFeatures>();
            var storageBinder = new StorageBinder(platformService.GetPlatformFeatures());
            var couldDo = await storageBinder.TestDefaultAsync();


        }

        public void Handle_Clicked(object sender, EventArgs e)
        {

            TestStortageAsync();

        }

        public MainPage()
        {
            InitializeComponent();



        }
    }
}
