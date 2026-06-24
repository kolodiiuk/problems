select 
  u.id id, 
  u.name as name, 
  u.price price, 
  u.card_name card_name, 
  u.card_number card_number, 
  u.transaction_date transaction_date,
  'US' as location 
from 
  ussales u
where 
  u.price > 50.0

union all

select 
  e.id id, 
  e.name as name, 
  e.price price, 
  e.card_name card_name, 
  e.card_number card_number, 
  e.transaction_date transaction_date,
  'EU' as location 
from 
  eusales e
where 
  e.price > 50.0
order by 
  location desc, 
  id;
