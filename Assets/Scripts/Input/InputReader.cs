using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputReader : MonoBehaviour, Controls.IPlayerActions
{
    #region Public Variables
    public Vector2 MovementValue {  get; private set; }
    public bool isSprint {  get; private set; }
    #endregion

    #region Private Variables
    private Controls _controls;
    #endregion

    #region Events

    #endregion

    private void Start()
    {
        // Lock cursor to game window and hide it
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        // Create control scheme and set the callback to this script
        _controls = new Controls();
        _controls.Player.SetCallbacks(this);

        _controls.Player.Enable();
    }
    
    // If the gameobject gets destroyed, disable input
    private void OnDestroy()
    {
        _controls.Player.Disable();
    }

    // Toggle input on or off
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

    public void OnSprint(InputAction.CallbackContext context)
    {
        isSprint = context.performed;
    }
}
