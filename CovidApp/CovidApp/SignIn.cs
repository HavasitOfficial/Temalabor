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
        public string PassText { private get; set; }
        public SignIn()
        {

        }
        public void CheckUserAndPass(string username, string password, List<string> user, List<string> pass)
        {
            var encryptPass= encrypt(key, password);
            //new Windows.UI.Popups.MessageDialog($"{valami} ").ShowAsync();
            var resultUser = user.Select((Value, Index) => new { Value, Index })
                        .SingleOrDefault(l => l.Value == username);

            var indexUser = resultUser == null ? -1 : resultUser.Index;

            var resultPass = pass.Select((Value, Index) => new { Value, Index })
                        .SingleOrDefault(l => l.Value == encryptPass);

            var indexPass = resultPass == null ? -1 : resultPass.Index;
            var valami = pass[0];
            for (int i = 0; i < valami.Length; i++)
            {
                if (valami[i] != encryptPass[i])
                {
                    new Windows.UI.Popups.MessageDialog($"!{"nem egyezik meg"}!    {valami[i]}  {i}        {encryptPass[i]}").ShowAsync();
                    return;
                }
            }
            /*if (encryptPass.Length == pass[0].Length)
            {
                new Windows.UI.Popups.MessageDialog($"!{"megegyeszik"}!").ShowAsync();
            }
            else
            {
                new Windows.UI.Popups.MessageDialog($"!{"nem egyezik meg"}!").ShowAsync();
            }*/
            if (indexUser == indexPass && resultUser != null && resultPass != null) this.registerAllow = true;
            new Windows.UI.Popups.MessageDialog($"!{encryptPass}!").ShowAsync();
        }

        private String encrypt(string key, string plainText)
        {

            byte[] iv = new byte[16];
            byte[] array;
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }
            return Convert.ToBase64String(array);
        }

 
        public Boolean RegisterAllow()
        {
            return this.registerAllow;
        }
    }
}
