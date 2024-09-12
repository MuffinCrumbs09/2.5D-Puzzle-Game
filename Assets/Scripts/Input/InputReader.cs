using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputReader : MonoBehaviour, Controls.IPlayerActions
{
    #region Public Variables
    public Vector2 MovementValue {  get; private set; }
    #endregion

    #region Private Variables
    private Controls _controls;
    #endregion

    #region Events

    #endregion

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        _controls = new Controls();
        _controls.Player.SetCallbacks(this);

        _controls.Player.Enable();
    }

    private void OnDestroy()
    {
        _controls.Player.Disable();
    }

    public void ToggleControls(bool toggle)
    {
        if (toggle)
            _controls.Player.Enable();
        else
            _controls.Player.Disable();
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        MovementValue = context.ReadValue<Vector2>();
    }
}
