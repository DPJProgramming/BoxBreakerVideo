
USE MASTER
DROP DATABASE IF EXISTS BoxBreakerVideo

CREATE DATABASE BoxBreakerVideo
GO

USE BoxBreakerVideo
GO

/****************
CREATE TABLES
****************/


CREATE TABLE Movie
(
    MovieId             bigint         PRIMARY KEY IDENTITY, 
    Title	            varchar(150)   NOT NULL,	  
    Genre	            varchar(50)    NOT NULL,	  		  
    MovieDescription 	varchar(500)   NULL,  
	MovieRuntime		varchar(10)	   NULL,
    ReleaseDate         date           NOT NULL, 
    MaturityRating      char(10)       NOT NULL,	  
    MoviePoster         varchar(1000)  NULL,
	MoviePrice			smallmoney
)

SET IDENTITY_INSERT Movie ON

INSERT INTO Movie (MovieId, Title, Genre, MovieDescription, MovieRuntime, ReleaseDate, 
            MaturityRating, MoviePoster, MoviePrice)
VALUES(1, 'The Matrix', 'Sci-Fi', 'Directed by The Wachowskis. Starring Keanu Reeves, Carrie Ann Moss. 
        Some guy finds out he lives in a computer generated simulation operated by artificially intellegent machines',
        '136 Min', '1999-09-09', 'R', 'https://imgc.allpostersimages.com/img/posters/the-matrix_u-L-F4S5W20.jpg?artHeight=900&artPerspective=n&artWidth=900&background=fbfbfb', $5.99)

INSERT INTO Movie (MovieId, Title, Genre, MovieDescription, MovieRuntime, ReleaseDate, 
            MaturityRating, MoviePoster,MoviePrice)
VALUES (2, 'Star Wars', 'Sci-Fi', 'Directed by George Lucas. Starring Mark Hamill, Carrie Fisher. 
        A space epic following a small group of rebels battling a sinister Empire', 
        '121 Min', '1977-05-04', 'PG', 'https://imgc.allpostersimages.com/img/posters/star-wars-episode-iv-new-hope-classic-movie-poster_u-L-F5L5V30.jpg?artHeight=900&artPerspective=n&artWidth=900&background=fbfbfb', $4.99)

INSERT INTO Movie (MovieId, Title, Genre, MovieDescription, MovieRuntime, ReleaseDate, 
            MaturityRating, MoviePoster,MoviePrice)
VALUES (3, 'Alien', 'Horror', 'Directed by: Ridley Scott. Starring: Sigourney Weaver. 
        The crew of a commercial spacecraft encounter a deadly lifeform after investigating an unknown transmission.', 
        '117 Min', '1979-05-25', 'R', 'https://imgc.allpostersimages.com/img/posters/alien_u-L-F4S8OE0.jpg?artHeight=900&artPerspective=n&artWidth=900&background=fbfbfb', $4.99)

INSERT INTO Movie (MovieId, Title, Genre, MovieDescription, MovieRuntime, ReleaseDate, 
            MaturityRating, MoviePoster,MoviePrice)
VALUES (4, 'Saving Private Ryan', 'Drama', 'Directed by: Steven Spielberg. Starring: Tom Hanks. 
        Following the Normandy Landings, a group of U.S. soldiers go behind enemy lines to retrieve a paratrooper whose brothers have been killed in action.', 
        '2H 49Min', '1998-07-21', 'R', 'https://imgc.allpostersimages.com/img/posters/saving-private-ryan_u-L-F4S6K30.jpg?artHeight=900&artPerspective=n&artWidth=900&background=fbfbfb', $5.99)

INSERT INTO Movie (MovieId, Title, Genre, MovieDescription, MovieRuntime, ReleaseDate, 
            MaturityRating, MoviePoster,MoviePrice)
VALUES (5, 'Happy Gilmore', 'Comedy', 'Directed by: Dennis Dugan. Starring: Adam Sandler. 
        Following the Normandy Landings, a group of U.S. soldiers go behind enemy lines to retrieve a paratrooper whose brothers have been killed in action.', 
        '1H 32Min', '1996-02-07', 'PG-13', 'https://imgc.allpostersimages.com/img/posters/happy-gilmore_u-L-F4S6KC0.jpg?artHeight=900&artPerspective=n&artWidth=900&background=fbfbfb', $3.99)

SET IDENTITY_INSERT Movie OFF



CREATE TABLE Members 
(
    MemberId            int             PRIMARY KEY IDENTITY,	  
    MemberFName         varchar(50)     NOT NULL,	  
    MemberLName	        varchar(50)     NOT NULL, 
    MemberEmail	        varchar(250)    UNIQUE NOT NULL, 
    MemberPhone	        varchar(20)     UNIQUE NOT NULL,  
    MemberAddress	    varchar(100)    UNIQUE NOT NULL,
    MemberPassword      varchar(200)    NOT NULL,
)

SET IDENTITY_INSERT Members ON

INSERT INTO Members (MemberId, MemberFName, MemberLName, MemberEmail, MemberPhone, MemberAddress, MemberPassword)
VALUES (1000,'John', 'Snow', 'jccomini1@mayoclinic.com', '278-825-7929', '21 Lunder Park San Diego, Ca 83838', '1OIgV2vkQtl'),
        (2000,'Kevin', 'Bacon', 'sclaibourn6@infoseek.co.jp', '146-760-1550', '4194 Pearson Pass Seattle, Wa 98473', 'bKwM2xk42W'),
        (3000, 'test', 'test', 'test@test.com', '111-111-1111', '1111 se test ave test Wa 11111', 'test')

SET IDENTITY_INSERT Members OFF



CREATE TABLE MemberMovies
(
    PRIMARY KEY(MovieId, MemberId),
    MovieId             bigint         REFERENCES Movie(MovieId),	  
    MemberId	        int            REFERENCES Members(MemberId),	 
	CheckoutDate		dateTime	   NOT NULL,
    DueDate	            date       NOT NULL  
)

INSERT INTO MemberMovies (MovieId, MemberId, CheckoutDate, DueDate)
VALUES (2, 1000, GetDate(), GETDATE() + 3),
        (1, 2000, GetDate(), GETDATE() + 3)


--for adding later--
/*

CREATE TABLE Orders
(
    OrderId	            bigint          PRIMARY KEY IDENTITY, 
    MemberId	        int             REFERENCES Members(MemberId), 
    OrderPrice	        smallmoney      NOT NULL,	  
    OrderDate	        datetime        NOT NULL,	  
    DiscountCode        varchar(50)     NULL,
	EmployeeId          int             REFERENCES Employees(EmployeeId), 		
)

SET IDENTITY_INSERT Orders ON

INSERT INTO Orders(OrderId, MemberId, OrderPrice, OrderDate, DiscountCode, EmployeeId)
VALUES (1, 1000, 20.45, '2022-8-02 13:34:49', NULL, 500),
        (2, 2000, 14.17, '2022-05-23 10:14:36', '10 Percent', 400)

SET IDENTITY_INSERT Orders OFF


CREATE TABLE ProductOrders
(
    OrderId	            bigint          FOREIGN KEY (OrderId)   REFERENCES Orders(OrderId),	  
    ProductId	        bigint          FOREIGN KEY (ProductId) REFERENCES Products(ProductId),  
)

*/