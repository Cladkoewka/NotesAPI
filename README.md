# .NET Core 8 Web API - Notes Management

## About The Project

This project is a **.NET Core 8 Web API** built with a three-level architecture. It provides CRUD operations for managing notes, allowing users to create, read, update, and delete notes efficiently.

---

## Endpoints

### 1. Create a Note

- **Method:** `POST`
- **URL:** `/Note`
- **Request Body:**
    ```json
    {
      "text": "Your note"
    }
    ```
- **Response:**
  - `204 No Content` - Note successfully created.

---

### 2. Get a Note by ID

- **Method:** `GET`
- **URL:** `/Note/{id}`
- **Parameters:**
  - `id` (int) - The ID of the note to retrieve.
- **Response:**
  - `200 OK` - Returns the requested note.
  - `404 Not Found` - Note with the specified ID not found.

---

### 3. Update a Note

- **Method:** `PUT`
- **URL:** `/Note/{id}`
- **Parameters:**
  - `id` (int) - The ID of the note to update.
- **Request Body:**
    ```json
    {
      "newText": "Your updated note"
    }
    ```
- **Response:**
  - `204 No Content` - Note successfully updated.
  - `404 Not Found` - Note with the specified ID not found.

---

### 4. Delete a Note

- **Method:** `DELETE`
- **URL:** `/Note/{id}`
- **Parameters:**
  - `id` (int) - The ID of the note to delete.
- **Response:**
  - `204 No Content` - Note successfully deleted.
  - `404 Not Found` - Note with the specified ID not found.

---

## Getting Started

To get a local copy up and running follow these simple steps.

### Prerequisites

- .NET Core 8 SDK
- Any code editor (e.g., Visual Studio, Visual Studio Code)




