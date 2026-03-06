-- Step 1: Create Database
CREATE DATABASE SalesDB;
GO

-- Step 2: Use Database
USE SalesDB;
GO

-- Step 3: Create stores table
CREATE TABLE stores (
    store_id INT PRIMARY KEY,
    store_name VARCHAR(100) NOT NULL
);

-- Step 4: Create orders table
CREATE TABLE orders (
    order_id INT PRIMARY KEY,
    store_id INT,
    order_status INT,
    order_date DATE,
    
    FOREIGN KEY (store_id) REFERENCES stores(store_id)
);

-- Step 5: Create order_items table
CREATE TABLE order_items (
    order_item_id INT PRIMARY KEY,
    order_id INT,
    quantity INT,
    list_price DECIMAL(10,2),
    discount DECIMAL(4,2),  -- Example: 0.10 = 10%
    
    FOREIGN KEY (order_id) REFERENCES orders(order_id)
);

-- Step 6: Insert data into stores
INSERT INTO stores VALUES
(1, 'Pune Store'),
(2, 'Mumbai Store'),
(3, 'Delhi Store');

-- Step 7: Insert data into orders
INSERT INTO orders VALUES
(101, 1, 4, '2024-01-10'),   -- Completed
(102, 1, 3, '2024-01-12'),   -- Not completed
(103, 2, 4, '2024-01-15'),   -- Completed
(104, 3, 4, '2024-01-20');   -- Completed

-- Step 8: Insert data into order_items
INSERT INTO order_items VALUES
(1, 101, 2, 1000, 0.10),
(2, 101, 1, 500, 0.05),
(3, 102, 3, 700, 0.10),   -- Not counted (order_status != 4)
(4, 103, 5, 800, 0.15),
(5, 104, 4, 1200, 0.20);

-- Step 9: Final Required Query
SELECT 
    s.store_name,
    SUM(oi.quantity * oi.list_price * (1 - oi.discount)) AS total_sales
FROM stores s
INNER JOIN orders o 
    ON s.store_id = o.store_id
INNER JOIN order_items oi 
    ON o.order_id = oi.order_id
WHERE o.order_status = 4
GROUP BY s.store_name
ORDER BY total_sales DESC;