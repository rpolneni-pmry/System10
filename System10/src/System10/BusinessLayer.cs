using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace System10.Models
{
    public class BusinessLayer
    {
        private readonly System10Context _context;
        public BusinessLayer(System10Context context )
        {
            _context = context;
        }

        public void CreateWindowsUserCredential(string winLoginName)
        {
            DboCredential obj = new DboCredential();
            obj.Vchr32Name = winLoginName;
            obj.Nvch128Caption = winLoginName;
            //  obj.Bin64PasswordHash = string.Empty;
            obj.BEnabled = true;
            obj.DtCreated = DateTime.Now;
            obj.Vchr256CreatedContext = "Creating new Credential Record for Active Directory user";
            obj.BintCreatorCredentialId = 1;
            obj.BintCreatorSpoofOfCredentialId = null;
            obj.DtModified = DateTime.Now;
            obj.Vchr256ModifiedContext = string.Empty;
            obj.BintModifierCredentialId = 1;
            obj.BintModifierSpoofOfCredentialId = null;
            obj.BSmokeTest = false;
            obj.BIsGroup = false;
            _context.DboCredential.Add(obj);
            _context.SaveChanges();

            var credtype = _context.LkpLocalization.SingleOrDefault(m => m.Vchr128Identifier == "1" && m.NvchMaxText == "Active Directory User" && m.Vchr64LocalizationType == "Title");

            DboCredentialAlternate objAl = new DboCredentialAlternate();
            objAl.BintPrimaryCredentialId = obj.BintId;
            objAl.ICredentialTypeId = 1;
            objAl.Vchr64UserName = obj.Vchr32Name;
            objAl.DtCreated = DateTime.Now;
            objAl.Vchr256CreatedContext = string.Empty;
            objAl.BintCreatorCredentialId = 1;
            objAl.BintCreatorSpoofOfCredentialId = null;
            objAl.DtModified = DateTime.Now;
            objAl.Vchr256ModifiedContext = string.Empty;
            objAl.BintModifierCredentialId = 1;
            objAl.BintModifierSpoofOfCredentialId = null;
            objAl.BSmokeTest = false;
            _context.DboCredentialAlternate.Add(objAl);
            _context.SaveChanges();
        }
        public void CreateActiveDirectoryUserCredential(Models.LoginViewModel model)
        {
            string username = Utility.GetUserNameFromEmail(model.Email);
            DboCredential obj = new DboCredential();
            obj.Vchr32Name = username;
            obj.Nvch128Caption = username;
            //  obj.Bin64PasswordHash = string.Empty;
            obj.BEnabled = true;
            obj.DtCreated = DateTime.Now;
            obj.Vchr256CreatedContext = "Creating new Credential Record for Active Directory user";
            obj.BintCreatorCredentialId = 1;
            obj.BintCreatorSpoofOfCredentialId = null;
            obj.DtModified = DateTime.Now;
            obj.Vchr256ModifiedContext = string.Empty;
            obj.BintModifierCredentialId = 1;
            obj.BintModifierSpoofOfCredentialId = null;
            obj.BSmokeTest = false;
            obj.BIsGroup = false;
            _context.DboCredential.Add(obj);
            _context.SaveChanges();

            var credtype = _context.LkpLocalization.SingleOrDefault(m => m.Vchr128Identifier == "1" && m.NvchMaxText == "Active Directory User" && m.Vchr64LocalizationType == "Title");

            DboCredentialAlternate objAl = new DboCredentialAlternate();
            objAl.BintPrimaryCredentialId = obj.BintId;
            objAl.ICredentialTypeId = 1;
            objAl.Vchr64UserName = model.Email;
            objAl.DtCreated = DateTime.Now;
            objAl.Vchr256CreatedContext = string.Empty;
            objAl.BintCreatorCredentialId = 1;
            objAl.BintCreatorSpoofOfCredentialId = null;
            objAl.DtModified = DateTime.Now;
            objAl.Vchr256ModifiedContext = string.Empty;
            objAl.BintModifierCredentialId = 1;
            objAl.BintModifierSpoofOfCredentialId = null;
            objAl.BSmokeTest = false;
            _context.DboCredentialAlternate.Add(objAl);
            _context.SaveChanges();
        }
        public void CreateNormalUserCredential(Models.LoginViewModel model)
        {
            string username = Utility.GetUserNameFromEmail(model.Email);
            var userObject = _context.DboCredential.SingleOrDefault(m => m.Vchr32Name == username);
            if(userObject == null)
            {
                DboCredential obj = new DboCredential();
                obj.Vchr32Name = username;
                obj.Nvch128Caption = username;
                //  obj.Bin64PasswordHash = string.Empty;
                obj.BEnabled = true;
                obj.DtCreated = DateTime.Now;
                obj.Vchr256CreatedContext = string.Empty;
                obj.BintCreatorCredentialId = 1;
                obj.BintCreatorSpoofOfCredentialId = null;
                obj.DtModified = DateTime.Now;
                obj.Vchr256ModifiedContext = string.Empty;
                obj.BintModifierCredentialId = 1;
                obj.BintModifierSpoofOfCredentialId = null;
                obj.BSmokeTest = false;
                obj.BIsGroup = false;
                _context.DboCredential.Add(obj);
                _context.SaveChanges();
            }
          
        }

        public int ValidateUser(string Vchr32Name, string Password)
        {
            string sPassword = Password != null ? Password : "";
            byte[] bytes = Convert.FromBase64String(sPassword);

            var user = from c in _context.DboCredential where c.Vchr32Name == Vchr32Name && c.Bin64PasswordHash == bytes select new { c.BintId };
            //var user = from c in _context.DboCredential where c.Vchr32Name == Vchr32Name select new { c.BintId };
            int icount = user != null ? user.Count() : 0;
            return icount;
        }
       
    }
}
