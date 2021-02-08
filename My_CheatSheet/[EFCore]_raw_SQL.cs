//to use RAW sql we can use 2 methods, FromSqlRaw and FromSqlInterpolated()
_db.Books.FromSqlRaw("Select * From dbo.books").ToList();
//use interpolated to add parameter to SQL
_db.Books.FromSqlInterpolated($"Select * From dbo.books where Book_id={id}").ToList();
