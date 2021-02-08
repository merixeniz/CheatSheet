select a.emp_no,
b.salary 
FROM employees as a, salaries as b WHERE a.emp_no = b.emb_no;