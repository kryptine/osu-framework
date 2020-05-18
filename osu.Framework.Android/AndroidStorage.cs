﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using Android.App;
using osu.Framework.Platform;

namespace osu.Framework.Android
{
    public class AndroidStorage : NativeStorage
    {
        public AndroidStorage(string path, GameHost host)
            : base(path, host)
        {
        }

        public override void OpenInNativeExplorer()
        {
            //Not needed now.
            throw new NotImplementedException();
        }
    }
}
