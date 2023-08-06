using System;
namespace Organizer.Models
{
	public class AddEvent
	{
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
    }
}