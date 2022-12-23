using _1221WebApplication2.Models.DTOs;
using System;
using WebApplication1.Models.Services;

namespace _1221WebApplication2.Models.EFModels.Services
{
    public class RegistersService
    {
        private IRegisterRepository repository ;

        public RegistersService(IRegisterRepository repo)
        {
            repository= repo;
        }
        public void Create (RegisterDTO registerDto)
        {
            //驗證 Email 是否已經存在
            var dataInDb =repository.FindByEmail(registerDto.Email);

            if (dataInDb != null)//表示資料表有這筆記錄
            {
                throw new Exception("Email 已經報名過了，無法在報名");

            }
            //用程式指定時間。而不是用使用者輸入
            registerDto.CreateTime = DateTime.Now;
           repository.Create(registerDto);

        }
    
        public Register Find(int id)
        {
            Register register = repository.FindById(id);
            if (register == null)
            {
                throw new Exception("找不到指定記錄");
            }
            return register;
        }
    }
}