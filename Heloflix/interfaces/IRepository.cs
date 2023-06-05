namespace Heloflix.interfaces;

    public interface IRepository<T> where T : class
    {
      void Create (T model);  

      List<T> ReadAll();

      T ReadById (int? id); 

      void Update (T model);

      void Delete (int? id);
    }
