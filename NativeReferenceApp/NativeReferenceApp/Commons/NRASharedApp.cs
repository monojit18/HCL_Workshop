using System;
using Subsystems.ResourceLoader;
using Newtonsoft.Json;
using NativeReferenceApp.Models.Local;

#if __IOS__

#elif __ANDROID__

#endif

namespace NativeReferenceApp.Commons
{


    public sealed class NRASharedApp
    {


        private NRASharedApp()
        {
            
            var assemblyRef = typeof(NRASharedApp).Assembly;
            if (assemblyRef == null)
                return;

            var environmentFileNameString = NRAConstants
                                            .KEnvironmentsFileNameString;
            var environmentsString = CMPResourceLoader
                                        .GetEmbeddedResourceString(
                                            assemblyRef,
                                            environmentFileNameString);
            Environments = JsonConvert.DeserializeObject<NRAEnvironments>(
                                        environmentsString);
            if (Environments != null)
                SelectedEnvironmentInfo = NRAEnvironments
                    .GetEnvironmentInfo(Environments.Environments,
                                        Environments.SelectedEnvironment);

        }

        private class Nested
        {

            static Nested() { }
            internal static readonly NRASharedApp _instance = new NRASharedApp();

        }

        public static NRASharedApp SharedInstance
        {
            get
            {
                return Nested._instance;
            }
        }

        public NRAEnvironments Environments { get; set; }
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
