using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Industrial
{
    interface IHttpClientHandlerService
    {
        HttpClientHandler GetInsecureHandler();
    }
}
