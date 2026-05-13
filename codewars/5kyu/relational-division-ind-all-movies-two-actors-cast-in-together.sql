with featured_crowe as (
  select film_id
  from film_actor
  where actor_id = 105
),
featured_nolte as (
  select film_id
  from film_actor
  where actor_id = 122
)

SELECT f.title title
from film f
where f.film_id in (select film_id from featured_crowe) 
  and f.film_id in (select film_id from featured_nolte)
order by title asc;
