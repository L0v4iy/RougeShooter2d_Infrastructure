using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Common.World.Scene
{
    public static class SceneSwitcher
    {
        private static int _previousSceneId;

        public static void SwitchScene(int sceneId)
        {
            if (sceneId >= 0)
                Switch(sceneId);
            else
                throw new ArgumentException("SceneId couldn't be lower than 0");
        }

        public static void SwitchScene(SceneName name)
        {
            if (name.GetHashCode() >= 0)
                Switch(name.GetHashCode());
            else
                throw new ArgumentException("SceneId couldn't be lower than 0");
        }

        private static void Switch(int sceneId) 
        {
            Time.timeScale = 1;
            _previousSceneId = sceneId;
            SceneManager.LoadScene(sceneId);
        }

        public static int GetPreviousSceneId()
        {
            return _previousSceneId;
        }
    }

    /// <summary>
    /// Put here scene names
    /// </summary>
    public enum SceneName
    {
    }
}