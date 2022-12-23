using _1221WebApplication2.Models.EFModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _1221WebApplication2.Models.DTOs
{
    public class RegisterDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

   
        public string Email { get; set; }

        public DateTime CreateTime { get; set; }
    }
    public static class RegisterExtensions
    {
        public static RegisterDTO EntetyToDTO(this Register source)
        {
            return new RegisterDTO()
            {
                Id = source.Id,
                Name = source.Name,
                Email = source.Email,
                CreateTime = source.CreateTime,
            };
        }
    }
}