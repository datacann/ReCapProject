Rent A Car

RECENT UPDATES CustomerDetailDto has been created for the frontend side, CarDetailDto and RentalDetailDto sections have been edited. For these DTOs, implementations up to the API side were carried out. Tested via Postman and data verified. Cache, Transaction and Performance integration has been made. !!! Json Web Token INTEGRATION has been done.

CORE IEntity, IDto, IEntityRepository, EfEntityRepositoryBase structures were created in this layer. IDto: Interface created for objects that can be pulled with special queries. IEntityRepository: It holds the basic database operations for the interfaces in the Real DataAccess layer, which can be easily implemented with the T generic structure. EfEntityRepositoryBase: It will provide a concrete interface implementation for the basic database operations with the help of the object (entity) that will create the context and structure in a generic structure for the Entity Framework structure. holding the skeleton. ICrudServices: It has been created in a generic structure to facilitate the applicability of similar database operations for services belonging to different objects in the real Business layer. Added Autofac support. Added Fluent Validation support. A basic level introduction to (A)spect (O)riented (P)rogramming has been performed.

A related entity has been created for the CarImages table and related columns (Id,CarId,ImagePath,Date) on the ENTITIES Database. An object holding vehicle properties was created with a class named Car. As feature: Id, BrandId, ColorId, ModelYear, DailyPrice, Description fields have been added. Added Brand and Color objects. These objects have Id and Name properties. The Users table has been created. Customers table was created Rentals table was created and Key assignments were made. Entities corresponding to the elements in these tables were created in the project. New users, customers and rental records are created. (SQL)

DATAACCESS Image deletion, update permissions have been added. It includes operations such as adding, deleting, listing from the database. The necessary queries for the database have been added to the project. Entity Framework infrastructure is written for Car, Brand and Color objects. CRUD operations were written for the newly added Customers, Users and Rentals in DAL operations.

BUSINESS The possibility to list pictures of a car has been created. However, the company logo was used when there was no vehicle on the list. The date the picture was added will be automatically assigned by the system at the entity level with the help of encapsulation. When an arbitrary value is given, the system will take that value as a date. Added a maximum of 5 images for a car. Added image deletion, update permissions. Via the Data Access layer

GetAllService() : Returning all vehicles in the list, GetById(int id) : Returns an object associated with an externally given ID. AddService(T entity) : Adding an externally given object to the system, UpdateService(T entity) : Updating the matching advertisement of an externally given object in the system, DeleteService(T entity) : Deleting the advertisement that matches with an externally given object. New restrictions have been introduced with Fluent Validation.

All CRUD testing operations are performed in the CONSOLEUI Console. In addition, with GetCarDetails(), CarName, BrandName, ColorName, DailyPrice information in different tables were brought together by joining the tables. Added new test operations on Program.cs. The possibility of renting was realized on the code. If the vehicle has not been received by the office, a new rental transaction is blocked.

WEBAPI Added images are kept in wwwroot in API. Image insertion was done via API. WebAPI part created. An API has been introduced for all services in the Business layer.


![READı](https://user-images.githubusercontent.com/59285855/121585127-e5f6c200-ca3a-11eb-8a2b-a230dec6871e.PNG)

![2ı](https://user-images.githubusercontent.com/59285855/121585293-15a5ca00-ca3b-11eb-9824-9432e36292d1.PNG)

![3Alıntısı](https://user-images.githubusercontent.com/59285855/121585369-2d7d4e00-ca3b-11eb-8b62-8d17a9e0bceb.PNG)

![4Alıntısı](https://user-images.githubusercontent.com/59285855/121585394-353cf280-ca3b-11eb-8420-467e156d74ff.PNG)

![5Alıntısı](https://user-images.githubusercontent.com/59285855/121585492-543b8480-ca3b-11eb-8e7b-18ee1549829d.PNG)

![6Alıntısı](https://user-images.githubusercontent.com/59285855/121585553-63bacd80-ca3b-11eb-8739-9c9d39bd24e8.PNG)

![7Alıntısı](https://user-images.githubusercontent.com/59285855/121585721-91077b80-ca3b-11eb-995b-3d69a972036a.PNG)
