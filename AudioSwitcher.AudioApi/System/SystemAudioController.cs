﻿using System.Runtime.InteropServices;

namespace AudioSwitcher.AudioApi.System
{
    [ComVisible(false)]
    public sealed class SystemAudioController : AudioController<SystemAudioDevice>
    {
        public SystemAudioController()
            : base(new SystemDeviceEnumerator())
        {
        }
    }
}