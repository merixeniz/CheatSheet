protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    //fluent api config
    //required =>
    modelBuilder.Entity<Category>()
                .Property(c => c.Title)
                .IsRequired();

    //Primary key
    modelBuilder.Entity<Category>()
                .HasKey(c => c.Category_ID);
    
    //MaxLength
    modelBuilder.Entity<Category>()
                .Property(c => c.Title)
                .HasMaxLength(15);
    
    //Not mapped
    modelBuilder.Entity<Category>()
                .Ignore(c => c.DiscountPrice);

    //Table name
    modelBuilder.Entity<Category>()
                .ToTable("tab_name");

    //Column name
    modelBuilder.Entity<Category>()
                .Property(c => c.Title)
                .HasColumnName("CategoryTitle");


    //one to one relationship
    modelBuilder.Entity<Books>()
                .HasOne(z => z.BookDetail).WithOne(z => z.Book).HasForeignKey<Books>("BookDetail_Id");

    //one to many relationship
    modelBuilder.Entity<Books>()
                .HasOne(z => z.Publisher).WithMany(z => z.Book).HasForeignKey(b => b.Publisher_id);
    
    //many to many  
    //https://dev.to/ruben_j/many-to-many-relations-in-entity-framework-core-3-1-and-5-59ei
     modelBuilder.Entity<BookGenre>()
        .HasKey(bc => new { bg.BookId, bg.GenreId });

    modelBuilder.Entity<BookGenre>()
        .HasOne(bg => bg.Book)
        .WithMany(b => b.BookGenres)
        .HasForeignKey(bg => bg.BookId); 

    modelBuilder.Entity<BookGenre>()
        .HasOne(bg => bc.Genre)
        .WithMany(g => g.BookGenres)
        .HasForeignKey(bg => bg.GenreId);
    

}

//one to one
public class Book 
{
    public int Book_Id { get; set; }
    public string Title { get; set; }
    public string ISBN { get; set; }

    public int BookDetail_id { get; set; }
    public BookDetail BookDetail {get;set;}
}

public class BookDetail
{
    public int BookDetail_id { get; set; }
    public double Weight { get; set; }
    public Book Book { get; set; }
}

//many to many 
public class Book{
   public int BookId {get;set;}
   public string Name {get;set;}

   public virtual ICollection<BookGenre> BookGenres {get;set;}
}

public class Genre{
   public int GenreId {get;set;}
   public string Name {get;set;}

   public virtual ICollection<BookGenre> BookGenres {get;set;}
}

public class BookGenre{
   public int BookId {get;set;}
   public int GenreId {get;set;}

   public virtual Book Book {get;set;}
   public virtual Genre Genre {get;set;}
}