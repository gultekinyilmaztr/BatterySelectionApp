using System.Linq.Expressions;

namespace CorePackages.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        IQueryable<T> GetAll();
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}





//GetByIdAsync(int id): Belirli bir kimlik (ID) değerine sahip varlık (entity) almak için kullanılır. Asenkron bir metottur, yani işlem tamamlandığında beklemeni gerekmez.

//GetAll(): Tüm varlıkları almak için kullanılır. Bu metod, tüm varlıkları içeren bir sorgu döndürür.

//Where(Expression<Func<T, bool>> expression): Belirli bir koşulu sağlayan varlıkları almak için kullanılır. LINQ ifadeleriyle bir filtre sağlamak için kullanılır.

//AnyAsync(Expression<Func<T, bool>> expression): Belirli bir koşulu sağlayan varlık olup olmadığını kontrol etmek için kullanılır. Asenkron bir metottur.

//AddAsync(T entity): Yeni bir varlık eklemek için kullanılır. Asenkron bir metottur.

//AddRangeAsync(IEnumerable<T> entities): Birden fazla varlık eklemek için kullanılır. Asenkron bir metottur.

//Update(T entity): Varlığın güncellenmesi için kullanılır.

//Remove(T entity): Belirli bir varlığı silmek için kullanılır.

//RemoveRange(IEnumerable<T> entities): Birden fazla varlığı silmek için kullanılır.