using System;
using System.Net.Http;
using AzureFromTheTrenches.Commanding.AzureFunctions;
using AzureFunctionsSimpleRestAPIExample.Queries;

namespace AzureFunctionsSimpleRestAPIExample
{
    public class ServerlessBlogConfiguration : IFunctionAppConfiguration
    {
        public void Build(IFunctionHostBuilder builder)
        {
            builder
                .Setup((serviceCollection, commandRegistry) =>
                {
                    commandRegistry.Discover<ServerlessBlogConfiguration>();
                })
                .Functions(functions => functions
                    .HttpRoute("/api/v1/post", route => route
                        .HttpFunction<GetBlogPostQuery>(HttpMethod.Get)
                    )
                );
        }
    }
}
