using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //MicroService 
    class GamerManager : IGamerService
    {
        // Bir Manager sınıfın içinde  Başka bir Manager sınıfı kullanacaksak asla onu new leme 
         IUserValidationService _userValidationService;

         public GamerManager(IUserValidationService userValidationService)
         {
             _userValidationService = userValidationService;
         }

         public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt Olundu :  " + gamer.FirstName  +"  "+ gamer.LastName);
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız Kayıt olunamadı.....");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi " + gamer.FirstName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi " +gamer.FirstName);
        }
    }
}
