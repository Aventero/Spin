using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public Vector2 MovementInput;
    public Vector2 Scrollvalue;
    public float Jump;
    public bool Attack;

    public void OnMove(InputAction.CallbackContext context)
    {
        MovementInput = context.ReadValue<Vector2>();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        Jump = context.ReadValue<float>();
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        Attack = context.ReadValueAsButton();
    }

    public void OnScrolling(InputAction.CallbackContext context)
    {
        Scrollvalue = context.ReadValue<Vector2>();
    }
}
