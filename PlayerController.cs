using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController _characterController;
    private float _verticalVelocity;

    public float facing = 0;
    public float MovementSpeed = 10f, jumpForce = 10f, gravity = -30f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

public void Move(Vector2 movementVector)
    {
        Vector3 move = transform.forward * movementVector.y + transform.right * movementVector.x;
        facing = movementVector.x;
        move = move * MovementSpeed * Time.deltaTime;
        _characterController.Move(move);

        _verticalVelocity = _verticalVelocity + gravity * Time.deltaTime;
        _characterController.Move(new Vector3(0,_verticalVelocity,0)*Time.deltaTime);
    }

public void jump()
    {
        _verticalVelocity = jumpForce;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
