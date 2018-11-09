using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Subsystems.ResourceLoader
{
    public static class CMPResourceLoader
    {

        #region Private Variables
        private static string _baseResource;
        #endregion


        #region Public Methods
        public static string BaseResource
        {
            get
            {
                return _baseResource ?? (_baseResource = Assembly.GetExecutingAssembly().FullName.Split(',')
                                         .FirstOrDefault());
            }
        }

        public static Stream GetEmbeddedResourceStream(Assembly assemblyRef, string resourceFileNameString)
        {

            var manifestResourceNamesArray = assemblyRef.GetManifestResourceNames();
            var foundResourceNamesArray = manifestResourceNamesArray
                .Where(x => x.EndsWith(resourceFileNameString, StringComparison.CurrentCultureIgnoreCase))
                .ToArray();

            if (!foundResourceNamesArray.Any())
                throw new FileNotFoundException();

            if (foundResourceNamesArray.Count() > 1)
                throw new AmbiguousMatchException();

            return assemblyRef.GetManifestResourceStream(foundResourceNamesArray.Single());

        }


        public static string GetEmbeddedResourceString(Assembly assembly, string resourceFileName)
        {

            var resourceStream = GetEmbeddedResourceStream(assembly, resourceFileName);
            using (var streamReader = new StreamReader(resourceStream))
                return streamReader.ReadToEnd();

        }
        #endregion


    }
}
