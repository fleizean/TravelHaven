using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
	public class Destination
	{
        [Key]
        public int DestinationID { get; set; }
		public string City { get; set; }
		public string StayDuration { get; set; }
		public double Price { get; set; }
		public string Image { get; set; }
		public string Description { get; set; }
		public int Capacity { get; set; }
		public bool Status { get; set; }
        public string CoverImage { get; set; }
		public string AuthorWord { get; set; }
        public string DetailsComment { get; set; }
		public string DetailsComment2 { get; set; }
		public string Image2 { get; set; }
		public List<Comment> Comments { get; set; }
	}
}

