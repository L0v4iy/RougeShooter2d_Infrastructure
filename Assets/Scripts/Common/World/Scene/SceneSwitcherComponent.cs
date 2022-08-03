using UnityEngine;

namespace Common.World.Scene
{
    public class SceneSwitcherComponent : MonoBehaviour
    {
        public void SwitchScene(int sceneId)
        {
            SceneSwitcher.SwitchScene(sceneId);
        }
    }
}