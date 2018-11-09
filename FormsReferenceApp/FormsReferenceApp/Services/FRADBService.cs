using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using SharedProject.Generic.Interfaces;
using SharedProject.Generic.BaseClasses;

namespace FormsReferenceApp.Services
{
    public class FRADBService : IDbService
    {

        public void InitializeDB(string dbPathString)
        {

            throw new NotImplementedException();

        }

        public bool Create<T>() where T : new()
        {

            throw new NotImplementedException();

        }

        public async Task<bool> CreateAsync<T>() where T : new()
        {

            throw new NotImplementedException();

        }

        public List<T> Fetch<T>(Predicate<T> predicate = null)
            where T : new()
        {

            throw new NotImplementedException();

        }

        public async Task<List<T>> FetchAsync<T>(Predicate<T> predicate = null)
            where T : new()
        {

            throw new NotImplementedException();

        }

        public bool Insert(IDataModel item)
        {

            throw new NotImplementedException();

        }

        public async Task<bool> InsertAsync(IDataModel item)
        {

            throw new NotImplementedException();

        }

        public bool InsertAll(List<IDataModel> items)
        {

            throw new NotImplementedException();

        }

        public async Task<bool> InsertAllAsync(List<IDataModel> items)
        {

            throw new NotImplementedException();

        }

        public bool Update(IDataModel item)
        {

            throw new NotImplementedException();

        }

        public async Task<bool> UpdateAsync(IDataModel item)
        {

            throw new NotImplementedException();

        }

        public List<bool> UpdateAll(List<IDataModel> items)
        {

            throw new NotImplementedException();

        }

        public async Task<List<bool>> UpdateAllAsync(List<IDataModel> items)
        {

            throw new NotImplementedException();

        }

        public bool Delete(IDataModel item)
        {

            throw new NotImplementedException();

        }

        public async Task<bool> DeleteAsync(IDataModel item)
        {

            throw new NotImplementedException();

        }

        public List<bool> DeleteAll(List<IDataModel> items)
        {

            throw new NotImplementedException();

        }

        public async Task<List<bool>> DeleteAllAsync(List<IDataModel> items)
        {

            throw new NotImplementedException();

        }

        public void DummyDBFunction()
        {



        }

    }
}
