using Microsoft.AspNetCore.Mvc;
using Pixsys.Library.Api.Filters;

namespace Pixsys.Library.Api.Attributes
{
    /// <summary>
    /// Specifies that the ApiKey is required to perform this action.
    /// </summary>
    /// <seealso cref="ServiceFilterAttribute" />
    public class ApiKeyAttribute : ServiceFilterAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyAttribute"/> class.
        /// </summary>
        public ApiKeyAttribute()
            : base(typeof(ApiKeyAuthorizationFilter))
        {
        }
    }
}