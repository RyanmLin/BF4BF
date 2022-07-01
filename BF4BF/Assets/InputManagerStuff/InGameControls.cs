using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InGameControls : MonoBehaviour
{
    public InputManager inputActions; // Control Reference

    // Script References
    private EggController eggController;

    // Input State Variables
    private float verticalAxis;

    void Awake()
    {
        eggController = GetComponent<EggController>();

        verticalAxis = 0f;
        inputActions = new InputManager();
    }

    private void OnEnable()
    {
        inputActions.Enable();
        
        inputActions.Player.HorizontalMovement.performed += OnMoveInput;
    }

    private void OnDisable()
    {
        inputActions.Player.HorizontalMovement.performed -= OnMoveInput;

        inputActions.Disable();
    }

    private void OnMoveInput(InputAction.CallbackContext context)
    {
        var value = context.ReadValue<float>();
        // Handling for gamepads to make equivalent to keyboard
        // Keyboard is either on or off. Gamepad has range from 0 - 1
        // TODO: See if we desire on/off or if we want to make keyboard function similar to joystick in some way
        if (value >= 0.15f) {
            value = 1f;
        }
        else if (value <= -0.15f) {
            value = -1f;
        }
        else {
            value = 0f;
        }

        if(eggController != null)
        {
            eggController.Move(value);
        }

    }
}
