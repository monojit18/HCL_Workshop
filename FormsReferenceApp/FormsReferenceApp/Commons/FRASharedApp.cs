using System;
using Subsystems.ResourceLoader;
using Newtonsoft.Json;
using FormsReferenceApp.Models.Local;

#if __IOS__

#elif __ANDROID__

#endif

namespace FormsReferenceApp.Commons
{


    public sealed class FRASharedApp
    {


        private FRASharedApp()
        {
            
            var assemblyRef = typeof(FRASharedApp).Assembly;
            if (assemblyRef == null)
                return;

            var environmentFileNameString = FRAConstants
                                            .KEnvironmentsFileNameString;
            var environmentsString = CMPResourceLoader
                                        .GetEmbeddedResourceString(
                                            assemblyRef,
                                            environmentFileNameString);
            Environments = JsonConvert.DeserializeObject<FRAEnvironments>(
                                        environmentsString);
            if (Environments != null)
                SelectedEnvironmentInfo = FRAEnvironments
                    .GetEnvironmentInfo(Environments.Environments,
                                        Environments.SelectedEnvironment);

        }

        private class Nested
        {

            static Nested() { }
            internal static readonly FRASharedApp _instance = new FRASharedApp();

        }

        public static FRASharedApp SharedInstance
        {
            get
            {
                return Nested._instance;
            }
        }

        public FRAEnvironments Environments { get; set; }
        public FRAEnvironmentInfo SelectedEnvironmentInfo { get; set; }

        public static Tuple<DateTime, DateTime> PrepareStartAndEndDateTime()
        {

            var startDateTime = DateTime.Now;
            var endDateTime = new DateTime(startDateTime.Year + 1,
                                           startDateTime.Month,
                                           startDateTime.Day);
            return (new Tuple<DateTime, DateTime>(startDateTime,
                                                  endDateTime));

        }

    }

}
