using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RotateCamera : MonoBehaviour
{
    [SerializeField] private Vector2 move;
    [SerializeField] private float speed;

    public void OnMouseLook(InputAction.CallbackContext context)
    {
        // // move = context.ReadValue<Vector2>();
        // Quaternion camturnAgnle = Quaternion.AngleAxis(context.ReadValue<Vector2>().x * speed, Vector3.up);
        //
        // offset = camturnAgnle * offset;
    }
}