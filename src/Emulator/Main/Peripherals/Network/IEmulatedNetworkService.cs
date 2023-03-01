//
// Copyright (c) 2010-2023 Antmicro
//
// This file is licensed under the MIT License.
// Full license text is available in 'licenses/MIT.txt'.
//

using System;
using Antmicro.Renode.Core;

namespace Antmicro.Renode.Peripherals.Network
{
    public interface IEmulatedNetworkService : IExternal, IDisposable
    {
        byte[] Receive(int bytes);
        bool Send(byte[] data);

        int BytesAvailable { get; }

        event Action<int> BytesReceived;

        string Host { get; }
        ushort Port { get; }
    }
}
