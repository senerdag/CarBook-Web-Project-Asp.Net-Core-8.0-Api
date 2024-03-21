# **CarBook | Asp.Net Core Api 8.0 Onion Architecture**
This project is a Web API based on Onion Architecture and Code First approach, focusing on car rental with a system called Carbook. The project encompasses essential CRUD operations for managing various aspects, including cars, models, brands, and site sections such as contact, services, and about. It incorporates patterns like CQRS, Mediator, and Generic Repository. The administration panel provides a secure and practical way to manage the site.
![Ekran Alıntısı](https://github.com/senerdag/CarBook/assets/79213168/4e87fd25-670f-4bf8-b376-c135fcfbe598)
![2](https://github.com/senerdag/CarBook/assets/79213168/bfe2a8bd-14fa-4ae2-872b-cc8ab1ea92a0)
![3](https://github.com/senerdag/CarBook/assets/79213168/57f35d1c-ca92-4923-a13e-027f28696382)
![4](https://github.com/senerdag/CarBook/assets/79213168/ae839017-5f01-4ad4-bfa4-67c41b6aa3b4)

![22](https://github.com/senerdag/CarBook/assets/79213168/fd283052-41bd-4636-8ccf-bdb723915edb)
![23](https://github.com/senerdag/CarBook/assets/79213168/9ed6a2d0-61df-4e59-a261-860f9c4093ba)
![24](https://github.com/senerdag/CarBook/assets/79213168/a87ab355-25da-40d3-9118-0b216d537a75)
![25](https://github.com/senerdag/CarBook/assets/79213168/22c68c6e-d3c9-4df1-ab5c-670b16f2c787)
![26](https://github.com/senerdag/CarBook/assets/79213168/01c8f5e5-0088-41db-9fec-cf6aa9d0185d)

# Technologies Used
**Backend**
- **Web Development Framework:** ASP.NET Core 8.0
- **C#:** In the backend, the C# language has been utilized.
- **MSSQL:** Microsoft SQL Server has been used as the database.
- **Swagger:** Swagger has been used for API documentation.
- **Code First Approach**

 
**Frontend**
- **HTML:** HTML has been used for structuring the pages.
- **CSS:** CSS has been used for determining styles.
- **Bootstrap:** Bootstrap is used for fast and effective interface design.
- **JavaScript:** JavaScript is used for page interactions.

  
# **Design Patterns**
- **CQRS:** CQRS (Command Query Responsibility Segregation) is an architectural pattern that separates the write (command) operations from the read (query) operations in an application.
- **Mediator:** It is a pattern based on providing communication between objects derived from the same interface through a single point.
- **Generic Repository:** The GenericRepository class provides a generic CRUD operation for a specific entity type. This class eliminates the need for coding specific to a particular entity type to perform CRUD operations.
 
# **Project Structure and Layered Architecture**
 The project follows the following layered architecture structure:
 - **Core:** In the Core layer we have Domain (class project where we define Entities) and Application (we have Design Pattern and Interfaces)
 - **Frontends:** In our Frontends layer, we have Dto (Mapping) and WebUI (MVC) projects.
 - **Infrastructure:** In our Persistence project, we have the string connection to which we connect our database, migrations and repositories of our interfaces.
 - **Presentation:** Presentation layer contains the Web API to which we send requests for our Web Application.

   
# **Requirements**
- .NET Core SDK
- Microsoft SQL Server

  
# **API Endpoints**
**There are many entity specific query operations inside the project(statistics, filtering operations etc.), the following are just normal crud enpoints.**
- GET: Lists all items 
- GET By Id: Fetches according to ID. 
- POST: Creates a new item. 
- DELETE: Deletes the fetched item by ID. 
- Put: Updates fetched item according to ID 



