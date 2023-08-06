using System;
namespace Organizer.Models
{
	public class EventList
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Details { get; set; }
		public DateTime StartDateTime { get; set; }
		public DateTime EndDateTime { get; set; }
	}
}

