using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestFinerios.ConsApi
{
    public class Movements3
    {
        public string account { get; set; }
        public string amount { get; set; }
        public string balance { get; set; }
        public string concepts { get; set; }
        public string customDate { get; set; }
        public string customDescription { get; set; }
        public string date { get; set; }
        public string dateCreated { get; set; }
        public string deleted { get; set; }
        public string description { get; set; }
        public string duplicated { get; set; }
        public string hasConcepts { get; set; }
        public string id { get; set; }
        public string inResume { get; set; }
        public string lastUpdated { get; set; }
        public string type { get; set; }

    }

    public class User
    {
        public string id { get; set; }
    }

    public class Institution
    {
        public int id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string status { get; set; }
    }

    public class Account
    {
        public string id { get; set; }
        public double availableBalance { get; set; }
        public double balance { get; set; }
        public DateTime dateCreated { get; set; }
        public bool deleted { get; set; }
        public DateTime lastUpdated { get; set; }
        public string name { get; set; }
        public string number { get; set; }
        public string type { get; set; }
        public User user { get; set; }
        public Institution institution { get; set; }
    }

    public class Parent
    {
        public string id { get; set; }
    }

    public class Category
    {
        public string id { get; set; }
        public string color { get; set; }
        public string name { get; set; }
        public string textColor { get; set; }
        public Parent parent { get; set; }
    }

    public class Concept
    {
        public string id { get; set; }
        public double amount { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public object movement { get; set; }
        public Category category { get; set; }
    }

    public class Datum
    {
        public string id { get; set; }
        public double amount { get; set; }
        public double balance { get; set; }
        public DateTime customDate { get; set; }
        public string customDescription { get; set; }
        public DateTime date { get; set; }
        public DateTime dateCreated { get; set; }
        public bool deleted { get; set; }
        public string description { get; set; }
        public bool duplicated { get; set; }
        public bool hasConcepts { get; set; }
        public bool inResume { get; set; }
        public DateTime lastUpdated { get; set; }
        public string type { get; set; }
        public Account account { get; set; }
        public List<Concept> concepts { get; set; }
    }

    public class Movements
    {
        public List<Datum> data { get; set; }
        public int size { get; set; }
    }

    public class LoginApi
    {
        public string username { get; set; }
        public List<string> roles { get; set; }
        public string token_type { get; set; }
        public string access_token { get; set; }
        public int expires_in { get; set; }
        public string refresh_token { get; set; }
    }

    public class Me
    {
        public string id { get; set; }
        public bool accountExpired { get; set; }
        public bool accountLocked { get; set; }
        public int customerId { get; set; }
        public DateTime dateCreated { get; set; }
        public string email { get; set; }
        public bool enabled { get; set; }
        public DateTime lastUpdated { get; set; }
        public string name { get; set; }
        public bool notificationsEnabled { get; set; }
        public bool passwordExpired { get; set; }
        public bool signupCredentialEmailSent { get; set; }
        public bool signupCredentialPushSent { get; set; }
        public bool signupEmailSent { get; set; }
        public string signupFrom { get; set; }
        public bool termsAndConditionsAccepted { get; set; }
        public string type { get; set; }
        public string finerioCode { get; set; }
        public bool hasNewTerms { get; set; }
    }
}