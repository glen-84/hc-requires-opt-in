namespace hc_requires_opt_in.Types;

public sealed class OptInDirectiveType : DirectiveType<OptInDirective>
{
    protected override void Configure(IDirectiveTypeDescriptor<OptInDirective> descriptor)
    {
        descriptor
            .Name("optIn")
            .Location(DirectiveLocation.Field);
    }
}