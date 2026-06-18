namespace Pixsys.Library.Api.Models
{
    /// <summary>
    /// The authenticated response model.
    /// </summary>
    public class AuthenticatedResponse
    {
        /// <summary>
        /// Gets or sets the token.
        /// </summary>
        public string? Token { get; set; }

        /// <summary>
        /// Gets or sets the refresh token.
        /// </summary>
        public string? RefreshToken { get; set; }
    }
}