using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Bibliothek
{
    class Benutzer
    {
        public string BenutzerName;
        public string PassWD;
        public  DateTime BDate;
        public string Adresse;
        public Benutzer(string benutzername, string passwd, DateTime bdate, string adresse)
        {
            BenutzerName = benutzername;
            PassWD = passwd;
            BDate = bdate;
            Adresse = adresse;
        }
    }
}
