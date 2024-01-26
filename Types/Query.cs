namespace hc_requires_opt_in.Types;

[QueryType]
public static class Query
{
    public static Book GetBook()
        => new Book("C# in depth.", new Author("Jon Skeet"));
}
