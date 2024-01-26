using System.Reflection;
using HotChocolate.Types.Descriptors;

namespace hc_requires_opt_in.Types;

public sealed class RequiresOptInAttribute : ObjectFieldDescriptorAttribute
{
    private readonly string feature;

    public RequiresOptInAttribute(string feature)
    {
        this.feature = feature;
    }

    protected override void OnConfigure(IDescriptorContext context, IObjectFieldDescriptor descriptor, MemberInfo member)
    {
        descriptor.Directive(new RequiresOptInDirective(this.feature));
    }
}