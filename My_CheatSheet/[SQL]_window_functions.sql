--applying calculations to each row in group by statement that is connected to some value already. 
--(ex. count difference between employee salary from avg salary in each department)

--Window functions create a new column based on functions performed on a subset or window of the data

SELECT 
    *,
    MAX(salary) OVER()
FROM salaries

--it shows employee salary and max salary paid in the company ( for comparision) (in each row)

--when you apply where filter, window function will apply only to that filtered set of data.

--partition by allows for executing window functions agains partition of data separatly