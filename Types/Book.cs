namespace hc_requires_opt_in.Types;

public record Book([property: RequiresOptIn("test")] string Title, Author Author);
