using _1221WebApplication2.Models.DTOs;
using _1221WebApplication2.Models.EFModels;
using System.Collections.Generic;

namespace WebApplication1.Models.Services
{
    public interface IRegisterRepository
    {
        void Create(RegisterDTO registerDto);
        Register FindByEmail(string email);
        Register FindById(int id);
        List<Register> GetAll();
    }
}