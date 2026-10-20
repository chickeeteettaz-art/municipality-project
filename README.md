# Municipal Services Application

A small C# Windows Forms application for municipal service requests and local government workflows. The project demonstrates a service request tracking system with search, filtering, status updates, priority management, and a graph-based view of service locations.

## Project overview

This application is designed to help community members and staff manage service requests for municipal issues. It includes:

- Reporting and tracking service requests
- Searching by request ID, category, location, or status
- Updating status and appending progress notes
- Viewing the highest-priority request from a priority queue
- Displaying a minimum spanning tree for sample service locations

The implementation is intended as a demonstration project and uses in-memory data only. It is not a production-ready municipal management system.

## Key features

- Search and filter requests by ID, category, location, and status
- Status and priority controls for filtering the table
- Request tracking by complete ID such as `SR-2026-1001`
- Update selected request with a new status and progress note
- Inspect the highest-priority item in the priority queue
- View the minimum spanning tree (MST) for service locations
- Sample data for five demonstration requests

## Stack

- Language: C#
- UI framework: Windows Forms
- Runtime: .NET 6+ / .NET 8+ Windows Forms workload
- Architecture: class library + Windows Forms application

## Project structure

- `muni_class_library/` — class library containing data models, tree structures, graph logic, and request management
- `municipality_app/` — Windows Forms application containing the UI and interaction logic
- `README.md` — project documentation
- `municipality_app.slnx` — solution file for opening in Visual Studio

## Final project requirements

### Requirements

- Visual Studio 2022 or later
- .NET 6 or later Windows Forms workload (the supplied `Program.cs` uses `ApplicationConfiguration.Initialize()`)
- Windows operating system

### Add the files

1. Create a solution with a Class Library project named `muni_class_library` and a Windows Forms App project named `municipality_app`.
2. Use the same target framework for both projects (for example, `net8.0` and `net8.0-windows` respectively). Set `UseWindowsForms` to `true` in the Windows Forms project.
3. Add a project reference from `municipality_app` to `muni_class_library`.
4. Replace the generated `ServiceRequest.cs` class with the class library files provided in the project specification. Add `ServiceRequestStructures.cs`, `ServiceGraph.cs`, and `ServiceRequestManager.cs` to the class library.
5. Add `MainMenuForm.cs`, `ServiceRequestsWindowForm.cs`, and `ServiceRequestsWindowForm.Designer.cs` to the Windows Forms project. Remove or rename any duplicate `ServiceRequestsWindowForm` class already in your project.
6. Ensure the Windows Forms project's default namespace is `municipality_app`. Build the solution and run it.

### Use the application

- Select Service Request Status from the main menu.
- Search by request ID, category, location, or status.
- Use the status and priority drop-downs to filter the table.
- Enter a complete request ID such as `SR-2026-1001` and select Track to view details and progress history.
- Select a row and click Update selected to change the request status and append a progress note.
- Click Highest priority to inspect the top item in the priority heap.
- Click View MST to display the minimum spanning tree for the sample service locations.

The five requests are demonstration data held in memory. Changes are lost when the application closes. Replace the seed data with repository/database access for a production implementation.

### Data structures and algorithms

- Basic tree: `BasicTreeNode<T>` represents a hierarchy such as municipal department → category → request type. It is a general-purpose structure and is not used as the main request index.
- Binary tree: `BinaryTreeNode<T>` defines the left/right node shape used by binary trees.
- Binary search tree (BST): `BinarySearchTree<T>` inserts and retrieves keys according to ordering. Average operations are O(log n), but a poorly shaped tree can degrade to O(n).
- AVL tree: `AvlTree<T>` performs rotations after insertions to keep height balanced. Search and insertion are O(log n). The manager maintains request IDs in an AVL index as a demonstration of balanced indexing.
- Red-black tree: `RedBlackTree<T>` uses node colours and rotations to preserve approximate balance. Search and insertion are O(log n). It is maintained as a second ordered ID index for demonstrating the structure.
- Heap / priority queue: `RequestPriorityQueue` orders requests by priority and then submission date. Enqueue/dequeue are O(log n), peek is O(1). The queue is a snapshot of priorities at insertion time; re-enqueue or rebuild it when priorities change.
- Graph: `ServiceGraph` models connections between service locations. Breadth-first search (BFS) visits reachable locations in O(V + E).
- Minimum spanning tree (MST): Kruskal's algorithm sorts graph edges and uses disjoint sets to select low-cost connections without cycles. Sorting dominates at O(E log E). The result can help illustrate an efficient network of maintenance locations; it is not a route planner for a single vehicle.

### Testing checklist

1. Run the application and confirm that five demo requests display.
2. Search `SR-2026-1004`; confirm the Road Damage request appears.
3. Filter status to `Resolved`; confirm `SR-2026-1005` appears.
4. Track `SR-2026-1001`; confirm its history and current status display.
5. Select a request, change its status, and confirm the table reflects the change.
6. Inspect the priority queue and MST output.

### Limitations and next steps

This is a demonstration implementation, not a production municipal case-management system. The BST, AVL, and red-black trees are illustrative indexes; the dictionary provides the direct O(1) average lookup used by the form. The graph contains sample location connections, not live GIS road data. For production, add SQL Server persistence, authentication and authorisation, input validation, audit logging, unit tests, and role-based permissions. Only authorised staff should be able to change a request's status.

## How to build and run

### Prerequisites

- .NET 10 SDK installed (match the project's target framework)
- Windows machine to run WinForms applications
- Optional: Visual Studio 2022 or later

### From a fresh clone

1. Restore and build:
   - `dotnet restore`
   - `dotnet build`
2. Run the WinForms app:
   - `dotnet run --project municipality_app/municipality_app.csproj`

Or open `municipality_app.slnx` (or the solution/project in Visual Studio) and press F5.

## Usage notes

- The service request form requires a valid request ID, priority, and request details.
- Submitted requests are added to an in-memory collection and will be lost when the application exits.
- The application is a demonstration of data structures and UI flow rather than a complete production workflow.

## Development notes and suggestions

- Persistence: add simple persistence with JSON, SQLite, or a database if requests must survive application restarts.
- Announcements and events: implement the necessary models, UI, and persistence if expanded features are required.
- File handling: consider validating file size and type for uploaded documents.
- Packaging: create an installer or publish profile for easier distribution to Windows users.

## Contributing

- Open an issue or submit a PR to improve persistence, complete the announcements or service workflow, or add stronger validation and auditing.
- Keep backward compatibility when changing request model fields and related logic.

## Summary

This project combines a WinForms-based municipal service request UI with a teaching-focused implementation of several data structures and algorithms, including BSTs, AVL trees, red-black trees, heaps, and graph-based MST generation. It is an effective demonstration of both application design and computer science concepts relevant to municipal service tracking.
