SELECT 
  CAST(s.transaction_date AS date) AS day,
  d.name AS department,
  COUNT(*) AS sale_count
FROM 
  department d
INNER JOIN 
  sale s ON d.id = s.department_id
GROUP BY 
  d.id,
  d.name,
  CAST(s.transaction_date AS date)
ORDER BY 
  CAST(s.transaction_date AS date) ASC,
  d.name;
