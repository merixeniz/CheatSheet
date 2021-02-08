var category = _db.Categories.FirstOrDefault();
_db.Entry(category).State = EntityState.Modified;
_db.SaveChanges();