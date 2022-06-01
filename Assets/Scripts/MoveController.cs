using UnityEngine;
using UnityEngine.InputSystem;

public class MoveController : MonoBehaviour
{
    [SerializeField] private Vector3 moveFinal;
    [SerializeField] private CharacterController controller;
    [SerializeField] private float speed;

    public void OnMove(InputAction.CallbackContext context)
    {
        var move = context.ReadValue<Vector2>();
        moveFinal = new Vector3(move.x, 0, move.y);
    }

    private void FixedUpdate()
    {
        controller.Move(moveFinal * speed * Time.deltaTime);
    }
}