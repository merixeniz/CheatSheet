public class FluentPublisherConfig : IEntityTypeConfiguration<Fluent_Publisher>
{
    public void Configure(EntityTypeBuilder<Fluent_Publisher> builder)
    {
        modelBuilder.Property(c => c.Title)
                    .HasMaxLength(15);
    }
}

//then in OnModelCreating
modelBuilder.ApplyConfiguration(new FluentPublisherConfig());