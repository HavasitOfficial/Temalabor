using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CovidApp
{
    class SignIn
    {
        private string key = "b14ca5898a4e4133bbce2ea2315a1916";
        private Boolean registerAllow = false;
        private List<string> descryptedPass;
        public SignIn()
        {

        }
        public void CheckUserAndPass(string username, string password, List<string> user, List<string> pass)
        {
            descryptPassword(pass);

            var resultUser = user.Select((Value, Index) => new { Value, Index })
                        .SingleOrDefault(l => l.Value == username);

            var indexUser = resultUser == null ? -1 : resultUser.Index;

            var resultPass = descryptedPass.Select((Value, Index) => new { Value, Index })
                        .SingleOrDefault(l => l.Value == password);

            var indexPass = resultPass == null ? -1 : resultPass.Index;

            if (indexUser == indexPass && resultUser != null && resultPass != null) this.registerAllow = true;
        }


        private string DecryptString(string key, string cipherText)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }
        private void descryptPassword(List<string> sv)
        {
            foreach (var item in sv)
            {
                this.descryptedPass.Add(DecryptString(this.key,item));
            }
        }

    }
}
