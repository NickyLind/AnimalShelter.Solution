# _Animal Shelter_
#### By _**Nick Lindau**_
<br>

## Prompt
#### _Create an API for a local animal shelter. The API will list the available cats and dogs at the shelter._

### Technologies Used

* _.NET5.0_
* _C#_
* _Visual Studio Code_
* _ASP NET Core MVC_
* _MySql_
* _MySql Workbench_
* _Entity Framework_
* _ASP.NET Razor_

## Description

_You've completed a few projects at the dev agency where you work and you've been given more autonomy to choose which project you'd like to work on next. The agency currently has three new back-end contracts to build APIs for their clients. Since this is the first time you've been given free rein on a project, take this opportunity to showcase your versatility for the project manager._

## Setup/Installation Requirements
To run this application you will need the following:
* A code editor. [Visual Studio Code](https://code.visualstudio.com/) is what I use.
* [ASP.NET Core](https://dotnet.microsoft.com/download)
* [MySQL and MySQL Workbench](https://www.mysql.com/)
* It is also recommended that [Postman](https://www.postman.com/) be downloaded as it makes it easier to follow information being passed to and from endpoints and see what HTTP responses you are getting.

### 1) Cloning the Project:
#### You will need to run a copy of the application in order to make API calls.
* Find the respository at (https://)
* Select the green <span style="color:green">'Code'</span> button above the repository and copy the HHTPS link
* In your terminal, find the directory you want to place the [INSERT PROJECT HERE] directory in
* In your terminal, use the git command `$git clone https://github.com/NickyLind/AnimalShelter.Solution`
* Open in Visual Studio Code or another editor

### 2) Setup a Database for the project:
#### Because you need the application to be running in order to use the API you will need to set up a database
* Create a file in the root directory of the project (`AnimalShelter`), and name it `appsettings.json`.
* In the `appsettings.json` file you will need to add the following code
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=nick_lindau;uid=[USERIDHERE];pwd=[USERPASSWORDHERE];"
  }
}
```
* Replace the [USERIDHERE] & [USERPASSWORDHERE] with the username and password associated with your local MySQL server.
* Navigate to the `AnimalShelter` Directory in the terminal
* If you have ran one of my projects before and titled the related database `nick_lindau` you will have to run the command `dotnet ef database drop` to remove the previous database
* Once you are sure you have no previous database schema named `nick_lindau` you will need to run the command `dotnet ef database update` to create a database using all the classes from this application.
* You can verify this was created correctly by refreshing the list of schemas in the MySQL Workbench and the schema titled `nick_lindau` should be there and it should be filled with the seed data from the Animal Model

### 3) Running the project:
#### You will need to have the application running in order to use the API
* Once the project is successfully cloned and the database is connected to can now run the project
* Navigate to the `AnimalShelter` directory and build the project with the command `dotnet build` to ensure there are no compiling errors
* Once the project is succesfully built you may run the command `dotnet run` and navigate to Http://localport:5000 in your browser to access the applications

### 4) EndPoints
Base URL: `http://localhost:5000/api/Animals`
* The Base URL contains all animals currently loaded into the database *
#### HTTP request structure
```
GET: /api/Animals
POST: /api/Animals
GET: /api/Animals/{id}
PUT: /api/Animals/{id}
DELETE: /api/Animals{id}
```
#### Example Query
```
http://localhost:5000/api/Animals/2
```

#### Example JSON Response
```
{
    "animalId": 2,
    "name": "Bradley",
    "type": "Dog",
    "age": 2,
    "gender": "Male",
    "breed": "Pug",
    "description": "Neutered, spunky and likes a lot of attention"
}
```

#### Path Parameters

| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | :---: |
|
|
|
|
## Known Bugs

* _None currently found, feel free to shoot me an email_

## License

_[MIT](https://choosealicense.com/licenses/mit/)_
 _Copyright (c) Nick Lindau 04/02/2021_

## Contact Information

_Nick Lindau @ <nicholaithegreat@gmail.com>_
