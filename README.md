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
![Loggingin](Homepage.png)


After clicking the register button at the navigation bar it relocates for registration which doesnt need the actual email currently but must follow the actual email and password format.

![Loggingin](register.png)

The registered email can now login.
![Loggingin](login.png)

This is the privacy page (optional)
![Loggingin](privacy.png)

This is the page where list of customer complaints with customer information is listed. This is not accessible if user isn't logged in. This is implementation of authentication.
![Loggingin](afterDelete.png)

Complaints/Feedbacks can be added.
![Loggingin](create.png)

After submission, new Complaint/Feedback has now succesfully been added.
![Loggingin](afterCreate.png)

If your identity or account hasnt been given proper role, you cannot delete and will be prompted with this page.
![Loggingin](deleteDeny.png)

If your identity or account has been give managerial role which has access to delete, you will be prompted with this page of confirmation. This is implementation of authorization.
![Loggingin](deleteConfirm.png)

After deletion, this is the list of information
![Loggingin](afterDelete.png)

This is the page of edit, which can change the existing informatoin of items in the list.
![Loggingin](edit.png)

This can easily edit as seen the the image below.
![Loggingin](afterEdit.png)


In this way, Customer Relationship Management specifying Operational aspects has been created.