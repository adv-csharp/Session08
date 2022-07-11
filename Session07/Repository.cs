using Session07.DataModel;
namespace Session07
{

    public class Repository

    {
        AppDbContext db;

        public Repository()
        {
            db = new AppDbContext();
        }

        public void Add<T>(T model) where T : class
        {
            db.Set<T>().Add(model);
            db.SaveChanges();
        }

        public void Edit<T>(T model) where T : class
        {
            db.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete<T>(int id) where T : class
        {
            var model = Find<T>(id);
            db.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
        }

        public T Find<T>(int id) where T : class
        {
            return db.Set<T>().Find(id);
        }

        public IQueryable<T> AsQueryable<T>() where T : class
        {
            return db.Set<T>().AsQueryable();
        }
    }
    

}
