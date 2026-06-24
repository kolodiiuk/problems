CREATE VIEW members_approved_for_voucher AS (
  WITH above_threshold_deps AS (
    SELECT
      d.id
    FROM
      departments d
    INNER JOIN
      sales s ON d.id = s.department_id
    INNER JOIN
      products p ON s.product_id = p.id
    GROUP BY
      d.id
    HAVING
      SUM(p.price) > 10000
  )
  SELECT
    m.id,
    m.name,
    m.email,
    SUM(p.price) AS total_spending
  FROM
    members m
  INNER JOIN
    sales s ON m.id = s.member_id
  INNER JOIN
    products p ON s.product_id = p.id
  WHERE
    s.department_id IN (SELECT * FROM above_threshold_deps)
  GROUP BY
    m.id
  HAVING
    SUM(p.price) > 1000
);

SELECT 
  *
FROM
  members_approved_for_voucher m
ORDER BY
  m.id;
