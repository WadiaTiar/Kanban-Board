# Kanban Board

Kanban Board is a simple Windows desktop application built with **C#** that helps users organize tasks visually using the Kanban method.

## 🧩 Features
- Create, edit, and delete tasks easily  
- Organize tasks into columns (New Task, Scheduled, In Progress, Complete)  
- Drag and drop tasks between columns  
- Save your tasks with a local database backup (`.bak` file)  
- Clean and user-friendly interface for beginners  

## ⚙️ Installation
1. Clone this repository:
   ```bash
   git clone https://github.com/WadiaTiar/Kanban-Board.git
2. Open the project in Visual Studio (KanbanBoard.sln)

3. Build the solution (Ctrl + Shift + B)

4. Run the app (F5 or Ctrl + F5)

## 💾 Database
1. The app uses a local SQL Server database.

2. A backup file KanbanDB.bak is included.

3. You can restore it using SQL Server Management Studio (SSMS).

## 🧠 How to Restore the Database
1. Open SQL Server Management Studio

2. Connect to your local server

3. Right-click Databases → Restore Database

4. Choose Device → Browse → Add → KanbanBoard_Database.bak

5. Click OK to restore

## 👩‍💻 Author
Wadia Tiar
