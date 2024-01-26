using hc_requires_opt_in.Types;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddTypes()
    .AddDirectiveType<RequiresOptInDirectiveType>()
    .AddDirectiveType<OptInDirectiveType>();

var app = builder.Build();

app.MapGraphQL();

app.RunWithGraphQLCommands(args);
