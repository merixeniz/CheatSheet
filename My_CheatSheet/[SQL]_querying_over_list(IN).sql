SELECT * FROM employees WHERE emp_no IN (1001,1006,1108);
--returns values for emp_no = 1001,1006,1108

--How many orders were made by customer 7888, 1082, 12808, 9623
SELECT COUNT(orderid)
FROM orders
WHERE customerid IN (7888, 1082, 12808, 9623)