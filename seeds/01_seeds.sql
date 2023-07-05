
INSERT INTO users (name, email, password)
VALUES
  ('John Doe', 'john.doe@example.com', '$2a$10$FB/BOAVhpuLvpOREQVmvmezD4ED/.JBIDRh70tGevYzYzQgFId2u.'),
  ('Jane Smith', 'jane.smith@example.com', '$2a$10$FB/BOAVhpuLvpOREQVmvmezD4ED/.JBIDRh70tGevYzYzQgFId2u.'),
  ('Mike Johnson', 'mike.johnson@example.com', '$2a$10$FB/BOAVhpuLvpOREQVmvmezD4ED/.JBIDRh70tGevYzYzQgFId2u.'),
  ('Emily Brown', 'emily.brown@example.com', '$2a$10$FB/BOAVhpuLvpOREQVmvmezD4ED/.JBIDRh70tGevYzYzQgFId2u.');

INSERT INTO properties (owner_id, title, description, thumbnail_photo_url, cover_photo_url, cost_per_night, parking_spaces, number_of_bathrooms, number_of_bedrooms, country, street, city, province, post_code, active)
VALUES
  (1, 'Cozy Cottage', 'A charming cottage in the countryside', 'https://example.com/cottage-thumbnail.jpg', 'https://example.com/cottage-cover.jpg', 100, 2, 1, 2, 'United States', '123 Main St', 'Anytown', 'California', '12345', true),
  (2, 'Modern Apartment', 'A stylish apartment in the heart of the city', 'https://example.com/apartment-thumbnail.jpg', 'https://example.com/apartment-cover.jpg', 150, 1, 1, 1, 'United States', '456 Elm St', 'Cityville', 'New York', '67890', true),
  (3, 'Seaside Villa', 'A luxurious villa overlooking the ocean', 'https://example.com/villa-thumbnail.jpg', 'https://example.com/villa-cover.jpg', 300, 3, 2, 3, 'United States', '789 Beach Rd', 'Beachtown', 'Florida', '54321', true),
  (4, 'Mountain Retreat', 'A cozy cabin nestled in the mountains', 'https://example.com/cabin-thumbnail.jpg', 'https://example.com/cabin-cover.jpg', 200, 2, 1, 2, 'United States', '321 Pine Ln', 'Mountainville', 'Colorado', '09876', true);


INSERT INTO reservations (start_date, end_date, property_id, guest_id)
VALUES
  ('2023-06-01', '2023-06-05', 1, 2),
  ('2023-07-15', '2023-07-20', 2, 3),
  ('2023-08-10', '2023-08-15', 3, 1),
  ('2023-09-05', '2023-09-10', 4, 4);


INSERT INTO property_reviews (guest_id, property_id, reservation_id, rating, message)
VALUES
  (2, 1, 1, 5, 'Had a wonderful stay at the cottage!'),
  (3, 2, 2, 4, 'The apartment was clean and comfortable.'),
  (1, 3, 3, 5, 'The villa exceeded our expectations.'),
  (4, 4, 4, 3, 'The cabin had beautiful views.');
