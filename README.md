# _Pierre's Bakery_

#### _Independent Project 10, March 27 2020_

#### By _**Kristina Hengster Tintor**_

## Description
ASP.NET Core MVC application. Application consists of many-to-many relationship for treats and flavors.

## Project Specifications

1. BEHAVIOR: User runs the application and is shown a Welcome Page, with links to view treats, flavors or to register
* INPUT: User types http://localhost:5000 in their browser and clicks "Enter" on keyboard to visit the "/" route
* OUTPUT:
  Welcome to Pierre's Bakery
  See all treats
  See all flavors
  Register

2. BEHAVIOR: User can create an account or log in to be authorized to access rest of the application
* INPUT: User clicks on "Create an account" link
* OUTPUT: "/Account" route page is displayed where user can log in or register 


3. BEHAVIOR: In "/Account" foute, non-registered users can register
* INPUT: User clicks the "Register" link
* OUTPUT: "/Account/Register" route is displayed

4. BEHAVIOR: From "/Account/Register" route, user can complete a form to create an account
* INPUT: User adds email: example@example.com; password: 1; confirm password: 1; clicks on "Register" button
* OUTPUT: Newly registered user is taken back to "/Account" route to log in


5. BEHAVIOR: From "/Account" route, user has the option to log in to an existing account
* INPUT: User clicks the "log in" button
* OUTPUT: "/Account/Login" route is displayed


6. BEHAVIOR: From "/Account/Login" page, user completes the login information and submits the form
* INPUT: Email:example@example.com; password: 1; clicks "Login" button
* OUTPUT: "/Account" route is displayed


7. BEHAVIOR: From "/Account" route, logged in user can log out or go to the home page
* INPUT: User clicks "Home" button
* OUTPUT: "/" route is displayed (Home page)


8. BEHAVIOR: While at the "/" route, logged in user can choose if they want to view Treats or Flavors.
* INPUT: User clicks the "See all treats" link
* OUTPUT: User is taken to "/treats" route


9. BEHAVIOR: From "/treats" route, user has options to view any previously added treats or add new treat or be routed back to home page
* INPUT: User clicks "Add new treat" link
* OUTPUT: User is taken to the "/treats/create" route and a form is shown


10. BEHAVIOR: While on "/treats/create" route, user can complete and submit form to add a treat
* INPUT: Name: "croissant"; clicks "Add new treat" button
* OUTPUT: User is taken back to the page corresponding with "/treats" route where newly added treat name is displayed, along with any other previously added treats


11. BEHAVIOR: From "/treats" route, user can click on the treat listed to view its details
* INPUT: user clicks on "croissant"
* OUTPUT: user is taken to "Treats/Details/1" route displaying details for the treat: Name: croissant; No flavors exist for this treat; "Back to treats" link, "Edit treat" link, "Delete treat" link


12. BEHAVIOR: From "Treats/Details/1" route, User has the option to Edit a treat, delete a treat or go back to view all treats
* INPUT: User clicks on "Edit treat" link
* OUTPUT: User is routed to "/Treats/Edit/1" route with a form allowing updates


13. BEHAVIOR: While in "Treats/Edit/1" route, user can change treat name and/or add a flavor
* INPUT: User changes treat name to "chocolate croissant" and clicks "Save"
* OUTPUT: User is taken back to "/Treats" route displaying the new updated treat name along with any other previously added treats


14. BEHAVIOR: From "Treats/Details/1" route, User has the option delete a treat and confirm deletion
* INPUT: User clicks on "Delete treat" link and is routed to "Treats/Delete/1" route; clicks "Delete" button
* OUTPUT: User is routed back to "/Treats" route where "chocolate croissant" is removed from list of treats


15. BEHAVIOR: From "/" route, logged in user can click the "See all flavors" link to access the Flavors information section of the app
* INPUT: User clicks "See all flavors" link
* OUTPUT: Logged in user is routed to "/Flavors" route showing any previously added flavors and link to add a new flavor or return to Home Page


16. BEHAVIOR: From "/Flavors" route, user can add a new flavor
INPUT: User clicks "Add a new flavor" link
OUTPUT: User is taken to "/Flavors/Create" route displaying a form to be completed


17. BEHAVIOR: In "/Flavors/Create" route, user can complete information about new flavor and add it to a list of flavors
* INPUT: Description: sweet; select a treat: croissant; clicks on "Add new flavor" button
* OUTPUT: User is taken back to "/Flavors" route displaying newly added flavor and any previously added flavors


18. BEHAVIOR: From "/Flavors" route, user can click on a flavor to view its details
* INPUT: Clicks the "sweet" flavor link
* OUTPUT: user is routed to "/Flavors/Details/1" where information about flavor is displayed: Description: sweet; Treats with this flavor: croissant

19. BEHAVIOR: From "/Flavors/Details/1" route, user can choose to delete a treat associated with a flavor
* INPUT: User clicks "Delete" button associated with croissant
* OUTPUT: User is routed back to "/Flavors" route after treat has been successfully deleted

20. BEHAVIOR: From /Flavors/Details/1" route, user can choose to Edit a flavor
* INPUT: user clicks "Edit flavor" link
* OUTPUT: user is routed to "Flavors/Edit/1" displaying form to be completed with updated information

21. BEHAVIOR: From "/Flavors/Edit/1" route, user can complete a form to change the flavor properties
* INPUT: Changes Description to "sweet and savory" and clicks "save"
* OUTPUT: Changes are saved and user is returned to flavors list in "/Flavors" route

22. BEHAVIOR: From "/Flavors/Edit/1" route, user can add treats to a flavor
* INPUT: User selects additional treat to be added - chooses "Pie" from dropdown list.
* OUTPUT: Additional treat is added to "sweet and savory" flavor and user is returned to "/Flavors" route




## Setup/Installation Requirements

_In Terminal:_

* Navigate to where you want this application to be saved, i.e.:
```cd desktop```
* Clone the file from GitHub with HTTPS
```git clone https://github.com/kristinaht/PierresBakery.Solution```
* Open file in your preferred text editor

* On Windows: ```cd PierresBakery.Solution```, followed by ```code .```
* Type ``` dotnet build``` followed by ```dotnet run``` to run program.

Navigate to project directory and run:
```dotnet ef database update```



## Known Bugs

_No known bugs at this time._

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/kristinaht/BakeryVendors.Solution) here on GitHub._

## Technologies Used

* Git
* HTML
* CSS
* VS Code
* C#
* dotnet script
* ASP.NET Core MVC 2.2
* Entity Framework Core 2.2
* MySQL
* Razor
* Identity

### License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2020 **_Kristina Hengster Tintor_**