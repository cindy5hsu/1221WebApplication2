﻿using _1221WebApplication2.Models.DTOs;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Web;

namespace _1221WebApplication2.Models.VM
{
    public class MemberCreateVM
    {
        public int Id { get; set; }

        [Display(Name= "中文姓名")]
        [Required(ErrorMessage ="{0}必填")]
        [StringLength(31, ErrorMessage = "{0}姓名長度不能超過 {1} 個字")]
        public string Name { get; set; }

        [Display(Name = "賬號")]
        [Required]
        [StringLength(50)]
        public string Account { get; set; }

        [Display(Name = "密碼")]
        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [Display(Name = "確認密碼")]
        [Required]
        [StringLength(50)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "手機")]
        [Required]
        [StringLength(50)]
        public string CellPhone { get; set; }
     
    }
    public static class MemberCreateVMExts
    {
        public static MemberCreateDTO ToDto(this MemberCreateVM model)
        {
            return new MemberCreateDTO
            {
                Name = model.Name,
                Account = model.Account,
                Password = model.Password,
                CellPhone = model.CellPhone
            };
        }
    }

}