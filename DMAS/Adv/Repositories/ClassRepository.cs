using System;
using Adv.Models;

namespace Adv.Repositories;

public class ClassRepository : IClassRepository
{
    private readonly EduDbContext dbContext;

    public ClassRepository(EduDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    public void AddClass(Class _class)
    {
        try
        {
            this.dbContext.Add(_class);
            this.dbContext.SaveChanges();
        }
        catch (System.Exception)
        {
            
            throw;
        }
    }

    public List<Class> GetClasses()
    {
       try
       {
         return this.dbContext.Classes.ToList();
       }
       catch (System.Exception)
       {
        
        throw;
       }
    }
}
