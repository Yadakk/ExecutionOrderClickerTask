using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ExecutionOrderClickerTask.Input
{
    public class PlayerInputListener
    {
        private readonly PlayerInputAsset asset;

        public event System.Action OnClick;
        public event System.Action OnQuit;

        public PlayerInputListener(PlayerInputAsset asset)
        {
            this.asset = asset;
            Bind();
            asset.Enable();
        }

        private void ClickHandler(InputAction.CallbackContext context)
        {
            OnClick?.Invoke();
        }

        private void QuitHandler(InputAction.CallbackContext context)
        {
            OnQuit?.Invoke();
        }

        private void Bind()
        {
            asset.Player.Click.performed += ClickHandler;
            asset.Player.Quit.performed += QuitHandler;
        }
    }
}
