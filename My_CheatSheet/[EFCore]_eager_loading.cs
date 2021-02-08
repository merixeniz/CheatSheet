//with eager loading we can load extra data that normally we would have to ask for it in separate calls
_db.Books.Include(u => u.Publisher).FirstOrDefault(u => u.Book_Id = id);

//w przypdaku inner join 'a