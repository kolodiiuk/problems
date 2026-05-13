with filtered_by_len as (
    select lower(s) word
    from retro_comments rc
    cross join lateral regexp_split_to_table(
        rc.msg,
        E'[^a-zA-Z0-9''/_-]+'
    ) s
    where length(s) >= 3
), filtered_by_stopword as (
    select f.word
    from filtered_by_len f
    where not exists (
        select 1
        from stopwords s
        where s.word = f.word
    )
), with_freq as (
  select f.word word, count(*) freq
  from filtered_by_stopword f
  group by f.word
)
select word, freq
from with_freq f
order by f.freq desc, f.word asc
limit 10;
