# Newton_Shahi_Thakuri_CRM_DOT_NET
Customer Relationship Management which consists of database for authentication and authorization as well as for complaints or feedbacks which records customer information. 
Dont forget to do the following before building:
**
Change server name in connection string 
add-migration migration-name
update-database 
**

This is the homepage of web application made using .NET Core MVC that incorporates the following features: 
-Authentication
-Authorization
-CRUD operations
-pagination
-sorting
-searching

Firstly, this is the homepage of the web application.

![Loggingin](HomePage.png)


After clicking the register button at the navigation bar it relocates for registration which doesnt need the actual email currently but must follow the actual email and password format.


![register](register.png)


The registered email can now login.


![login](login.png)


This is the privacy page (optional)


![privacy](privacy.png)


This is the page where list of customer complaints with customer information is listed. This is not accessible if user isn't logged in. This is implementation of authentication.


![afterDelete](afterDelete.png)


Complaints/Feedbacks can be added.


![create](create.png)


After submission, new Complaint/Feedback has now succesfully been added.


![afterCreate](afterCreate.png)


If your identity or account hasnt been given proper role, you cannot delete and will be prompted with this page.


![deleteDeny](deleteDeny.png)


If your identity or account has been give managerial role which has access to delete, you will be prompted with this page of confirmation. This is implementation of authorization.


![deleteConfirm](deleteConfirm.png)


After deletion, this is the list of information


![afterDelete](afterDelete.png)


This is the page of edit, which can change the existing informatoin of items in the list.


![edit](edit.png)


This can easily edit as seen the the image below.


![afterEdit](afterEdit.png)


In this way, Customer Relationship Management specifying Operational aspects has been created.