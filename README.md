# BoxBreakerVideo
A movie rental app using Windows Forms .NET and C#.

## Dependencies
- Visual Studio
- .Net 6.0
- Windows Operating System

#### NuGet Packages
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools

## Features
- CRUD functional forms to manipulate data in a database
- Login Form to access the Movie Rental or Admin Forms
- Movie Rental Form to choose which movies to rent
- Summary form which shows chosen movies and price to checkout
- New member form to create an account
- Admin form allows for deleting a member or movie
- Add/Edit movie forms adds a new movie or edits an existing one
- Account page with list of currently checked out movies and due date functionality


## Instructions

### Clone Repository and Install Database
#### 1. Clone Repository to your local drive.

<div>
  <img src="https://github.com/DPJProgramming/BoxBreakerVideo/blob/master/BoxBreakerVideo/BoxBreakerVideoPics/Clone.png" width=30% height=30%>
</div>

#### 2. Open the Box Breaker Video Database Script 

#### 3. Connect to your local host (MSSQLLocalDB)

![Connect](BoxBreakerVideo/BoxBreakerVideoPics/connect.png)

<div>
  <img src="https://github.com/DPJProgramming/BoxBreakerVideo/blob/master/BoxBreakerVideo/BoxBreakerVideoPics/connect2.png" width=40% height=40%>
</div>


#### 4. Run the script.

![Run Script](BoxBreakerVideo/BoxBreakerVideoPics/runScript.png)


(The database will now be on your computer and you can run the app.)


### For Members 
#### 1. If you are new, click the New Member button, otherwise skip to step 3.
<sub> (You can also just enter "test@test.com" for email and "test" for password to bypass step 1 and 2.)</sub>

<div>
  <img src="https://github.com/DPJProgramming/BoxBreakerVideo/blob/master/BoxBreakerVideo/BoxBreakerVideoPics/newMember.png" width=40% height=40%>
</div>


#### 2. Fill in all information correctly and click Register
<sub>(To create an admin account make sure the email is from "@test.com")</sub>

#### 3. Fill in your login information and click the login button. You will then be taken to the Rental Form.

#### 4. Pick a movie you want to rent from the drop down menu and click add to order.

<div>
  <img src="https://github.com/DPJProgramming/BoxBreakerVideo/blob/master/BoxBreakerVideo/BoxBreakerVideoPics/rentalForm.png" width=40% height=40%>
</div>


5. When you are done with your selections click the checkout button. You will be taken to your order summary.

6. Congrats! You have rented some awesome movies!!! (No guarantee of actually getting real movies)


### For Administrator
#### 1. To login as an administrator, your email address must be from test.com
<sub>(The default admin already in the database is email: test@test.com password: test)</sub>

<div>
  <img src="https://github.com/DPJProgramming/BoxBreakerVideo/blob/master/BoxBreakerVideo/BoxBreakerVideoPics/adminLogin.png" width=40% height=40%>
</div>


#### 2. From the Admin form you can delete members and movies by title.

<div>
  <img src="https://github.com/DPJProgramming/BoxBreakerVideo/blob/master/BoxBreakerVideo/BoxBreakerVideoPics/adminDelete.png" width=40% height=40%>
</div>


#### 3. From the admin form you can also click the add movie button to enter information for a new movie to be added,
####    or click the edit button to edit the information of a movie which already exists in the database.

# Credits

- [DPJProgramming](https://github.com/DPJProgramming)
- [ZCooke1](https://github.com/Zcooke1)
