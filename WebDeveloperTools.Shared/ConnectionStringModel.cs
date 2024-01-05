﻿namespace WebDeveloperTools.Shared
{
    public class ConnectionStringModel
    {
        public string Server { get; set; }
        public string Database { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsSecureConnection { get; set; }
    }
}
