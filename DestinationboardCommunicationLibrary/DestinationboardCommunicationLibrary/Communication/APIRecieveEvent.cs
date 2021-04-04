using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestinationboardCommunicationLibrary.Communication
{
    public class APIRecieveEvent<Type> : EventArgs
    {
        public APIRecieveEvent(Type request)
        {
            this.Request = request;
        }

        public Type Request { get; set; }
    }
}
