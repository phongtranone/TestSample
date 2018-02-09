using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace testSampleOne.Parser.LocationElements
{
    [XmlRoot("Login")]
    public class LoginElements11
    {
        private Username username;
        private Password password;
        private RememberMe rememberMe;
        private LoginButton loginButton;
       

        [XmlElement("Username")]
        public Username Username
        {
            get { return username; }
            set { username = value; }
        }

        [XmlElement("Password")]
        public Password Password
        {
            get { return password; }
            set { password = value; }
        }

        [XmlElement("RememberMe")]
        public RememberMe RememberMe
        {
            get { return rememberMe; }
            set { rememberMe = value; }
        }

        [XmlElement("LoginButton")]
        public LoginButton LoginButton
        {
            get { return loginButton; }
            set { loginButton = value; }
        }
    }

    public class Username
    {
        private string nameValue;
        private string elementType;

        [XmlAttribute("name")]
        public string Name
        {
            get { return elementType; }
            set { elementType = value; }
        }

        [XmlText()]
        public string Value
        {
            get { return nameValue; }
            set { nameValue = value; }
        }

    }

    public class Password
    {
        private string nameValue;
        private string elementType;

        [XmlAttribute("name")]
        public string Name
        {
            get { return elementType; }
            set { elementType = value; }
        }

        [XmlText()]
        public string Value
        {
            get { return nameValue; }
            set { nameValue = value; }
        }

    }

    public class RememberMe
    {
        private string nameValue;
        private string elementType;

        [XmlAttribute("name")]
        public string Name
        {
            get { return elementType; }
            set { elementType = value; }
        }

        [XmlText()]
        public string Value
        {
            get { return nameValue; }
            set { nameValue = value; }
        }

    }

    public class LoginButton
    {
        private string nameValue;
        private string elementType;

        [XmlAttribute("name")]
        public string Name
        {
            get { return elementType; }
            set { elementType = value; }
        }

        [XmlText()]
        public string Value
        {
            get { return nameValue; }
            set { nameValue = value; }
        }

    }
}
