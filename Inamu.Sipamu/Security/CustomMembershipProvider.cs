using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Inamu.Sipamu.Models;
using WebMatrix.WebData;
using System.Web.Security;
using System.DirectoryServices;


namespace Inamu.Sipamu.Security
{
    public class CustomMembershipProvider : SimpleMembershipProvider
    {
        public override bool ValidateUser(string username, string password)
        {
            if (string.IsNullOrEmpty(username.Trim()) || string.IsNullOrEmpty(password.Trim()))
            {
                return false;
            }
            SIPAMU_Entities context = new SIPAMU_Entities();
            return context.SEG_USUARIO.Any(u => (u.VC_LOGIN == username.Trim()) && (u.VC_CONTRASENNA == password.Trim()));
        }

        public override bool ChangePassword(string username, string oldPassword, string newPassword)
        {
            SIPAMU_Entities context = new SIPAMU_Entities();
            SEG_USUARIO user = context.SEG_USUARIO.Single(u => (u.VC_LOGIN == username));
            user.VC_LOGIN = newPassword;
            context.SaveChanges();
            return base.ChangePassword(username, oldPassword, newPassword);
        }

        public bool Authenticate(string userName, string password, string domain)
        {
            bool authentic = false;
            try
            {
                
                DirectoryEntry entry = new DirectoryEntry("WinNT://BABEL", userName, password);
                try
                {
                    object nativeObject = entry.NativeObject;
                    authentic = true;
                }
                catch (Exception)
                {
                    authentic = false;
                    //throw;
                }
                //string prueba = "";
                //prueba = entry.NativeObject.ToString();
                //if (entry.NativeObject.ToString()=="")
                //{
                //    object nativeObject = entry.NativeObject;
                //    authentic = true;
                //}
                //else
                //    authentic = false;
            }
            catch (DirectoryServicesCOMException) { }
            return authentic;
        }
    }
}