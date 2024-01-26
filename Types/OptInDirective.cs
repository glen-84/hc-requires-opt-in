namespace hc_requires_opt_in.Types;

public sealed class OptInDirective
{
    public string Feature { get; private set; }

    public OptInDirective(string feature)
    {
        this.Feature = feature;
    }
}