public class Book 
{
    public int Book_Id { get; set; }
    public string Title { get; set; }
    public string ISBN { get; set; }

    [ForeignKey("Publisher")]
    public int Publisher_id { get; set; }
    public Publisher Publisher {get;set;}
}

public class Publisher
{
    public int Publisher_id { get; set; }
    public string Name { get; set; }
    public List<Book> Books { get; set; }
}