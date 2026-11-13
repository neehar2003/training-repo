CREATE TABLE students
(
    id SERIAL PRIMARY KEY,
    name VARCHAR(100),
    age INT,
    city VARCHAR(100)
);

INSERT INTO students (name, age, city) VALUES ('Neehar', 23, 'Kerala');
INSERT INTO students (name, age, city) VALUES ('Rahul', 22, 'Mumbai');
INSERT INTO students (name, age, city) VALUES ('Sidharth', 20, 'Delhi');
