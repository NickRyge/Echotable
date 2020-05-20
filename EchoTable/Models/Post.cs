using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PopoErEnLuder.Models
{
    public class Post
    {

        public int Id { get; set; }
        
        public String Header { get; set; } 
        
        public String Content { get; set; }

        public DateTime TimeStamp { get; set; }

        public String imgAdress { get; set; }
    }
}
