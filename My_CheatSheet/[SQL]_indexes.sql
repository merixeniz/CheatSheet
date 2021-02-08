CREATE UNIQUE INDEX <name> 
on <table> (col1,col2,...);

Drop index <name>

--adding index with specific algorithm:
CREATE UNIQUE INDEX <name> 
ON <table> USING <method> (col1,..);
