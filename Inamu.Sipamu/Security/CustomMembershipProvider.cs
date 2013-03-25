using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Inamu.Sipamu.Models;
using WebMatrix.WebData;

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
            SIPAMUEntities context = new SIPAMUEntities();
            return context.SEG_USUARIO.Any(u => (u.VC_LOGIN == username.Trim()) && (u.VC_CONTRASENNA == password.Trim()));
        }

        public override bool ChangePassword(string username, string oldPassword, string newPassword)
        {
            SIPAMUEntities context = new SIPAMUEntities();
            SEG_USUARIO user = context.SEG_USUARIO.Single(u => (u.VC_LOGIN == username));
            user.VC_LOGIN = newPassword;
            context.SaveChanges();
            return base.ChangePassword(username, oldPassword, newPassword);
        }
    }
}