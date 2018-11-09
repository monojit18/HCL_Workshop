using System;
using System.Linq;
using System.Collections.Generic;

namespace FormsReferenceApp.Models.Local
{

    public class FRAEnvironments
    {

        public static FRAEnvironmentInfo GetEnvironmentInfo(
            List<FRAEnvironmentInfo> environmentsList,
            string environmentString)
        {

            if ((environmentsList == null) || (environmentsList.Count == 0))
                return null;
            
            if (string.IsNullOrEmpty(environmentString) == true)
                return null;

            var selectedEnvironmentInfo = environmentsList
                                            .FirstOrDefault(
                    (FRAEnvironmentInfo environmentInfo) =>
            {

                return ((environmentInfo != null)
                        && (environmentInfo.Environment
                            .Equals(environmentString)));

            });

            return selectedEnvironmentInfo;

        }

        public List<FRAEnvironmentInfo> Environments { get; set; }
        public string SelectedEnvironment { get; set; }


    }

    public class FRAEnvironmentInfo
    {

        public string Environment   { get; set; }
        public string SearchDBName  { get; set; }

    }
}
