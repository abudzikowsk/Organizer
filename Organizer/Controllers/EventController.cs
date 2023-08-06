using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Organizer.Models;
using Organizer.Services;

namespace Organizer.Controllers
{
	[ApiController]
	[Route("event")]
    public class EventController : ControllerBase
	{
        private readonly EventService eventService;

        public EventController(EventService eventService)
		{
			this.eventService = eventService;
		}

		[HttpGet]
		[Route("list")]
		public List<EventList> GetEvents()
		{
			return eventService.eventsList;
        }

		[HttpPost]
		[Route("add")]
		public void AddEvent(AddEvent addEvent)
		{
			eventService.eventsList.Add(new EventList
			{
				Id = eventService.eventsList.Count+1,
				Title = addEvent.Title,
				Details = addEvent.Details,
				StartDateTime = addEvent.StartDateTime,
				EndDateTime = addEvent.EndDateTime
			});
        }

		[HttpPost]
		[Route("edit-details")]
		public IActionResult EditEventDetails(EditEventDetails editEventDetails)
		{
            var eventToEdit = eventService.eventsList.SingleOrDefault(x => x.Id == editEventDetails.Id);
			if(eventToEdit is null)
			{
				return NotFound();
			}
			eventToEdit.Details = editEventDetails.Details;

			return Ok();
		}

		[HttpPost]
		[Route("delete")]
		public IActionResult DeleteEvent(DeleteEventModel deleteEventModel)
		{
			var eventToDelete = eventService.eventsList.SingleOrDefault(y => y.Id == deleteEventModel.Id);
			if(eventToDelete == null)
			{
				return NotFound();
			}

            eventService.eventsList.Remove(eventToDelete);

			return Ok();
		}

	}
}

