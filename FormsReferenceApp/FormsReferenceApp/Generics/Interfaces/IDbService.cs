using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SharedProject.Generic.Interfaces
{
    public interface IDbService
    {

        void InitializeDB(string dbPathString);

        bool Create<T>() where T : new();
        Task<bool> CreateAsync<T>() where T : new();

        List<T> Fetch<T>(Predicate<T> predicate = null) 
            where T : new();
        Task<List<T>> FetchAsync<T>(Predicate<T> predicate = null)
            where T : new();

        bool Insert(IDataModel item);
        Task<bool> InsertAsync(IDataModel item);
        bool InsertAll(List<IDataModel> items);
        Task<bool> InsertAllAsync(List<IDataModel> items);

        bool Update(IDataModel item);
        Task<bool> UpdateAsync(IDataModel item);
        List<bool> UpdateAll(List<IDataModel> items);
        Task<List<bool>> UpdateAllAsync(List<IDataModel> items);

        bool Delete(IDataModel item);
        Task<bool> DeleteAsync(IDataModel item);
        List<bool> DeleteAll(List<IDataModel> items);
        Task<List<bool>> DeleteAllAsync(List<IDataModel> items);


    }
}

