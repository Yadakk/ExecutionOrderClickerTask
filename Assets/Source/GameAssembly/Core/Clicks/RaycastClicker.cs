using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ExecutionOrderClickerTask.GameAssembly
{
    public class RaycastClicker
    {
        private readonly Camera camera;

        public RaycastClicker(Camera camera)
        {
            this.camera = camera; 
        }

        public void Raycast()
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            if (!Physics.Raycast(ray, out var hitInfo)) return;
            if (!hitInfo.collider.TryGetComponent<IClickable>(out var clickable)) return;
            clickable.Click();
        }
    }
}
