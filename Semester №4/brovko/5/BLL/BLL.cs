using DAL;
using Entities;
using System;
using System.Collections.Generic;
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

    public static class Bll
    {
        public static string GetPassword(string user)
        {
            return Dal.GetPassword(user);
        }

        public static List<Message> GetMesseges(string user)
        {
            return Dal.GetMesseges(user);
        }

        public static OperationResult AddUser(string user, string password, string fullName)
        {
            if (GetPassword(user) == "")
            {
                Dal.AddUser(user, password, fullName);
                return OperationResult.OK;
            }
            else
            {
                return OperationResult.UserExists;
            }
        }

        public static OperationResult AddMessege(string from, string to, string sub, string body)
        {
            Regex r = new Regex(@"\b(fuck)|(idiot)\b");

            if (Dal.GetPassword(to) == "")
            {
                return OperationResult.UserNotFound;
            }
            else if (r.IsMatch(body))
            {
                return OperationResult.BadWords;
            }
            else
            {
                Dal.AddMessege(from, to, sub, body, DateTime.Now);
                return OperationResult.OK;
            }
        }
    }
}
