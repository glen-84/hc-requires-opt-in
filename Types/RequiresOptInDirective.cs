namespace hc_requires_opt_in.Types;

public sealed class RequiresOptInDirective
{
    public string Feature { get; private set; }

    public RequiresOptInDirective(string feature)
    {
        this.Feature = feature;
    }
}