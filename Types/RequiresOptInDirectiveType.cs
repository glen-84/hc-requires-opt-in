namespace hc_requires_opt_in.Types;

public sealed class RequiresOptInDirectiveType : DirectiveType<RequiresOptInDirective>
{
    protected override void Configure(IDirectiveTypeDescriptor<RequiresOptInDirective> descriptor)
    {
        descriptor
            .Name("requiresOptIn")
            .Location(DirectiveLocation.FieldDefinition)
            .Use((next, directive) => context =>
            {
                var optInDirective = context.Selection.SyntaxNode.Directives
                    .Where(d => d.Name.Value == "optIn")
                    .SingleOrDefault();

                var optInFeature = optInDirective?.Arguments
                    .Where(a => a.Name.Value == "feature")
                    .Single().Value.Value?.ToString();

                var requiresOptInFeature = directive.GetArgumentValue<string>("feature");

                if (optInFeature != requiresOptInFeature)
                {
                    context.ReportError($"The feature '{requiresOptInFeature}' is not enabled.");
                }

                return next.Invoke(context);
            });
    }
}