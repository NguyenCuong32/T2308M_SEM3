using System;
using Adv.Dtos;
using Adv.Models;

namespace Adv.Services;

public interface IClassService
{
    List<Class> GetClasses();
    void AddClass(AddClassDto classDto);
}
