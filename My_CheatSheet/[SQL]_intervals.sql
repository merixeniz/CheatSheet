--selecting purchases that happend 30 days before now;
SELECT * FROM orders
WHERE purchaseDate <= now() - interval '30 days';

--we can do many intervals ex: 
interval '1 year 2 months 3 days'; 
--etc

--we can also extract some dayta from that