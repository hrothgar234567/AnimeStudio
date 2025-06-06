﻿using System.Runtime.InteropServices;
using AnimeStudio.FbxInterop;

namespace AnimeStudio
{
    partial class Fbx
    {

        [DllImport(FbxDll.DllName)]
        private static extern void AsUtilQuaternionToEuler(float qx, float qy, float qz, float qw, out float vx, out float vy, out float vz);

        [DllImport(FbxDll.DllName)]
        private static extern void AsUtilEulerToQuaternion(float vx, float vy, float vz, out float qx, out float qy, out float qz, out float qw);

    }
}
