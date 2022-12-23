using _1221WebApplication2.Models.DTOs;
using _1221WebApplication2.Models.EFModels;
using _1221WebApplication2.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Web;

namespace _1221WebApplication2.Models.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        private AppDbContext01 db;
        public MemberRepository()
        {
            db = new AppDbContext01();
        }
        public void Create(MemberCreateDTO dto)
        {
            Member member = new Member
            {
                Name = dto.Name,
                Account = dto.Account,
                Password = dto.Password,
                CellPhone = dto.CellPhone
            };
            db.Members.Add(member); 
            db.SaveChanges();
        }
    }
}