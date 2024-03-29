﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuardKey.Models
{
    [Table("UserRecord")]
    public class UserRecord
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string SourceGroupName { get; set; }
        public string ResourceName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }

    }
}
