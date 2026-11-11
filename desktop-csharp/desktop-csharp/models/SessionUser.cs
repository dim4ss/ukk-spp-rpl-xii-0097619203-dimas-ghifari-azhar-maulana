using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktop_csharp.models
{
    internal class SessionUser
    {
        public SessionUser(int idPetugas, string username, string namaPetugas, string level, bool isLoggedIn)
        {
            IdPetugas = idPetugas;
            Username = username;
            NamaPetugas = namaPetugas;
            Level = level;
            IsLoggedIn = isLoggedIn;
        }

        public int IdPetugas { get; set; } 
        public string Username { get; set; }
        public string NamaPetugas { get; set; }
        public string Level { get; set; }
        public bool IsLoggedIn { get; set; }

        

        public void SetSession (int idPetugas, string username, string namaPetugas, string level)
        {
            IdPetugas = idPetugas;
            Username = username;
            NamaPetugas = namaPetugas;
            Level = level;
        }


        //method untuk menghapus identitas session saat logout.
        public void ClearSession()
        {
            ClearSession();
        }

        public void IsAdmin()
        {
            
        }
    }
}
