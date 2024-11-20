using System;
using Adv.Dtos;
using Adv.Models;
using Adv.Repositories;

namespace Adv.Services;

public class ClassService : IClassService
{
    private readonly IClassRepository classRepository;

    public ClassService(IClassRepository classRepository)
    {
        this.classRepository = classRepository;
    }
    public void AddClass(AddClassDto classDto)
    {
        try
        {
            Class _class = new Class()
            {
                ClassName = classDto.ClassName,
                RoomName = classDto.RoomName
            };
            this.classRepository.AddClass(_class);
        }
        catch (System.Exception)
        {

            throw;
        }
    }

    public List<Class> GetClasses()
    {
        return this.classRepository.GetClasses();
    }
}
