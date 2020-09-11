## 20 09 11 Classwork

Build a MVC web application to display and update bands' album information

## Models
- Band 
	-id : PK
	- bandName : Required, less than 50 charcaters
	- yearFormed : Between 1960 and 2020
	- numberOfMembers : Required
	- isActive : boolean
	- Albums : list of albums
- Album
	- id : PK
	- bandID : simple link to Band Model
	- title : Required, less than 50 characters
	- yearRealeased : Between 1960 and 2020

## Endpoints
### Read
- View All Bands
- View A Band's Albums

### Create
- Add a Band to the database
  - if the band cannot be added display client side errors
- Display the form to add a band
- Add an Album to the database, associated with a band
  - if the band cannot be added display client side errors
- Display the form to add an album to the database

### Update
- Update a Band in the Database
  - if the band cannot be update display client side errors
- Display the populate form to update a band

## Views
- View All Bands
  - use a partial to display the id, name, year formed, number of members, and some text if the band is still active
  - display a button to update band properties
  - display a button to view band details
- View Band Details
  - use a partial to display the id, name, year formed, number of members, and some text if the band is still active 
  - display the id, title, and year realeased of each album
- Create Form (Band)
  - display a model bound form
  - use a partial to display all form fields to create a band
- Create Form (Album)
  - display a model bound form to create an album
  - assign the album's bandID to the band passed from the controller
- Update Form(Band)
  - display a model bound form
  - use a partial to display all form fields to update a band
