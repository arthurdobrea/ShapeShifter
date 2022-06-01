using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] public Vector3 offset;
    [SerializeField] private float smoothSpeed = 0.125f;
    [SerializeField] private float rotationSpeed = 0.125f;

    
    public void OnMouseLook(InputAction.CallbackContext context)
    {
        // move = context.ReadValue<Vector2>();
        Quaternion camturnAgnle = Quaternion.AngleAxis(context.ReadValue<Vector2>().x * rotationSpeed, Vector3.up);

        offset = camturnAgnle * offset;
    }
    public void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;
        transform.LookAt(target.transform);
    }
}
