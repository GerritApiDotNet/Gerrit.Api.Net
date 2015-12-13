using System.Text;

namespace Gerrit.Api.Common.Extensions
{
    internal static class StringBuilderExtensions
    {
        public static StringBuilder AppendQueryStringPart(this StringBuilder stringBuilder, string queryStringPart)
        {
            if (string.IsNullOrWhiteSpace(queryStringPart))
            {
                return stringBuilder;
            }

            if (stringBuilder.Length > 1)
            {
                stringBuilder.Append("&");
            }

            stringBuilder.Append(queryStringPart);

            return stringBuilder;
        }
    }
}
