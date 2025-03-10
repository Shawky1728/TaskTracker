# Task Tracker

## Description

Task Tracker is a simple console-based task management application written in C#. It allows users to add tasks, view all tasks, mark tasks as complete, and remove tasks. The program runs in a loop until the user decides to exit.

## Features

- Add new tasks
- View all tasks
- Mark tasks as completed
- Delete tasks
- Simple console-based user interface

## Installation and Usage

### Prerequisites

- .NET SDK installed on your machine

### Steps to Run

1. Clone the repository or copy the code into a new C# project.
2. Open the project in a C# development environment like Visual Studio.
3. Build and run the application.

### Running the Application

Once the application is running, you will see a menu:

```
Welcome to my task tracker
----------------------------------------
1. Add task
2. View all tasks
3. Mark task complete
4. Remove task
5. Exit
```

You can enter a number corresponding to your choice and follow the instructions.

## How It Works

1. **Adding a Task:** Enter a task title, and it will be stored in the array.
2. **Viewing All Tasks:** Displays all tasks stored.
3. **Marking a Task as Completed:** Enter the task number, and it will be marked as "Completed".
4. **Deleting a Task:** Enter the task number to remove it from the list.
5. **Exiting:** Exits the program.

## Limitations

- Uses a fixed-size array of 100 tasks.
- Tasks are stored only during runtime (no persistence).

## Future Improvements

- Store tasks in a file or database for persistence.
- Improve UI with a graphical interface.
- Implement task categories and due dates.

## License

This project is open-source and available for modification and use under the MIT License.

---

Enjoy using Task Tracker!

