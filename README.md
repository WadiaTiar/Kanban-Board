##Kanban Board

Kanban Board is a simple Windows desktop application built with C# and SQL Server that helps users manage and organize tasks visually using the Kanban method.

This project is designed especially for fresh developers who want to learn how a real desktop application works with a database.


---

🔄 Project Evolution (What’s New)

The previous version of this project was based on static panels, where task columns were fixed and could not be changed.

In this new version, the application is more flexible and usable:

You can add as many status columns as you want

You can change the order (index) of columns easily

Columns are no longer hard-coded

The board adapts dynamically to user needs


This makes the application closer to a real-world Kanban system.


---

🧩 Features

Create, edit, and delete tasks easily

Add, rename, and remove custom status columns

Reorder columns dynamically

Organize tasks into columns (To Do, In Progress, Done, or custom ones)

Drag and drop tasks between columns

Save tasks using a local SQL Server database

Database backup included (.bak file)

Clean and user-friendly interface for beginners



---

⚙️ Installation

1. Clone this repository:

git clone https://github.com/WadiaTiar/Kanban-Board.git


2. Open the project in Visual Studio:

KanbanBoard.sln


3. Build the solution:

Ctrl + Shift + B


4. Run the application:

F5  or  Ctrl + F5




---

💾 Database

The application uses a local SQL Server database

A database backup file KanbanDB.bak is included

You can restore it using SQL Server Management Studio (SSMS)



---

🧠 How to Restore the Database

1. Open SQL Server Management Studio


2. Connect to your local SQL Server


3. Right-click Databases → Restore Database


4. Choose Device → Browse → Add


5. Select KanbanDB.bak


6. Click OK to restore




---

🎯 Who This Project Is For

Beginner C# developers

Students learning desktop applications

Anyone wanting a simple Kanban system

Developers learning Git & GitHub versioning


## 👩‍💻 Author
Wadia Tiar
