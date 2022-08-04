using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TeveApp.DataAccess.Base
{
    public class DataAccessBase<TI, TM> where TM : new()
    {
        private readonly SQLiteConnection connection = DatabaseHandler.Instance.ConnectionUserDataBase;

        public virtual void Delete(TI entity)
        {
            connection.Delete(entity);
        }

        public virtual void Insert(TI entity)
        {
            connection.Insert(entity);
        }

        public virtual IList<TM> SelectAllItems()
        {
            return connection.Table<TM>().ToList();
        }

        public virtual IList<TM> SelectByCriteria(Expression<Func<TM, bool>> predicate)
        {
            return connection.Table<TM>().Where(predicate).ToList();
        }

        public virtual void Update(TI entity)
        {
            connection.Update(entity);
        }
    }
}
