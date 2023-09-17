# Organizer

## Project Overview

Organizer is a comprehensive calendar application that helps users manage their events and schedules efficiently. This project, built using .NET 7, includes various features and functionalities implemented in the controller to facilitate event management. It utilizes an in-memory database to store event data temporarily.

## Features

1. **Calendar Views**
   - Monthly View: Users can view their events on a monthly calendar, providing an overview of the entire month.
   - Weekly View: Users can switch to a weekly view to focus on events for a specific week.
   - Daily View: A daily view is available for users who want to see their events on a day-to-day basis.

2. **Event Management**
   - Add Events: Users can add new events to their calendar, providing essential details such as title, date, time, and location.
   - Edit Events: Existing events can be edited, allowing users to update event details as needed.
   - Delete Events: Users have the option to remove events from their calendar when they are no longer relevant.

3. **Event Details**
   - Event Notes: Users can attach text-based notes to individual events, making it easy to store additional information or reminders related to the event.
   - Flexible Editing: Event notes can be edited at any time to accommodate changes or updates.

## Controller Functionalities

The primary functionalities implemented in the controller include:

- **EventController.cs**
  - List Events: Provides an API endpoint to retrieve a list of all events.
  - Add Event: Allows users to create new events and add them to their calendar.
  - Edit Event Details: Provides the capability to edit event details, including event notes.
  - Delete Event: Enables users to remove events from their calendar.

## Getting Started

To get started with the Organizer application, follow these steps:

1. Clone this repository to your local machine.
2. Open the Organizer.sln solution file in Visual Studio or your preferred development environment.
3. Build and run the project to start the application.
4. Access the Swagger documentation at the specified URL to interact with the API and explore the features.
