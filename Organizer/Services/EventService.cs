using System;
using Organizer.Models;

namespace Organizer.Services
{
	public class EventService
	{
		public List<EventList> eventsList = new List<EventList>();

		public EventService()
		{
			eventsList.Add(new EventList
			{
				Id = 1,
				Title = "Zajęcia taneczne",
				Details = "Tango",
				StartDateTime = new DateTime(2023, 8, 8,21,00,00),
				EndDateTime = new DateTime(2023, 8, 8,22,00,00),
			});
		}
	}
}

