﻿using DemoApp.Domain.Models.Commons;

namespace Demo.Domain.ApplicationServices.Users
{
    public class UserSearchQuery : SearchQuery
    {
        public bool IsSystemUser { get; set; }
    }
}