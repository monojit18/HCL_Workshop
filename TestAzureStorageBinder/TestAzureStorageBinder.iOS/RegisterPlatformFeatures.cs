using System;
using TestAzureStorageBinder;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using UIKit;

namespace TestAzureStorageBinder.iOS
{
    public class RegisterPlatformFeatures : IRegisterPlatformFeatures
    {

        private UIViewController _viewController;

        public RegisterPlatformFeatures()
        {


            _viewController = UIApplication.SharedApplication.KeyWindow.RootViewController;

        }

        public PlatformParameters GetPlatformFeatures()
        {

            return (new PlatformParameters(_viewController));

        }

    }
}
