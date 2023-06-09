﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Big_Pool
{
    internal class User
    {
        private string Password;
        private string UserName;
        private string Fname="John";
        private string Lname="Fortnite";
        private string Email="John@fortnite.com";
        private string skill = "Garnet";
        private string duration = "01:00:00";
        private int Distance = 1500;
        public User(string u, string p)
        {
            UserName = u;
            Password = p;
        }
        public string get_Fname()
        { return Fname; }
        public string get_Lname()
        { return Lname; }
        public string get_Email()
        { return Email; }
        public string get_skill()
        { return skill; }
        public string get_duration()
        { return duration; }
        public int get_Distance()
        { return Distance;}
        public void set_skill(string s)
        { skill = s; }
        public void set_duration(string s)
        { duration = s; }
        public void set_distance(int i)
        { Distance = i; }
        public void set_Fname(string f) { Fname = f; }
        public void set_Lname(string l) { Lname = l; }
        public void set_Email(string s) {  Email = s; }
        public string failurecause()
        {
            string f = "";
            if (UserName.Length < 5)
            {
                f += "Username is under 5 characters";
            }
            if (Password.Length < 8)
                f += "Password is under 8 characters \n";
            if (!Password.Any(c => char.IsDigit(c)))
                f += "Password does not contain a numeric character \n";
            if (!Password.Any(c => char.IsUpper(c)))
                f += "Password does not conatin a capital letter \n";
            return f;
        }
        public string hash_password()
        {
            return BCrypt.Net.BCrypt.HashPassword(Password);
        }
    }
}
