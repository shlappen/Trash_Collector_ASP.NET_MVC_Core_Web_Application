using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

        [ForeignKey("CollectionDay")]
        [Display(Name = "Collection Day")]
        public int CollectionDayId { get; set; }
        public CollectionDay Day { get; set; }

        [NotMapped]
        public IEnumerable<CollectionDay> Days { get; set; }

    }
}
