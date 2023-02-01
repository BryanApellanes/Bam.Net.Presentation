using System;
using Bam.Net.Logging;
using Bam.Net.ServiceProxy;
using Bam.Net.ServiceProxy.Encryption;

namespace Bam.Net.Presentation.ActionProviders
{
    [Serializable]
    [Proxy("actionExecutor")]
    [ApiHmacKeyRequired]
    public class ActionExecutor : Loggable
    {
        public ActionExecutor(ILogger logger = null)
        {
            if (logger != null)
            {
                Subscribe(logger);
            }
        }
        
        public BackgroundThreadQueue<ServiceProxyInvocationRequest> InvocationQueue { get; }

        public ActionExecutor RegisterViewModel(ViewModel viewModel)
        {
            throw new NotImplementedException();
        }
    }
}