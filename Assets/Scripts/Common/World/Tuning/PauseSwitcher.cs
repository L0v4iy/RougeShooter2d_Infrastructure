using System;
using UnityEngine;

namespace Common.World.Tuning
{
    public static class PauseSwitcher
    {
        private static float TimeScale { get; set; }

        public static void SwitchPause()
        {
            if (Time.timeScale < 0.5f)
                UnsetPause();
            else
                SetPause();
        }

        private static void SetPause()
        {
            // to prevent double pause;
            if (Math.Abs(TimeScale) <= 0.1)
                TimeScale = Time.timeScale;
            Time.timeScale = 0;
        }

        private static void UnsetPause()
        {
            Time.timeScale = TimeScale;
        }
    }
}