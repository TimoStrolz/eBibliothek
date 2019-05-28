using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace e_Bibliothek
{
    class Benutzer
    {
        public string BenutzerName;
        public string PassWD;
        public  string BDate;
        public string Adresse;
        public Benutzer(string benutzername, string passwd, DateTime bdate, string adresse)
        {

            var sha1 = System.Security.Cryptography.SHA1.Create();
            var inputBytes = Encoding.ASCII.GetBytes(passwd);
            var hash = sha1.ComputeHash(inputBytes);

            var sb = new StringBuilder();
            for (var i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            PassWD = sb.ToString();
            BenutzerName = benutzername;
            //format date
            BDate = bdate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Adresse = adresse;

        }
    }
}
