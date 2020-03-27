# _Pierre's Bakery_

#### _Independent Project 10, Mar 2020_

#### By _**Kristina Hengster Tintor**_

## Description
MVC application for a Hair Salon that allows user to add new Stylists and add new Clients for each Stylist. 

## Project Specifications

1. From "/" route user is redirected to the page that displays all stylists
* Input: Click "See all stylists"
* Output: redirect to /Stylists

2. From /Stylists route, user completes a form to add new stylist
* Input: Specialty: coloring, than click "Add stylist"
* Output: Application creates new stylist in database and user is redirected to "Stylists" where the list of stylists is displayed

3. User clicks on a stylist in the /Stylists route to see specific stylist details ("/Details") 
* Input: Clicks on "coloring" link
* Output: User is redirected to /Stylists/Details/1 route and the following is displayed: Specialty: coloring; No clients found;

4. User adds new client for the Stylist
* Input: 


## Setup/Installation Requirements

_In Terminal:_

* Navigate to where you want this application to be saved, i.e.:
```cd desktop```
* Clone the file from GitHub with HTTPS
```git clone https://github.com/kristinaht/HairSalon.Solution```
* Open file in your preferred text editor

* On Windows: ```cd HairSalon.Solution```, followed by ```code .```
* Type ``` dotnet build``` followed by ```dotnet run``` to run program.

Run these commancs in MySQL to create the project Database:





## Known Bugs

_No known bugs at this time._

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/kristinaht/BakeryVendors.Solution) here on GitHub._

## Technologies Used

* Git
* VS Code
* C#
* .NET

### License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2020 **_Kristina Hengster Tintor_**