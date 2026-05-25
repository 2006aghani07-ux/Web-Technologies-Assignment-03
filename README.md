# Web-Technologies-Assignment-03
# Student Record Manager
A simple full-stack CRUD web application built using ASP.NET Core Web API, MongoDB, and HTML/CSS/JavaScript.
This project allows users to Create, Read, Update, and Delete student records.
# Technologies Used
1. Backend: ASP.NET Core Web API
2. Database: MongoDB
3. Frontend: HTML, CSS, JavaScript
4. API Testing: Thunder Client / Postman
5. IDE: Visual Studio Code
# Features
 1. Add new student
 2. View all students
 3. Update existing student
 4. Delete student
 5. REST API integration
 6. MongoDB database storage
 7. Form validation (frontend)
# API Endpoints
Method		         Description
1. GET		         Get all students
2. POST		        Add new student
3. PUT		         Update student
4. DELETE		      Delete student
# Database Configuration
"StudentDatabase": {
  "ConnectionString": "mongodb://localhost:27017",
  "DatabaseName": "studentsdb",
  "StudentsCollectionName": "students"
}
