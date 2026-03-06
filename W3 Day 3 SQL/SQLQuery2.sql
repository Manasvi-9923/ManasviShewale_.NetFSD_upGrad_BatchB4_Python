-- Delete table if already exists
DROP TABLE IF EXISTS Staff;

-- Create Table
CREATE TABLE Staff (
    StaffId INT PRIMARY KEY,
    StaffName VARCHAR(50) NOT NULL,
    Salary DECIMAL(10,2) NOT NULL
);

-- Insert Data
INSERT INTO Staff VALUES
(1, 'Amit', 40000),
(2, 'Rahul', 50000),
(3, 'Neha', 40000),
(4, 'Priya', 60000),
(5, 'Sneha', 50000);

-- Find Duplicate Salaries Using SELF JOIN
SELECT 
    s1.StaffId,
    s1.StaffName,
    s1.Salary
FROM Staff s1
INNER JOIN Staff s2
    ON s1.Salary = s2.Salary
    AND s1.StaffId <> s2.StaffId
ORDER BY s1.Salary;