using System;
using System.ComponentModel;
using System.Linq;

namespace System10.Models
{
    public class BusinessLayer
    {
        private readonly System10Context _context;
        public BusinessLayer(System10Context context )
        {
            _context = context;
        }

        public void CreateWindowsUserCredential(string winLoginName,string username)
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
            objAl.Vchr64UserName = username;
            objAl.DtCreated = DateTime.Now;
            objAl.Vchr256CreatedContext = "Creating new Credential Alternate Record for Active Directory user";
            objAl.BintCreatorCredentialId = 1;
            objAl.BintCreatorSpoofOfCredentialId = null;
            objAl.DtModified = DateTime.Now;
            objAl.Vchr256ModifiedContext = string.Empty;
            objAl.BintModifierCredentialId = 1;
            objAl.BintModifierSpoofOfCredentialId = null;
            objAl.BSmokeTest = false;
            _context.DboCredentialAlternate.Add(objAl);
            _context.SaveChanges();

            DboCredentialHierarchy dbH = new DboCredentialHierarchy();
            dbH.BintParentCredentialId= obj.BintId;
            dbH.BintChildCredentialId= obj.BintId;
            dbH.DtCreated = DateTime.Now;
            dbH.Vchr256CreatedContext = "Creating new Hierarchy for Active Directory user";
            dbH.BintCreatorCredentialId = 1;
            dbH.BintCreatorSpoofOfCredentialId = null;
            dbH.DtModified = DateTime.Now;
            dbH.Vchr256ModifiedContext = "";
            dbH.BintModifierCredentialId = 1;
            dbH.BintModifierSpoofOfCredentialId = null;
            dbH.BSmokeTest = false;
            _context.DboCredentialHierarchy.Add(dbH);
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
            objAl.Vchr256CreatedContext = "Creating new Credential Alternate Record for Active Directory user";
            objAl.BintCreatorCredentialId = 1;
            objAl.BintCreatorSpoofOfCredentialId = null;
            objAl.DtModified = DateTime.Now;
            objAl.Vchr256ModifiedContext = string.Empty;
            objAl.BintModifierCredentialId = 1;
            objAl.BintModifierSpoofOfCredentialId = null;
            objAl.BSmokeTest = false;
            _context.DboCredentialAlternate.Add(objAl);
            _context.SaveChanges();

            DboCredentialHierarchy dbH = new DboCredentialHierarchy();
            dbH.BintParentCredentialId = obj.BintId;
            dbH.BintChildCredentialId = obj.BintId;
            dbH.DtCreated = DateTime.Now;
            dbH.Vchr256CreatedContext = "Creating new Hierarchy for Active Directory user";
            dbH.BintCreatorCredentialId = 1;
            dbH.BintCreatorSpoofOfCredentialId = null;
            dbH.DtModified = DateTime.Now;
            dbH.Vchr256ModifiedContext = "";
            dbH.BintModifierCredentialId = 1;
            dbH.BintModifierSpoofOfCredentialId = null;
            dbH.BSmokeTest = false;
            _context.DboCredentialHierarchy.Add(dbH);
            _context.SaveChanges();
        }
        public void CreateNormalUserCredential(string username, long credentialID)
        {

            var userObject = _context.DboCredential.SingleOrDefault(m => m.Vchr32Name == username);
            if (userObject != null)
            {

                userObject.BEnabled = true;
                _context.DboCredential.Update(userObject);
                _context.SaveChanges();

                DboCredentialHierarchy dbH = new DboCredentialHierarchy();
                dbH.BintParentCredentialId = credentialID;
                dbH.BintChildCredentialId = userObject.BintId;
                dbH.DtCreated = DateTime.Now;
                dbH.Vchr256CreatedContext = "Creating new Hierarchy for System10 user";
                dbH.BintCreatorCredentialId = 1;
                dbH.BintCreatorSpoofOfCredentialId = null;
                dbH.DtModified = DateTime.Now;
                dbH.Vchr256ModifiedContext = "";
                dbH.BintModifierCredentialId = 1;
                dbH.BintModifierSpoofOfCredentialId = null;
                dbH.BSmokeTest = false;
                _context.DboCredentialHierarchy.Add(dbH);
                _context.SaveChanges();
            }
          
        }

        //System10 user validation
        public int ValidateUser(string Vchr32Name, string Password)
        {
            string sPassword = Password != null ? Password : "";
            byte[] bytes = System.Text.Encoding.Unicode.GetBytes(sPassword);
           // byte[] bytes = Convert.FromBase64String(sPassword);

            var user = from c in _context.DboCredential where c.Vchr32Name == Vchr32Name && c.Bin64PasswordHash == bytes select new { c.BintId };
            //var user = from c in _context.DboCredential where c.Vchr32Name == Vchr32Name select new { c.BintId };
            int icount = user != null ? user.Count() : 0;
            return icount;
        }

        public void CreateOAuthUserCredential(string email,long id,string provider)
        {
            // string username = Utility.GetUserNameFromEmail(model.Email);
            LkpLocalization objLoc = _context.LkpLocalization.SingleOrDefault(m=>m.ILocalizationSetId==1 && m.NvchMaxText==provider && m.Vchr64LocalizationType=="Title");

            DboCredentialAlternate objAl = new DboCredentialAlternate();
            objAl.BintPrimaryCredentialId = id;
            objAl.ICredentialTypeId =Convert.ToInt32 (objLoc.Vchr128Identifier);
            objAl.Vchr64UserName = email;
            objAl.DtCreated = DateTime.Now;
            objAl.Vchr256CreatedContext = "Creating new OAuth for user";
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

        public void SaveEmailVerification(string email, string token)
        {
            DboEmailVerification dbEmV = new DboEmailVerification();
            dbEmV.Nvch128Email = email;
            dbEmV.Vchr250Token = token;
            dbEmV.BEnabled = true;
            dbEmV.DtCreated = DateTime.Now;
            dbEmV.Vchr256CreatedContext = "Creating new Email verification for System10 user";
            dbEmV.BintCreatorCredentialId = 1;
            dbEmV.BintCreatorSpoofOfCredentialId = null;
            dbEmV.DtModified = DateTime.Now;
            dbEmV.Vchr256ModifiedContext = string.Empty;
            dbEmV.BintModifierCredentialId = 1;
            dbEmV.BintModifierSpoofOfCredentialId = null;
            dbEmV.BSmokeTest = false;
            _context.DboEmailVerification.Add(dbEmV);
            _context.SaveChanges();

        }

        public void CreateNewInactiveUserCredential(RegisterviewModel model)
        {
           
          
                DboCredential obj = new DboCredential();
                obj.Vchr32Name = model.UserName;
                obj.Nvch128Caption = model.UserName;
                obj.Bin64PasswordHash = System.Text.Encoding.Unicode.GetBytes(model.Password);
                obj.BEnabled = false;
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
        }

        public int GetSocialNetworkType(string type)
        {
            switch((CredentialType)Enum.Parse(typeof(CredentialType), type))
            {
                case CredentialType.Google:
                    return (int)CredentialType.Google;
                case CredentialType.Twitter:
                    return (int)CredentialType.Twitter;
                default:
                    return (int)CredentialType.Google;
            }
        }

        }
    public enum CredentialType
    {
        [Description("1")]
        Google=1,
        [Description("2")]
        Twitter=2
    }
}

