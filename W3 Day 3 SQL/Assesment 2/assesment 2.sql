-- Step 1: Create Database
CREATE DATABASE StoreDB2;
GO

-- Step 2: Use Database
USE StoreDB2;
GO

-- Step 3: Create brands table
CREATE TABLE brands (
    brand_id INT PRIMARY KEY,
    brand_name VARCHAR(50) NOT NULL
);

-- Step 4: Create categories table
CREATE TABLE categories (
    category_id INT PRIMARY KEY,
    category_name VARCHAR(50) NOT NULL
);

-- Step 5: Create products table
CREATE TABLE products (
    product_id INT PRIMARY KEY,
    product_name VARCHAR(100) NOT NULL,
    brand_id INT,
    category_id INT,
    model_year INT,
    list_price DECIMAL(10,2),
    
    FOREIGN KEY (brand_id) REFERENCES brands(brand_id),
    FOREIGN KEY (category_id) REFERENCES categories(category_id)
);

-- Step 6: Insert data into brands
INSERT INTO brands VALUES
(1, 'Nike'),
(2, 'Adidas'),
(3, 'Puma');

-- Step 7: Insert data into categories
INSERT INTO categories VALUES
(1, 'Shoes'),
(2, 'Clothing'),
(3, 'Accessories');

-- Step 8: Insert data into products
INSERT INTO products VALUES
(1, 'Running Shoes', 1, 1, 2023, 750),
(2, 'Sports T-Shirt', 2, 2, 2022, 450),
(3, 'Football Shoes', 3, 1, 2023, 900),
(4, 'Cap', 1, 3, 2021, 300),
(5, 'Jacket', 2, 2, 2023, 1200);

-- Step 9: Final Required Query
SELECT 
    p.product_name,
    b.brand_name,
    c.category_name,
    p.model_year,
    p.list_price
FROM products p
INNER JOIN brands b 
    ON p.brand_id = b.brand_id
INNER JOIN categories c 
    ON p.category_id = c.category_id
WHERE p.list_price > 500
ORDER BY p.list_price ASC;