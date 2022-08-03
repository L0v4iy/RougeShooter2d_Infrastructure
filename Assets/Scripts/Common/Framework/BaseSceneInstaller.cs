using System;
using UnityEngine;
using Zenject;

namespace Common.Framework
{
    public abstract class BaseSceneInstaller : MonoInstaller
    {

        protected abstract void InstallSceneBindings();

        public override void InstallBindings()
        {
            // install common bindings like player

            // tabs and panels

            // install single-scene bindings
            InstallSceneBindings();
        }

        private Camera GetCamera()
        {
            Camera cam = Camera.main;
            if (cam == null)
                throw new ApplicationException();
            return cam;
        }
    }
}