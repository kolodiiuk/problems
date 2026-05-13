select 
  min(r.score) min, 
  percentile_cont(0.5) 
    within group (order by score) median, 
  max(r.score) max
from result r;
