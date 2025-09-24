# Master-Details Single Page Application (ASP.NET Core)

A modern ASP.NET Core Single Page Application for managing master-details relationships with Entity Framework Core and clean architecture.

## 🚀 Features

- **Single Page Application** - AJAX-based CRUD operations without page reloads
- **Master-Details Relationship** - Manage parent-child data relationships
- **Entity Framework Core** - Code-first approach with SQL Server
- **ASP.NET Core MVC** - Modern web application architecture
- **AJAX Operations** - Dynamic content loading and updates
- **Modal Forms** - In-place editing and creation
- **Responsive Design** - Bootstrap-based UI components

## 🏗️ Technology Stack

- **Backend**: ASP.NET Core 6.0
- **Frontend**: HTML5, CSS3, JavaScript, jQuery, AJAX
- **Database**: SQL Server with Entity Framework Core
- **UI Framework**: Bootstrap 5
- **Architecture**: MVC Pattern with Repository Pattern

## 📋 Project Structure

### Controllers
- **HomeController** - Main application controller handling SPA operations
- **MasterController** - API endpoints for master data operations
- **DetailsController** - API endpoints for details data operations

### Models
- **MasterModel** - Parent entity with primary key and properties
- **DetailsModel** - Child entity with foreign key relationships
- **ViewModels** - Combined models for UI data binding

### Views
- **SPA Interface** - Single page with dynamic content sections
- **Modal Windows** - For create/edit operations
- **Partial Views** - Reusable UI components

## 🔧 Key Functionalities

### Master Data Management
- Create, read, update, delete master records
- Real-time validation and error handling
- Search and filter capabilities

### Details Data Management
- Add multiple detail records to masters
- Inline editing and deletion
- Relationship integrity maintenance

### AJAX Operations
- **Dynamic Loading** - Content updates without page refresh
- **Modal Forms** - Popup windows for data entry
- **Real-time Validation** - Client and server-side validation
- **Error Handling** - Graceful error messages and recovery

## 🗃️ Database Design

### Master Table
- MasterID (Primary Key)
- MasterName
- Description
- CreatedDate
- Status

### Details Table 
- DetailID (Primary Key)
- MasterID (Foreign Key)
- DetailName
- Quantity
- Price
- Notes

## 🌟 SPA Features

- **No Page Reloads** - Smooth user experience
- **Modal-based UI** - Clean interface without navigation
- **Real-time Updates** - Instant data synchronization
- **Responsive Design** - Mobile-friendly interface
- **Progress Indicators** - Loading states for async operations

## 🚀 Getting Started

### Prerequisites
- .NET 6.0 SDK
- SQL Server
- Visual Studio 2022 or VS Code

### Installation
1. Clone the repository
2. Update connection string in `appsettings.json`
3. Run EF Core migrations:
   ```bash
   dotnet ef database update
   ```
4. Build and run:
   ```bash
   dotnet run
   ```

## 🔄 AJAX Implementation

### Key JavaScript Functions
- `loadMasters()` - Fetch and display master records
- `loadDetails(masterId)` - Load related details
- `showCreateModal()` - Display creation form
- `submitForm()` - Handle form submissions asynchronously
- `deleteRecord()` - Remove records with confirmation

### API Endpoints
- `GET /api/Master` - Retrieve all masters
- `POST /api/Master` - Create new master
- `PUT /api/Master/{id}` - Update master
- `DELETE /api/Master/{id}` - Delete master
- `GET /api/Details/{masterId}` - Get details by master

## 💡 Use Cases

- **Order Management** - Orders (master) and Order Items (details)
- **Inventory Systems** - Products and Inventory Transactions
- **Project Management** - Projects and Tasks
- **Educational Systems** - Courses and Students

---

**Modern SPA implementation demonstrating ASP.NET Core Web Development with EF Core, AJAX, and responsive UI design.**
