using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
   public interface IUserValidationService
   {
       public bool Validate(Gamer gamer);
   }
}
