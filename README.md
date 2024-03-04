# Clinic Appointment System

This is an appointment system created in dotnet core (MVC) using c#. The Clinic Appointment System aims to streamline the scheduling process for medical appointments.

## Project Description

### Goals and Functionalities:

* User management for Patients and Doctors.
* Patient management for creating, updating, and deleting patient profiles.
* Doctor management for creating, updating, and deleting patient profiles profiles.
* Categorizing doctors into different medical departments.
* Appointment scheduling to allow patients to book appointments with specific doctors.
* Account and email system for sending confirmation emails to patients and doctors.

## User Roles and Permissions:
Users can signup their profile and receive a confirmation email.

### Patient:
* Can manage their own profile.
* Can schedule and manage appointments.

### Doctor:
* Can manage their own profile.
* Can manage appointments with patients.

## Technologies Used:

Backend Framework: .NET Core (C#) is utilized for building the RESTful backend service.
Database: SQLite is chosen for data storage.

* Entity Framework handles data access.
* Identity Framework manages user authentication.
* JWT tokens secure API requests.
* Dependency Injection enhances code organization.
* Logging is implemented for users.

### Pre-requisites:
* Microsoft Visual Studio Code.
* Postman for testing
* Dotnet framework.

## Implementation of .NET Core RESTful Backend Service:

### Controllers
The system includes controllers for user management, patient management, doctor management, and appointment scheduling. These controllers implement CRUD operations for relevant entities.

### Models
* User representing patients and doctors.
* Patient storing patient-specific information.
* Doctor storing doctor-specific information.
* Appointment connecting patients and doctors for scheduled appointments.
* Department categorizing doctors into medical departments.
* Bill to invoice the patients for the service.

### Dependency Injection and Logging
Dependency Injection is employed for better code organization, and logging is implemented to track application events.

## Database Design: 
<img src="../CourseWork/WebApi.png"/>

## How to Run
1. Install Microsoft Visual Studio Code, Postman and dotnet framework 8.0.2 stable release.

2. Open the project in Microsoft Visual Studio Code and run the following command; "dotnet run".

3. Run the localhost port number provided in terminal on postman.