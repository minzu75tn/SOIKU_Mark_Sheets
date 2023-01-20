using System;

namespace WEB_UPLOADS
{
    public class Common
    {
        public static string ExtractHostDomain(string URL)
        {
            string host_domain = "";

            if (URL.IndexOf("://") > -1)
            {
                host_domain = URL.Split('/')[2];
            }
            else
            {
                host_domain = URL.Split('/')[0];
            }
            host_domain = host_domain.Split(':')[0];

            return host_domain;
        }

    }
}
