GRANT [SELECT,UPDATE,INSERT,...] ON <table> [IN SCHEMA <schema>]
TO <user>

--to take privieleges from user use:
REVOKE [SELECT..] ON <tablename> FROM <user>

--we can create roles with specific privileges and then
--grant them to user