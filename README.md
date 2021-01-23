## Pierre's Treats -- Many-to-Many MySQL Database w/ Authentication

### _Webpage to create many-to-many relationships between flavors and treats at Pierre's fictional bakery. Includes user authentication with Identity._

### _Created by: Eric Stratton_

## Description

Use this webpage to create multiple many-to-many relationships which are accessible from both sides of the relationship. A webpage for bakery workers to update the shop's available treats and flavor profiles, as well as a place for bakery workers to enter in upcoming orders.

**_Authentication:_** 

**_Any employee can access the page to see what's available by either the specific treat or flavor profile. Create, Update, and Delete functionality of both treats and flavors are restricted to autheticated users. The entire order class is restriced to authenticated users and orders are added to the specific user who placed them, meaning employees can only access the orders they entered into the system._**

## Setup/Instillation

### Requirements:

- Internet browser
- Code editor if you wish to view/edit the code (recommended)
- .NET Core SDK
- MySQL 

### .NET Core:

- Application is built using the deprecated .NET Core vs 2.2.
- .NET Core is a requirement for running this application, if you need to install it visit <https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.203-windows-x64-installer>
- Or if you wish to downloaded the latest editions of .Net Core, select `.NET core` in the file path at the top of the dowloaded page provided in the link above

### MySQL:

- Application utilizes a database created using MySQL
- Download from MySQL Community Server <https://dev.mysql.com/downloads/file/?id=484914>
- Either make an account or select `No thanks, just start my dowload`
- Follow install instructions and configure to your specifications
- Recommend including _MySQL Workbench_ in install
- Check if properly installed by running command `mysql -uroot -p<password>` in terminal

### Download: 

- Download this repository by clicking the green 'Code' icon and selecting download zip
- Use your favorite zip.file opener to extract files to your local device
- Follow install window and select configuration of your choice

### Terminal:

- Open command terminal on local device
- Navigate to desktop in terminal using `$ cd desktop`
- Copy repository link by clicking on green 'Code' icon and clicking the clipboard to the right of the url
- Use command `$ git clone https://github.com/EricStratton/PierresTreats.Solution`
- From desktop, run command `$ cd PierresTreats.Solution` to navigate to the installed directory
- Run command `$ code .` to open directory in default code editor
- Run command `dotnet restore Treats` in the console to upload necessary .NET Core files
- Run command `$ cd Treats` to navigate into the root directory to run console app
- Run command `$ donet run` 
- If everything has gone correctly, the web application should run in the web browser at `localhost:5000`

### Import Database using Entity Framework Core

- Navigate to `Treats` directory in your terminal
- Run command `dotnet ef database update` to generate database based on provided structure
- If you make changes and want to update database run command `dotnet ef migrations add <MigrationName>`

### Navigating in Application:

- App opens on landing page at `localhost:5000/`
- Click on one of the hyperlinks to navigate to a different section of app

### RESTful Protocol:

- **_Page routes are named using RESTful notation as reflected in the pathway urls_**
- `localhost:5000/`: landing page
- `localhost:5000/Flavors`: homepage for flavor profiles, displays all existing flavor profiles
- `localhost:5000/Flavors/Create`: page for creating a new flavor profile
- `localhost:5000/Flavors/Details/{FlavorId}`: page for select flavor profile, displays vendor description and existing orders for vendor
- `localhost:5000/Flavors/AddTreat/{FlavorId}`: page to add Many-to-Many relationship with treats currently in database
- `localhost:5000/Orders/`: page for authenticated user to add a new order


## Known Bugs/Issues

There are no known bugs at this time.

## Support & Contact Details

Do not hesitate to contact me at:

<strattonericj@gmail.com>

## Technologies 

- _VisualStudio Code_
- _C#_
- _.NET Core 2.2_
- _Entity_
- _Identity_
- _MySQL_
- _MySQL Workbench_
- _Git_
- _GitHub_

## Licensing

Copyright (c) 2020 **_Eric Stratton_**

This software is licensed under the MIT license