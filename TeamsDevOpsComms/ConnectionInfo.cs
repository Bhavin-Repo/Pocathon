using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamsDevOpsComms
{
    public static class ConnectionInfo
    {
        public static  Uri _uri;
        public static  string _personalAccessToken;       
        public static  Guid _projectGuid;

        static ConnectionInfo()
        {
            _uri = new Uri("https://dev.azure.com/Vikas0606");
            _personalAccessToken = "3tr7x5svpfdzuz6ipst6n4roillvypclj27slar246tsyxqq5taq";
            _projectGuid = new Guid("3c450cd4-2df4-4b80-a703-39cf244909d9");
        }
    }
}
