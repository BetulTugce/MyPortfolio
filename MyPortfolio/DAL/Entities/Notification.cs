﻿using MyPortfolio.DAL.Entities.Common;

namespace MyPortfolio.DAL.Entities
{
    public class Notification : BaseEntity
    {
        public string Content { get; set; }

        public string ImageUrl { get; set; }

        public bool Status { get; set; }
    }
}
