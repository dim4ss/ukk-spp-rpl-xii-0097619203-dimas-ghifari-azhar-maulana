using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktop_csharp.models
{
    public class SessionUser
    {
        public SessionUser(int idPetugas, string username, string namaPetugas, string level, bool isLoggedIn)
        {
            IdPetugas = idPetugas;
            Username = username;
            NamaPetugas = namaPetugas;
            Level = level;
            IsLoggedIn = isLoggedIn;
        }

        public static int IdPetugas { get; set; } 
        public static string Username { get; set; }
        public static string NamaPetugas { get; set; }
        public static string Level { get; set; }
        public static bool IsLoggedIn { get; set; }

        

        public static void SetSession (int idPetugas, string username, string namaPetugas, string level)
        {
            IdPetugas = IdPetugas;
            Username = username;
            NamaPetugas = namaPetugas;
            Level = level.ToLower();
            IsLoggedIn = true;
        }


        //method untuk menghapus identitas session saat logout.
        public static void ClearSession()
        {
            IdPetugas = 0;
            Username = null;
            NamaPetugas = null;
            Level = null;
            IsLoggedIn = false;
        }

        public static void IsAdmin()
        {
            
        }


    }
}
