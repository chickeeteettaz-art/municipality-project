# municipality-app

A small C# WinForms application for community members to interact with their local municipality. It provides three core services: reporting issues, browsing announcements & events, and requesting services. The UI uses MaterialSkin for a modern look-and-feel and the project is split into a WinForms application and a lightweight class library for domain models.

## Key features
- Report issues (title, location, description, category) with optional file upload.
- Service request form with progress tracking and validation.
- Announcements window (UI available).
- Simple in-memory storage of submitted reports (List<IssueReport>).
- File uploads are copied to an "Uploads" folder inside the application's startup path.

## Stack
- Language: C#
- Framework / runtime: .NET 10 (TargetFramework: net10.0)
- UI: Windows Forms (WinForms) with MaterialSkin (MaterialSkin.Controls)

Notable code elements (from the repository)
- muni-class-library/IssueReport.cs — IssueReport model with IssueId, Title, Location, Description, FilePath, IssueCategory.
- municipality-app — WinForms project with:
  - Program.cs — application entry point that runs Form1.
  - Form1.cs — main window (MaterialForm) with buttons for the three primary services; Service Request button opens ServiceRequestForm.
  - ServiceRequestForm.cs — form that collects issue/service request details, handles file upload and progress bar validation; stores reports in a List<IssueReport>.
  - AnnouncementWindow.cs — a MaterialForm ready for announcements UI.
- File uploads: ServiceRequestForm copies selected files to Path.Combine(Application.StartupPath, "Uploads").

## Project layout (top-level)
```
.muni-class-library/         C# class library with domain models (IssueReport)
municipality-app/            WinForms application (Program.cs, Form1, ServiceRequestForm, AnnouncementWindow, resources)
municipality-app.slnx        Solution file (open in Visual Studio)
README.md                    (this file)
```

## How to build and run

Prerequisites
- .NET 10 SDK installed (match the project's TargetFramework net10.0).
- A Windows machine to run WinForms applications.
- Optional: Visual Studio (recommended for designers) or the dotnet CLI.

From a fresh clone (dotnet CLI)
1. Restore and build:
   - dotnet restore
   - dotnet build
2. Run the WinForms app:
   - dotnet run --project municipality-app/municipality-app.csproj

Or open `municipality-app.slnx` (or the solution/project in Visual Studio) and press F5 / Run.

Notes:
- Ensure MaterialSkin (NuGet) is available/installed; the code references MaterialSkin and MaterialSkin.Controls.
- The class library project must be referenced by the WinForms project (the repository contains muni-class-library and municipality-app projects intended to be used together).

## Usage notes / behavior observed in code
- The Service Request form requires Location, Title, Description, Category, and a real file name to reach 100% progression. The UI:
  - Enables the upload button only once the Description is filled.
  - Copies uploaded files into an "Uploads" folder under the application's startup directory.
  - When the form reaches 100% on the progress bar, the Submit button is enabled and a success message is shown.
- Submitted requests are added to an in-memory List<IssueReport> (issueReports). There is no persistence to a database or file in the current code—data will be lost when the application exits.
- Two of the main window buttons currently show a "Feature coming soon" message; AnnouncementWindow exists as a form class and can be extended to show announcements/events.

## Development notes & suggestions
- Persistence: add simple persistence (JSON file, SQLite, or other DB) if requests must survive application restarts.
- Announcements & Events: implement data model, UI and persistence; consider a small admin/editor UI for creating announcements.
- File handling: consider validating file size/type and showing clearer upload progress; ensure permissions for the Uploads folder.
- Packaging: create an installer or publish profile for easy distribution to Windows users.

## Files of interest
- muni-class-library/IssueReport.cs — model for reports and service requests.
- municipality-app/ServiceRequestForm.cs — main logic for the service request workflow (progress logic, validation, file copy).
- municipality-app/Form1.cs — main menu and entry points to features.
- municipality-app/AnnouncementWindow.cs — UI shell for announcements.

## Limitations
- No persistent storage for issue reports (only in-memory List<IssueReport>).
- Announcements/events functionality is not fully implemented in the visible code path.
- Uploads are saved locally; no server or remote storage integration is present.

## Contributing
- Open an issue or submit a PR to add persistence, complete the announcements/events feature, or improve UX and error handling.
- If adding persistence, keep backward compatibility with the IssueReport model fields:
  - IssueId, Title, Location, Description, FilePath, IssueCategory

## License
- Not specified in the repository. Add a LICENSE file to clarify usage terms.

---

If you want, I can:
- Draft a quick design for persisting IssueReport items (JSON or SQLite) and show how to integrate it.
- Add a simple announcements/events model and a minimal data-backed UI.
- Create a CONTRIBUTING.md and a sample LICENSE file.
