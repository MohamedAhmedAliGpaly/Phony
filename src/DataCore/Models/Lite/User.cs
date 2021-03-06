﻿using Phony.Data.Core;
using System;

namespace Phony.Data.Models.Lite
{
    public class User
    {
        private DateTime createdAt;
        private DateTime editedAt;

        public User()
        {
            EditedAt = DateTime.Now;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Pass { get; set; }

        public UserGroup Group { get; set; }

        public string Phone { get; set; }

        public string Notes { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedAt { get => createdAt.ToLocalTime(); set => createdAt = value.ToUniversalTime(); }

        public DateTime EditedAt { get => editedAt.ToLocalTime(); set => editedAt = value.ToUniversalTime(); }
    }
}