using System;
using BalsaCore;
using UnityEngine;

namespace IUnderstand
{
    [BalsaAddon]
    public class Loader
    {
        private static bool loaded = false;
        private static GameObject go;
        private static MonoBehaviour mod;

        //Game start
        [BalsaAddonInit]
        public static void BalsaInit()
        {
            if (!loaded)
            {
                loaded = true;
                go = new GameObject();
                mod = go.AddComponent<IUnderstandMain>();
            }
        }

        //Game exit
        [BalsaAddonFinalize]
        public static void BalsaFinalize()
        {
        }
    }
}
