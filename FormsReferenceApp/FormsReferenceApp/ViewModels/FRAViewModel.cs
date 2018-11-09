using System;
using SharedProject.Generic.BaseClasses;
using FormsReferenceApp.Adapters;
using FormsReferenceApp.Services;

namespace FormsReferenceApp.ViewModels
{
    public class FRAViewModel : ViewModelBase
    {
        public FRAViewModel()
        {
        }

        public void DummyFunction()
        {

            var httpService = new FRAHttpService();
            var dbService = new FRADBService();

            var adapter = new FRADummyAdapter(httpService, dbService);
            adapter.DummyFunction();


        }
    }
}
