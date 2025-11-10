using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeController
{
    public class User
    {
        //private fields 
        private int userid;
        private string username;
        private string password;
        private string contactinfo;
        private bool isLoggedIn;

        public int UserID
        {
            get { return userid; }
            set { userid = value; }
        }
        public string UserName
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string ContactInfo
        {
            get { return contactinfo; }
            set { contactinfo = value; }
        }
        public bool IsLoggedIn
        {
            get { return isLoggedIn; }
            set { isLoggedIn = value; }
        }

        public bool Login(string username, string password)
        {
            // Simulate login process
            if (username == this.username && password == this.password)
            {
                isLoggedIn = true;
                Console.WriteLine("Login successful.");
            }
            else
            {
                isLoggedIn = false;
                Console.WriteLine("Login failed. Invalid username or password.");
            }
            return isLoggedIn;
        }
        public void Logout()
        {
            if (isLoggedIn)
            {
                isLoggedIn = false;
                Console.WriteLine("User logged out.");
            }
            else
            {
                Console.WriteLine("User is not logged in.");
            }
        }
        public void ControlDevice(int deviceID, string deviceName, string deviceAction)
        {
            if (isLoggedIn)
            {
                Console.WriteLine($"User {username} is performing action '{deviceAction}' on device '{deviceName}' (ID: {deviceID}).");
                // Simulate device control logic here
            }
            else
            {
                Console.WriteLine("User must be logged in to control devices.");
            }
        }
        public User(int userid, string username, string password, string contactinfo)
        {
            this.userid = userid;
            this.username = username;
            this.password = password;
            this.contactinfo = contactinfo;
            this.isLoggedIn = false;
        }

    }
}
