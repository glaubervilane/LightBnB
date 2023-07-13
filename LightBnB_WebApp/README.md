# LightBnB

LightBnB is a property rental web application built using Node.js, Express, and PostgreSQL. It allows users to search and book properties, manage their reservations, and post property listings.

## Introduction

LightBnB is a project aimed at developing full-stack web development skills while implementing features commonly found in property rental platforms. It showcases the capabilities of Node.js, Express, and PostgreSQL to build a dynamic and interactive web application.

## Project Structure

```
.
├── db
│   ├── json
│   └── database.js
├── public
│   ├── javascript
│   │   ├── components 
│   │   │   ├── header.js
│   │   │   ├── login_form.js
│   │   │   ├── new_property_form.js
│   │   │   ├── property_listing.js
│   │   │   ├── property_listings.js
│   │   │   ├── search_form.js
│   │   │   └── signup_form.js
│   │   ├── libraries
│   │   ├── index.js
│   │   ├── network.js
│   │   └── views_manager.js
│   ├── styles
│   │   ├── main.css
│   │   └── main.css.map
│   └── index.html
├── routes
│   ├── apiRoutes.js
│   └── userRoutes.js
├── styles  
│   ├── _forms.scss
│   ├── _header.scss
│   ├── _property-listings.scss
│   └── main.scss
├── .gitignore
├── package-lock.json
├── package.json
├── README.md
└── server.js
```

## Features

- User authentication and registration system.
- Property search functionality based on various criteria.
- Property listing creation and management.
- Reservation booking and management.
- Property review system.
- Real-time updates on property availability.
- Responsive design for optimal user experience on different devices.

## Installation

1. Clone the repository to your local machine.
2. Install dependencies by running `npm install` in the project directory.
3. Create a PostgreSQL database named `lightbnb`.
4. Configure the database connection settings in `.LighBnB_WebApp/db/database.js`.
5. Run the database migrations and seed the database by running `npm run db:reset`.
6. Start the server using the command `npm start`. The app will be served at <http://localhost:3000/>.

## Usage

Once the project is running locally, open your browser and navigate to <http://localhost:3000/>. You can now interact with the LightBnB application. Register an account, search for properties, make reservations, post property listings, and explore various features of the platform.

## Dependencies

- Node.js
- Express
- PostgreSQL
- EJS
- bcrypt
- body-parser
- cookie-session
- dotenv
- method-override
- node-sass-middleware
- pg
- pg-native

## Screenshots

- [Home Image](https://github.com/lighthouse-labs/LightBnB_WebApp/images/homeImage.png)
- [User Logged Image](https://github.com/lighthouse-labs/LightBnB_WebApp/images/loggedUserImage.png)

## Database Structure

The database structure consists of the following tables:

- `users`: Stores user information such as name, email, and password.
- `properties`: Contains property details including title, description, cost per night, location, and owner information.
- `reservations`: Tracks reservation details including guest and property associations, start and end dates.
- `property_reviews`: Stores property review messages and ratings, associated with specific reservations.

## Project Structure

The project structure follows a typical MVC (Model-View-Controller) pattern:

- `db`: Contains the database interaction code.
  - `database.js`: Handles database queries and connections.
- `public`: Contains all the HTML, CSS, and client-side JavaScript files.
  - `index.html`: Entry point to the application.
  - `javascript`: Contains client-side JavaScript files.
  - `styles`: Contains CSS and Sass files.
- `routes`: Contains the router files responsible for handling HTTP requests.
  - `apiRoutes.js`: Handles API requests for data retrieval and manipulation.
  - `userRoutes.js`: Handles user-related HTTP requests.
- `styles`: Contains Sass files for styling the application.
- `.gitignore`: Specifies which files and directories should be ignored by Git.
- `package-lock.json`, `package.json`: Dependency management files.
- `README.md`: Documentation file.

## License

This project is open-source and available under the [MIT License](LICENSE).
