using System.Net.Http;
using System.Text;

namespace OpenAi.Api.V1
{
    /// <summary>
    /// Represents an API endpoint
    /// </summary>
    public interface IApiResource
    {
        /// <summary>
        /// The parent reosurce object.
        /// </summary>
        IApiResource ParentResource { get; }

        /// <summary>
        /// The endpoint of the resource.
        /// </summary>
        string Endpoint { get; }

        /// <summary>
        /// The full constucted url to the endpoint
        /// </summary>
        string Url { get; }

        /// <summary>
        /// Construct to the endpoint by passing a string builder to parents
        /// </summary>
        /// <param name="sb"></param>
        void ConstructEndpoint(StringBuilder sb);

        /// <summary>
        /// Populates a <see cref="HttpClient"/> with the appropriate auth headers
        /// </summary>
        /// <returns></returns>
        void PopulateAuthHeaders(HttpClient client);
    }
}