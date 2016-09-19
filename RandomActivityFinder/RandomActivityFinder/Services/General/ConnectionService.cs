using RandomActivityFinder.Core.Contracts.Services;
using Plugin.Connectivity;

namespace RandomActivityFinder.Core.Services.General
{
    public class ConnectionService : IConnectionService
    {
        public bool CheckOnline()
        {
            return CrossConnectivity.Current.IsConnected;
        }
    }
}
