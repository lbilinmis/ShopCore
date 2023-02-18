using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCore.Core.Utilities.Hashing
{
    public class HashingHelper
    {
        public static void CreatePassword(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hashingMac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hashingMac.Key;
                passwordHash = hashingMac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            bool result = true;
            using (var hashingMac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computeHash = hashingMac.ComputeHash(Encoding.UTF8.GetBytes(password));

                for (int i = 0; i < computeHash.Length; i++)
                {
                    if (computeHash[i] != passwordHash[i])
                    {
                        result = false;
                    }
                }
            }

            return result;
        }
    }
}
