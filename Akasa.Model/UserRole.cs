﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Akasa.Model.Core;

namespace Akasa.Model
{
    public class UserRole : FiniteDataEntity
    {
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public int VKRole { get; set; }

        public virtual User User { get; set; }
    }
}