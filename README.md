# 200826 Partial Views Practice

### Set Up
- Create a .NET MVC app using the .NET CLI called `MovieListing`
- Create a controller called `Movies`
- Run in browser
- Create a postman collection and one request for the landing page

### End Product
Create a Movie Listing that allows users to view all movies, view movies with positive reviews and view movies with negative reviews 

### Assigment
#### Models
- Movie Model : title, description, rating
- Movie List View Model : list of movies populated in constructor with 5 movies

#### Movie Landing Page
- Action : Return associated view
- View : Display h1 with text `Welcome to the Movie Landing Page` with links to View all Movies, View Positive Movies, and View Negative Movies

#### View All Movies
- Action : Pass public list of movies to associated view
- View : Use partial to render details of each movie

#### View Positve Movies
- Action : Pass public list of movies to associated view
- View : Use partial to render details of each movie that have a rating 5 or over (handle the condition in the view)
#### View Negative Movies
- Action : Pass public list of movies to associated view
- View : Use partial to render details of each movie that have a rating under 5 (handle the condition in the view)