SELECT
  properties.city,
  COUNT(reservations) AS total_Reservations
FROM
  reservations
JOIN 
  properties ON property_id = properties.id
GROUP BY 
  properties.city
ORDER BY 
  total_reservations DESC;