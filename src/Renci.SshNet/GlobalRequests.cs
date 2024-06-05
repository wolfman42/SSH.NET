using System;

using Renci.SshNet.Messages.Connection;

namespace Renci.SshNet
{
    /// <summary>
    /// Responds to SSH Global Requests (https://tools.ietf.org/html/rfc4254#section-4).
    /// </summary>
    internal static class GlobalRequests
    {
        /// <summary>
        /// Handles global request events. By default, it replies with a failure message which is appropriate to
        /// support server keepalives (https://tools.ietf.org/html/rfc4254#section-4).
        /// </summary>
        internal static void GlobalRequestHandler(object sender, EventArgs e)
        {
            if (sender is ISession session)
            {
                session.SendMessage(new RequestFailureMessage());
            }
        }
    }
}
