using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{

    PlayerInput playerInput;
    Rigidbody2D rb;
    Vector2 moveVec;
    public float speed = 4f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        // 실제 이동 로직은 Update나 FixedUpdate에서 moveInput을 사용해 처리합니다.
        // 
        rb.linearVelocity = new Vector2(moveVec.x * speed, moveVec.y * speed);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveVec = context.ReadValue<Vector2>();

     
    }
}
