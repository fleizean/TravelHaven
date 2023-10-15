using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
	public class Comment
	{

        [Key]
        public int CommentID { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public bool Status { get; set; }
        public int DestinationID { get; set; }
        public Destination Destination { get; set; }
    }
}

