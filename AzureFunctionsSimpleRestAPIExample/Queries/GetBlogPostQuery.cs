using System;
using AzureFromTheTrenches.Commanding.Abstractions;
using AzureFunctionsSimpleRestAPIExample.Model;

namespace AzureFunctionsSimpleRestAPIExample.Queries
{
    public class GetBlogPostQuery : ICommand<BlogPost>
    {
        public Guid PostId { get; set; }
    }
}
