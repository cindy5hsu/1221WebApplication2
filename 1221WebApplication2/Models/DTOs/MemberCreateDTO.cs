using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1221WebApplication2.Models.DTOs
{
    public class MemberCreateDTO
    {
        public string Name { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string CellPhone { get; set; }
    }
}