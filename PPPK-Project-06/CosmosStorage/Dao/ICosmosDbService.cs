using CosmosStorage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmosStorage.Dao
{
    public interface ICosmosDbService
    {
        Task<IEnumerable<Person>> GetPersonsAsync(string queryString);
        Task<Person> GetPersonAsync(string id);
        Task AddPersonAsync(Person person);
        Task UpdatePersonAsync(Person person);
        Task DeletePersonAsync(Person person);
    }
}
