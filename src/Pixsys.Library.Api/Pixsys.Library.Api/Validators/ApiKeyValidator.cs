using Pixsys.Library.Api.Interfaces;

namespace Pixsys.Library.Api.Validators
{
    /// <inheritdoc/>
    public class ApiKeyValidator : IApiKeyValidator
    {
        /// <inheritdoc/>
        public bool IsValid(string apiKey)
        {
            return !string.IsNullOrWhiteSpace(apiKey);
        }
    }
}
