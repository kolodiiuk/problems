select 
  concat(count(*), 
    ' applications (applicant_ids: ', 
    string_agg(applicant_id::text, ', ' order by applicant_id asc), 
    ') already filed at ', 
    t.house_no, 
    ' ', 
    t.street_name) 
   as audit_note
from 
  energy_rebate_applications t
group by 
  t.street_name, t.house_no
having
  count(*) > 1
order by 
  count(*) desc, 
  t.street_name, 
  t.house_no asc;
