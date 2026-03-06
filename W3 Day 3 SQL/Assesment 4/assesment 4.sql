-- Step 1: Create Database
CREATE DATABASE InventoryDB;
GO

-- Step 2: Use Database
USE InventoryDB;
GO

-- Step 3: Create products table
CREATE TABLE products (
    product_id INT PRIMARY KEY,
    product_name VARCHAR(100) NOT NULL
);

-- Step 4: Create stores table
CREATE TABLE stores (
    store_id INT PRIMARY KEY,
    store_name VARCHAR(100) NOT NULL
);

-- Step 5: Create stocks table
CREATE TABLE stocks (
    store_id INT,
    product_id INT,
    quantity INT,
    PRIMARY KEY (store_id, product_id),
    FOREIGN KEY (store_id) REFERENCES stores(store_id),
    FOREIGN KEY (product_id) REFERENCES products(product_id)
);

-- Step 6: Create orders table
CREATE TABLE orders (
    order_id INT PRIMARY KEY,
    store_id INT,
    order_status INT,
    FOREIGN KEY (store_id) REFERENCES stores(store_id)
);

-- Step 7: Create order_items table
CREATE TABLE order_items (
    order_item_id INT PRIMARY KEY,
    order_id INT,
    product_id INT,
    quantity INT,
    FOREIGN KEY (order_id) REFERENCES orders(order_id),
    FOREIGN KEY (product_id) REFERENCES products(product_id)
);

-- Step 8: Insert data into products
INSERT INTO products VALUES
(1, 'Laptop'),
(2, 'Mobile'),
(3, 'Tablet');

-- Step 9: Insert data into stores
INSERT INTO stores VALUES
(1, 'Pune Store'),
(2, 'Mumbai Store');

-- Step 10: Insert stock data
INSERT INTO stocks VALUES
(1, 1, 50),
(1, 2, 30),
(1, 3, 20),
(2, 1, 40),
(2, 2, 25);

-- Step 11: Insert orders
INSERT INTO orders VALUES
(101, 1, 4),
(102, 2, 4);

-- Step 12: Insert order_items
INSERT INTO order_items VALUES
(1, 101, 1, 5),
(2, 101, 2, 3),
(3, 102, 1, 7);
SELECT 
    p.product_name,
    s.store_name,
    st.quantity AS available_stock,
    ISNULL(SUM(oi.quantity), 0) AS total_quantity_sold
FROM stocks st
INNER JOIN products p 
    ON st.product_id = p.product_id
INNER JOIN stores s 
    ON st.store_id = s.store_id
LEFT JOIN orders o 
    ON st.store_id = o.store_id
LEFT JOIN order_items oi 
    ON o.order_id = oi.order_id
    AND st.product_id = oi.product_id
GROUP BY 
    p.product_name,
    s.store_name,
    st.quantity
ORDER BY 
    p.product_name;