public class Book 
{
    public int Book_Id { get; set; }
    public string Title { get; set; }
    public string ISBN { get; set; }

    [ForeignKey("BookDetail")]
    public int BookDetail_id { get; set; }
    public BookDetail BookDetail {get;set;}
}

public class BookDetail
{
    public int BookDetail_id { get; set; }
    public double Weight { get; set; }
    public Book Book { get; set; }
}