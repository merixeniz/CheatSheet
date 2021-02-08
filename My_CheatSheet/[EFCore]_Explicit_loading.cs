//if we want to load some data from one to many relationship and have less round trips to db in our for loop 
// use explicit loading, it guaranty that if we won't go to db for duplicate data
_db.Entry(obj).Reference(u=>u.Publisher).Load();