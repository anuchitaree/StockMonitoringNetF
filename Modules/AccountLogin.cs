//using Microsoft.AspNetCore.Cryptography.KeyDerivation;
//using StockMonitoring.Data;
//using StockMonitoring.Models;
//using System;
//using System.Linq;
//using System.Security.Cryptography;
//using System.Windows.Forms;

//namespace StockMonitoringNetF.Modules
//{
//    public class AccountLogin
//    {

//        public bool CreateAccount(Account account)
//        {
//            try
//            {
//                using (var db = new SqliteLoginContext())
//                {
//                    var existingAccount = db.Accounts.SingleOrDefault(a => a.Username == account.Username);
//                    if (existingAccount != null)
//                        return false;  // throw new Exception("Existing Account");
//                    account.Password = CreatePasswordHash(account.Password);
//                    db.Accounts.Add(account);
//                    db.SaveChanges();
//                }
//                return true;
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e.Message);
//                return false;

//            }
           
//        }


//        public Account Login(string username,string password)
//        {
//            try
//            {
//                using (var db = new SqliteLoginContext())
//                {
//                    var account = db.Accounts.SingleOrDefault(a => a.Username == username);
//                    if (account != null && VerifyPassword(account.Password, password))
//                    {
//                        return account;
//                    }
//                }
//                return null;
//            }
//            catch 
//            {
//                return null;
//            }
           
//        }






//        private  string CreatePasswordHash(string password)
//        {
//            byte[] salt = new byte[128 / 8];
//            using (var rng = RandomNumberGenerator.Create())
//            {
//                rng.GetBytes(salt);
//            }

//            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
//                password: password,
//                salt: salt,
//                prf: KeyDerivationPrf.HMACSHA512,
//                iterationCount: 10000,
//                numBytesRequested: 258 / 8
//            ));
//            return $"{Convert.ToBase64String(salt)}.{hashed}";
//        }

//        private  bool VerifyPassword(string hash, string password)
//        {
//            var parts = hash.Split('.', 2);
//            if (parts.Length != 2)
//            {
//                return false;
//            }

//            var salt = Convert.FromBase64String(parts[0]);
//            var passwordHash = parts[1];
//            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
//              password: password,
//              salt: salt,
//              prf: KeyDerivationPrf.HMACSHA512,
//              iterationCount: 10000,
//              numBytesRequested: 258 / 8
//            ));

//            return passwordHash == hashed;
//        }

//    }
//}
