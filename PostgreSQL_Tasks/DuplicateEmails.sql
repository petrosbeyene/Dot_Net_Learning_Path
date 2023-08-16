SELECT email From Person 
GROUP BY email
HAVING COUNT(*) > 1;