# ThinkPad Web API

## Description
This project is a **Web API** built with **.NET Core** to manage information about ThinkPad laptops. It enables CRUD operations (Create, Read, Update, Delete) on a local database using **Entity Framework Core** and **SQL Server**. The API is documented and tested using **Swagger** for easy interaction.

---

## Technologies Used
- **.NET Core**: Framework for modern web application development.
- **Entity Framework Core**: ORM for database interaction.
- **SQL Server**: Relational database for data storage.
- **Swagger**: Tool for API documentation and testing.

---

## Features
1. **GET /thinkpads**:
   - Retrieves all ThinkPad laptop records stored in the database.
2. **POST /thinkpads**:
   - Creates a new ThinkPad record in the database.
3. **PUT /thinkpads/{id}**:
   - Updates an existing ThinkPad record.
4. **DELETE /thinkpads/{id}**:
   - Deletes a ThinkPad record by its ID.

---

## Requirements
- **.NET SDK** installed on the system.
- **SQL Server** configured locally.
- Optionally: A client like **Swagger** to test endpoints.

---

## Setup Instructions
1. Clone the repository:
   ```bash
   git clone https://github.com/Goruchie/WebApiThinkPad/edit/master/README.md
