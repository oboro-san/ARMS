using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ARMS.Models;
using ARMS.Models.ViewModels;
using AutoMapper;

namespace ARMS.UI.Mapper
{
    public class ArmsMappings : Profile
    {
        public ArmsMappings()
        {
            CreateMap<Student, StudentViewModel>().ForMember(d => d.Id, map => map.MapFrom(s => s.StudentId));
        }
    }
}