using _1221WebApplication2.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1221WebApplication2.Models.Services
{

    public class MemberService
    {
        private IMemberRepository repository;
        public MemberService(IMemberRepository repo)
        {
            this.repository = repo;
        }
        public void Create(MemberCreateDTO dto)
        {
            repository.Create(dto);
        }
    }
}