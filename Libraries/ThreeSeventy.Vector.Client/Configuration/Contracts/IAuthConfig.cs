namespace ThreeSeventy.Vector.Client
{
    /// <summary>
    /// Details for user authentication
    /// </summary>
    public interface IAuthConfig
    {
        /// <summary>
        /// The api key to use.
        /// </summary>
        string ApiKey { get; set; }

        /// <summary>
        /// The Secret to use.
        /// </summary>
        string Secret { get; set; }
    }
}