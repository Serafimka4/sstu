using System;
using System.Collections.Generic;
using Entities;
using DAL;
using System.Text.RegularExpressions;

namespace BLL
{
    public enum OperationResult
    {
        OK,
        UserExists,
        UserNotFound,
        BadWords
    }
    public static class bll
    {
        public static string GetPassword(string user)
        {
            return dal.GetPassword(user);
        }

        public static List<Messege> GetMesseges(string user)
        {
            return dal.GetMesseges(user);
        }

        public static OperationResult AddUser(string user, string password, string fullName)
        {
            string pass = GetPassword(user);
            if(pass == "")
            {
                dal.AddUser(user, password, fullName);
                return OperationResult.OK;
            }
            else
            {
                return OperationResult.UserExists;
            }
        }

        public static OperationResult AddMessege(string from, string to, string sub, string body)
        {
            Regex r = new Regex(@"\b(идион)|(дурак)\b");
            string password = dal.GetPassword(to);
            if (password == "") return OperationResult.UserNotFound;
            else if (r.IsMatch(body)) return OperationResult.BadWords;
            else
            {
                dal.AddMessege(from, to, sub, body, DateTime.Now);
                return OperationResult.OK;
            }
        }
    }
}
