public class Book{
   public int BookId {get;set;}
   public string Name {get;set;}

   public virtual ICollection<Genre> Genres {get;set;}
}

public class Genre{
   public int GenreId {get;set;}
   public string Name {get;set;}

   public virtual ICollection<Book> Books {get;set;}
}

modelBuilder.Entity<Genre>()
                .HasMany(e => e.Books)
                .WithMany(e => e.Genres)
                .UsingEntity<BookGenre>(
                bg => bg
                    .HasOne(bg => bg.Book)
                    .WithMany()
                    .HasForeignKey("BookId"),
                bg => bg
                    .HasOne(bg => bg.Genre)
                    .WithMany()
                    .HasForeignKey("GenreId"))
                .ToTable("BookGenres")
                .HasKey(bg => new { bg.BookId, bg.GenreId });
