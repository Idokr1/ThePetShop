# ThePetShop
The PetShop App is a web application written in ASP.NET with the MVC software architectural pattern.
The app connects to a SQL Database using a connection string specified in the appsettings.json file.
The app has 3 views: Admin view, Catalog View, and Home View.

## Views
### Home View
The Home View displays the top 2 most commented pets at the moment.

### Catalog View
The Catalog View displays a list of all animals available in the pet shop. Clicking on an animal will display the animal's full details.

### Admin View
The Admin View displays a list of all animals in the pet shop. It provides the functionality to create new animals and edit existing ones.

## Architecture
The PetShop App uses the MVC software architectural pattern.
The Model represents the data of the application, the View displays the data, and the Controller handles user input and interacts with the Model and View.

## Database
The PetShop App connects to a SQL Database using Entity Framework.
The database schema is automatically created when the application is run for the first time.

## Installation
1. Clone the repository
2. Update the connection string in the appsettings.json file to connect to your SQL Database
3. Build the application
4. Run the application
