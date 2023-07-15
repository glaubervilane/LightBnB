const { Pool } = require('pg');

const pool = new Pool({
  user: 'labber',
  password: 'labber',
  host: 'localhost',
  database: 'lightbnb'
});

/// Users
/**
 * Get a single user from the database given their email.
 * @param {String} email The email of the user.
 * @return {Promise<{}>} A promise to the user.
 */
const getUserWithEmail = function(email) {
  const queryString = `
    SELECT *
    FROM users
    WHERE email = $1;
  `;
  const values = [email];

  return pool.query(queryString, values)
    .then(res => res.rows[0] || null);
};

/**
 * Get a single user from the database given their id.
 * @param {string} id The id of the user.
 * @return {Promise<{}>} A promise to the user.
 */
const getUserWithId = function(id) {
  const queryString = `
    SELECT *
    FROM users
    WHERE id = $1;
  `;
  const values = [id];

  return pool.query(queryString, values)
    .then(res => res.rows[0] || null);
};

/**
 * Add a new user to the database.
 * @param {{name: string, password: string, email: string}} user
 * @return {Promise<{}>} A promise to the user.
 */
const addUser = function(user) {
  const queryString = `
    INSERT INTO users (name, password, email)
    VALUES ($1, $2, $3)
    RETURNING *;
  `;
  const values = [user.name, user.password, user.email];

  return pool.query(queryString, values)
    .then(res => res.rows[0]);
};

/// Reservations
/**
 * Get all reservations for a single user.
 * @param {string} guest_id The id of the user.
 * @param {number} limit The maximum number of reservations to return.
 * @return {Promise<[{}]>} A promise to the reservations.
 */
const getAllReservations = function(guestId, limit = 10) {
  const queryString = `
    SELECT reservations.*, properties.*, AVG(property_reviews.rating) AS average_rating
    FROM reservations
    JOIN properties ON reservations.property_id = properties.id
    JOIN property_reviews ON properties.id = property_reviews.property_id
    WHERE reservations.guest_id = $1 AND reservations.end_date < now()::date
    GROUP BY reservations.id, properties.id
    ORDER BY reservations.start_date
    LIMIT $2;
  `;
  const values = [guestId, limit];

  return pool.query(queryString, values)
    .then(res => res.rows);
};

/// Properties
/**
 * Get all properties based on query options.
 * @param {{}} options An object containing query options.
 * @param {number} limit The maximum number of properties to return.
 * @return {Promise<[{}]>} A promise to the properties.
 */
const getAllProperties = function(options, limit = 10) {
  const queryParams = [];
  let queryString = `
    SELECT properties.*, AVG(property_reviews.rating) AS average_rating
    FROM properties
    JOIN property_reviews ON properties.id = property_reviews.property_id
  `;

  let whereClauseAdded = false;

  if (options) {
    if (options.owner_id) {
      queryParams.push(options.owner_id);
      queryString += `WHERE owner_id = $${queryParams.length} `;
      whereClauseAdded = true;
    }

    if (options.minimum_price_per_night) {
      const minPriceInCents = options.minimum_price_per_night * 100;
      queryParams.push(minPriceInCents);
      if (whereClauseAdded) {
        queryString += `AND `;
      } else {
        queryString += `WHERE `;
        whereClauseAdded = true;
      }
      queryString += `cost_per_night >= $${queryParams.length} `;
    }

    if (options.maximum_price_per_night) {
      const maxPriceInCents = options.maximum_price_per_night * 100;
      queryParams.push(maxPriceInCents);
      if (whereClauseAdded) {
        queryString += `AND `;
      } else {
        queryString += `WHERE `;
        whereClauseAdded = true;
      }
      queryString += `cost_per_night <= $${queryParams.length} `;
    }

    if (options.minimum_rating) {
      queryParams.push(options.minimum_rating);
      if (whereClauseAdded) {
        queryString += `AND `;
      } else {
        queryString += `WHERE `;
        whereClauseAdded = true;
      }
      queryString += `property_reviews.rating >= $${queryParams.length} OR property_reviews.rating IS NULL) `;
    }

    if (options.city) {
      queryParams.push(`%${options.city}%`);
      if (whereClauseAdded) {
        queryString += `AND `;
      } else {
        queryString += `WHERE `;
      }
      queryString += `city LIKE $${queryParams.length} `;
    }
  }

  queryParams.push(limit);
  queryString += `
    GROUP BY properties.id
    ORDER BY cost_per_night
    LIMIT $${queryParams.length};
  `;

  return pool.query(queryString, queryParams)
    .then(res => res.rows);
};

/**
 * Add a property to the database.
 * @param {{}} property An object containing all of the property details.
 * @return {Promise<{}>} A promise to the property.
 */
const addProperty = function(property) {
  const queryString = `
    INSERT INTO properties (
      owner_id,
      title,
      description,
      thumbnail_photo_url,
      cover_photo_url,
      cost_per_night,
      street,
      city,
      province,
      post_code,
      country,
      parking_spaces,
      number_of_bathrooms,
      number_of_bedrooms
    )
    VALUES (
      $1, $2, $3, $4, $5, $6, $7, $8, $9, $10, $11, $12, $13, $14
    )
    RETURNING *;
  `;

  const values = [
    property.owner_id,
    property.title,
    property.description,
    property.thumbnail_photo_url,
    property.cover_photo_url,
    property.cost_per_night,
    property.street,
    property.city,
    property.province,
    property.post_code,
    property.country,
    property.parking_spaces,
    property.number_of_bathrooms,
    property.number_of_bedrooms
  ];

  return pool.query(queryString, values)
    .then(res => res.rows[0]);
};

module.exports = {
  getUserWithEmail,
  getUserWithId,
  addUser,
  getAllReservations,
  getAllProperties,
  addProperty
};