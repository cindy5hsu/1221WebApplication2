using _1221WebApplication2.Models.DTOs;
using _1221WebApplication2.Models.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Models.Services
{
    public class RegisterRepository : IRegisterRepository
    {
        private AppDbContext01 db = new AppDbContext01();

        public void Create(RegisterDTO registerDto)
        {
            Register regoster = new Register {
                Id = registerDto.Id,
                Name = registerDto.Name,
                Email = registerDto.Email,
                CreateTime = DateTime.Now
            };
            db.Registers.Add(regoster);
            db.SaveChanges();
        }
        public void Create(Register register)
        {
            db.Registers.Add(register);
            db.SaveChanges();
        }
        public List<Register> GetAll()
        {
            return db.Registers.ToList();
        }
        public Register FindByEmail(string email)
        {
            return db.Registers.FirstOrDefault(x => x.Email == email);
        }
        public Register FindById(int id)
        {
            return db.Registers.Find(id);
        }

    }
}