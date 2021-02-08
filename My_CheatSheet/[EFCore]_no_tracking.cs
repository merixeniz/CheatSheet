//we can turn off change tracker in EFCore 
//we have to use AsNoTracking() method from Microsoft.EntityFrameworkCore 
//we will turn it off when we have read-only scenarions (then it's faster)
List<Category> objList = _db.Categories.AsNoTracking().ToList();