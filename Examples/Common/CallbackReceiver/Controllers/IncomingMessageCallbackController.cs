using System;
using System.Collections.Generic;
using System.Web.Http;

using ThreeSeventy.Vector.Client.Models;

namespace CallbackReceiver.Controllers
{
    /// <summary>
    /// This controller demonstrates how to handle a Incoming Message callback from Vector.
    /// </summary>
    public class IncomingMessageCallbackController : ApiController
    {
        // POST api/IncomingMessageCallback
        /// <summary>
        /// Handles a incoming message callback from Vector.
        /// </summary>
        /// <remarks>
        /// Currently all callbacks made by the Vector system are POST.
        /// </remarks>
        /// <param name="eventData">Details about the incoming message callback</param>
        public string Post(IncomingMessageCallbackEvent eventData)
        {
            if (eventData != null)
            {
                string msg = String.Format(
                    "{0}: Received incoming message callback event from the phonenumber : {1}, message: {2}, on channelId: {3} ",
                    eventData.Timestamp,
                    eventData.PhoneNumber,
                    eventData.Message, eventData.ChannelId);

                return msg;
            }

            return "Invalid event data!";
        }
    }
}
