using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Persistance
{
    // T should be a class
    public interface IAsyncRepository<T> where T: class
    {
        Task<T> GetAllAsync();

        Task<IReadOnlyList<T>> GetByIdAsync(Guid id);
        
        Task<T> AddAsync(T entity);

        Task<T> UpdateAsync(T entity);

        Task<T> DeleteAsync(T entity);

        /*  Notki PL :
         *  
         *  Klasa Task reprezentuje nam asynchroniczną operację.
         *  Nie zwraca wartości jednak Task<T> zwraca nam zmienną o typie T
         *  Jest to swojego rodzaju obietnica, że operacja się zakończy
         *  
         *  
         *
         * 
         * 
         * 
         */
    }
}
