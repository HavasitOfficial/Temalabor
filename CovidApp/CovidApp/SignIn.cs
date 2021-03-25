using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidApp
{
    class SignIn
    {
        private Boolean registerAllow = false;

        public SignIn()
        {

        }
        public void CheckUserAndPass(string username, string password, List<string> user, List<string> pass)
        {
            var resultUser = user.Select((Value, Index) => new { Value, Index })
                        .SingleOrDefault(l => l.Value == username);

            var indexUser = resultUser == null ? -1 : resultUser.Index;

            var resultPass = pass.Select((Value, Index) => new { Value, Index })
                        .SingleOrDefault(l => l.Value == password);

            var indexPass = resultPass == null ? -1 : resultPass.Index;

            if (indexUser == indexPass && resultUser != null && resultPass != null) this.registerAllow = true;
        }
    }
}
