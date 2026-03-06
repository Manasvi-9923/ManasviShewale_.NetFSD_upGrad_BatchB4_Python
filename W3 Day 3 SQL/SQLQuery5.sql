CREATE DATABASE SaveDB;
USE SaveDB;
CREATE TABLE customers1 (
    customer_id INT PRIMARY KEY,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL
);
CREATE TABLE orders1 (
    order_id INT PRIMARY KEY,
    customer_id INT,
    order_date DATE,
    order_status INT,
    FOREIGN KEY (customer_id) REFERENCES customers1(customer_id)
);
INSERT INTO customers1 VALUES
(1, 'Amit', 'Sharma'),
(2, 'Neha', 'Patil'),
(3, 'Rahul', 'Verma'),
(4, 'Priya', 'Singh');

INSERT INTO orders1 VALUES
(101, 1, '2026-03-01', 4),
(102, 2, '2026-03-02', 1),
(103, 3, '2026-02-25', 2),
(104, 4, '2026-03-03', 1),
(105, 1, '2026-02-20', 4);


SELECT 
    c.first_name,
    c.last_name,
    o.order_id,
    o.order_date,
    o.order_status
FROM customers1 c
INNER JOIN orders1 o
    ON c.customer_id = o.customer_id
WHERE 
    o.order_status = 1 
    OR o.order_status = 4
ORDER BY 
    o.order_date DESC;
