//data annotations 
public class Book 
{
    [ForeignKey("Category")]
    public int Category_Id { get; set; }
    public Category Category {get;set;}
}
