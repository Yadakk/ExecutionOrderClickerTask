using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ExecutionOrderClickerTask.GameAssembly
{
    public class PlayerInputInvoker
    {
        private readonly PlayerInputListener listener;
        private readonly RaycastClicker raycastClicker;

        public PlayerInputInvoker(PlayerInputListener listener, RaycastClicker raycastClicker)
        {
            this.listener = listener;
            this.raycastClicker = raycastClicker;
            Bind();
        }

        private void OnClickHandler()
        {
            raycastClicker.Raycast();
        }

        private void OnQuitHandler()
        {
            Application.Quit();
        }

        private void Bind()
        {
            listener.OnClick += OnClickHandler;
            listener.OnQuit += OnQuitHandler;
        }
    }
}
