//with use of fluent API 
//in AppDbContext:
//in EFCore 3.1
//then in our class that connects both tables (BookAuthorClass) we have to add 
//two foreign keys!!!
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<BookAuthor>().HasKey(a => new { a.Author_Id, a.Book_Id});
}

//in both classes (Book ) and Author we have to add:
public virtual ICollection <BookAuthor> BookAuthor {get;set;}