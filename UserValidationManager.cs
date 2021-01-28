using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1999 && gamer.FirstName == "Ahmet Hakan" && gamer.IdentityNumber == 12345 &&
                gamer.LastName == "Yıldırım")
            {

                return true;
            }
            else
            {
                return false;

            }
        }
    }
}
