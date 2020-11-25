using System;
using System.Web;

namespace Lenta.Shared.Extensions
{
    public static class UriBuilderExtensions
    {
        public static UriBuilder UpdateQuery(this UriBuilder uriBuilder, string queryKey, string queryValue)
        {
            var uriQuery = HttpUtility.ParseQueryString(uriBuilder.Query);
            uriQuery[queryKey] = queryValue;
            uriBuilder.Query = uriQuery.ToString();

            return uriBuilder;
        }

        public static UriBuilder AddQuery(this UriBuilder uriBuilder, string queryKey, string queryValue)
        {
            var uriQuery = HttpUtility.ParseQueryString(uriBuilder.Query);
            uriQuery.Add(queryKey, queryValue);
            uriBuilder.Query = uriQuery.ToString();

            return uriBuilder;
        }

        public static UriBuilder ClearQuery(this UriBuilder uriBuilder)
        {
            uriBuilder.Query = "";

            return uriBuilder;
        }
    }
}
