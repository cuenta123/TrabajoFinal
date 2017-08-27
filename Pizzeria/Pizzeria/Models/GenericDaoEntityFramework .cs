using System;
using LinqToSql;
using System.Data.Entity.Infrastructure;

namespace Pizzeria.Models
{
    public class GenericDaoEntityFramework 
    {
        MydbContex db;
       
        public void InsertSQL(Generic entity)
        {
            db = new MydbContex();
            var returnObject = entity.Obj;
            var type = returnObject.GetType(); 
            var dbcontext = db.Set(type);
            dbcontext.Add(returnObject);
            db.SaveChanges();
        }

        public void DeleteSQL(Generic entity)
        {
            db = new MydbContex();
            var returnObject = entity.Obj;
            var type = returnObject.GetType();
            var dbcontext = db.Set(type);
            dbcontext.Remove(returnObject);     
        }

        public Generic GetSQL(Guid Id, Type type)
        {           
            db = new MydbContex();
            var dbcontext = db.Set(type);
            var returnedObject = dbcontext.Find(Id);
            db.SaveChanges();
            return Generic.ToGeneric(returnedObject) ;
        }

        public void UpdateSQL(Generic entity)
        {
            db = new MydbContex();
            Type type = entity.Obj.GetType();
            var returnObject = entity.Obj;
            var dbcontext =  db.Set(type);           
            dbcontext.Remove(entity);
            dbcontext.Add(returnObject);
            db.SaveChanges();
        }

        public DbSqlQuery GetAllSQL(Generic entity)
        {
            //TODO  Arreglar para que devuelva una lista
            db = new MydbContex();
            Type type = entity.Obj.GetType();
            var returnObject = entity.Obj;
            var dbcontext = db.Set(type);
           var consulta = dbcontext.SqlQuery("Select * From " + type);
            db.SaveChanges();
            return consulta;
        }

    }
}