﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Membership1.Entities
{
    [Table("UserSubscription")]
    public class UserSubscription { 

        [Required]
        [Key, Column(Order = 1)]
        public int  SubscriptionId { get; set; }

          [Required]
          [MaxLength(128)]
          [Key, Column(Order = 2)]
        public string UserId { get; set; }

        public DateTime? StartDate{ get; set; }

        public DateTime? EndDate { get; set; }



    }
}