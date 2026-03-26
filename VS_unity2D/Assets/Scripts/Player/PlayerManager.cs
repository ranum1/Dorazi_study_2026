using NUnit.Framework;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    PlayerInput playerInput;
    SpriteRenderer spriter;
    Rigidbody2D rb;
    Vector2 moveVec;

    Animator anim;
    public float speed = 4f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        rb = GetComponent<Rigidbody2D>();
        spriter = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        // 실제 이동 로직은 Update나 FixedUpdate에서 moveInput을 사용해 처리합니다.
        // 
        rb.linearVelocity = new Vector2(moveVec.x * speed, moveVec.y * speed);
        spriter.flipX = (moveVec.x > 0 ? false : true);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveVec = context.ReadValue<Vector2>();
        if (context.phase == InputActionPhase.Performed)
        {
            anim.SetBool("isRun", true);
        }
        else if (context.phase == InputActionPhase.Canceled)
        {
            anim.SetBool("isRun", false);
        }
    }
}
