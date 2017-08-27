using LinqToSql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;

namespace Pizzeria.Models
{
    public class Login
    {
      public void login(String Email,String Contraseña)
        {
            Boolean passwordisValid = true;   //Regex.IsMatch(Contraseña, "^[a - zA - Z]\\w{ 3,20}$");
            Boolean emailisValid = true;             //Regex.IsMatch(Email, @"^[\w -\.] +@([\w -] +\.) +[\w -]{ 2,5}$");

            if (passwordisValid == false)
            {
                throw new Exception("Password Incorrecto, compruebe que esta entre 3 y 20 caracteres. No esta permitido los caracteres especiales como -,<,>");
            }
            if (emailisValid == false)
            {
                throw new Exception("Email Incorrecto compruebe que el nombre de dominio esta entre 2 y 5 caracteres. No esta permitido los caracteres especiales como -,<,>");
            }
            CheckPasswordEmail(Email, Contraseña);     
        }

       private void CheckPasswordEmail(String Email, String Contraseña)
        {
            int? rownumbers;
            CheckUserBD check = new CheckUserBD();
            rownumbers = check.ComproveUserPasswordBD(Email, Contraseña);
            if (rownumbers!=1)
            {
                throw new Exception("Email o contraseña es Incorrecta");
            }
            CreateAuthorizationTicket(Email);
        }

        private void CreateAuthorizationTicket(String email)
        {
            FormsAuthentication.SetAuthCookie(email, true);
        }
      
        
       
        public void LogOut()
        {
            FormsAuthentication.SignOut();
        }

    }
}