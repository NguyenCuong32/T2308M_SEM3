using System;
using Adv.Models;

namespace Adv.Repositories;

public interface IClassRepository
{
    List<Class> GetClasses();
    void AddClass(Class _class);
}
