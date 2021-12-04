using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DataAccess.Entities
{
    public class User : IdentityUser
    {
        [MaxLength(50)]
        public override string UserName { get; set; }

        public new Guid Id { get; set; }

        public ICollection<TrackList> TrackLists { get; set; }
    }
}
