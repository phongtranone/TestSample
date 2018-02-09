using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace testSampleOne.Parser.LocationElements
{
    class LoginElements : Elements
    {
        Node username = new Node();
        Node password = new Node();
        Node rememberMe = new Node();
        Node loginBtn = new Node();

        public LoginElements(string path) : base(path)
        {
        }

        public By GetUsername()
        {
            username = GetNodeByKey("Username");
            return ConvertToAttribute(username.Type, username.Value);
        }

        public By GetPassword()
        {
            password = GetNodeByKey("Password");
            return ConvertToAttribute(password.Type, password.Value);
        }

        public By GetRememberMe()
        {
            rememberMe = GetNodeByKey("RememberMe");
            return ConvertToAttribute(rememberMe.Type, rememberMe.Value);
        }

        public By GetLoginButton()
        {
            loginBtn = GetNodeByKey("LoginButton");
            return ConvertToAttribute(loginBtn.Type, loginBtn.Value);
        }
    }
}
