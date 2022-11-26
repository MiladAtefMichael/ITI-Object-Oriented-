using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Authenticate
    {
        public Student Std{ get; set; }
        public bool Login(string username, string useremail, string userpass) 
        {
            Std.UserName= username; 
            if(Login(useremail, userpass) && Std.UserName == null)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
        public bool Login (string useremail, string userpass)
        {
            Std.UserEmail=useremail;

            Std.UserPass=userpass;
            if (Std.UserPass == null && Std.UserEmail == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool Login( string userpass, int id)
        {
            Std.Id = id;

            Std.UserPass = userpass;
            if (Std.UserPass == null && Std.Id == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool Login(int id, string email)
        {
            Std.Id = id;

            Std.UserEmail= email;
            if (Std.UserEmail == null && Std.Id == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public string ForgetPassword(string username)
        {
            if (Std.UserName == username)
            {
                return Std.UserPass;
            }
            else
            {
                return "user not found";
            }
        }
        public string ForgetPassword(string useremail,int id)
        {
            if (Std.UserEmail == useremail&&Std.Id==id)
            {
                return Std.UserPass;
            }
            else
            {
                return "user not found";
            }
        }
        public string ForgetPassword( int id)
        {
            if ( Std.Id == id)
            {
                return Std.UserPass;
            }
            else
            {
                return "user not found";
            }
        }
        public bool ResetPassword(int id ,string oldpassword,string newpassword )
        {
            if (Std.Id == id&&Std.Password==oldpassword)
            {
                Std.Password = newpassword;
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool ResetPassword(string useremail, string oldpassword, string newpassword)
        {
            if (Std.UserEmail == useremail && Std.Password == oldpassword)
            {
                Std.Password = newpassword;
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool ResetPassword(int id,string username, string oldpassword, string newpassword)
        {
            if (Std.UserName == username&&Std.Id==id && Std.Password == oldpassword)
            {
                Std.Password = newpassword;
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
