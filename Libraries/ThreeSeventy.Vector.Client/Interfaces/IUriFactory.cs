namespace ThreeSeventy.Vector.Client
{
    /// <summary>
    /// Interface for URI generation factory.
    /// </summary>
    public interface IUriFactory
    {
        /// <summary>
        /// Generate a URI for calling the TrueDialog APIs.
        /// </summary>
        /// <returns>A string representing the base URI to the TrueDialog APIs.</returns>
        string Create();
    }
}