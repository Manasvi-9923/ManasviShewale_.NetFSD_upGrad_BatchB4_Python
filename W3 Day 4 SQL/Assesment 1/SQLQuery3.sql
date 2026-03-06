
USE EcommDb;
SELECT * FROM products;
SELECT 
product_name + ' (' + CAST(model_year AS VARCHAR) + ')' AS Product,
model_year,
list_price,

(SELECT AVG(p2.list_price)
 FROM products p2
 WHERE p2.category_id = p1.category_id) AS CategoryAvgPrice,

list_price -
(SELECT AVG(p2.list_price)
 FROM products p2
 WHERE p2.category_id = p1.category_id) AS PriceDifference

FROM products p1

WHERE list_price >
(SELECT AVG(p2.list_price)
 FROM products p2
 WHERE p2.category_id = p1.category_id);