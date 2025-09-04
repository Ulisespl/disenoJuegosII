using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 3;
    Rigidbody2D rb2d;
    Vector2 moveInput;
    private Animator animator;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        moveInput = moveInput.normalized;

        animator.SetFloat("Horizontal", Mathf.Abs(moveInput.x));
        animator.SetFloat("Vertical", Mathf.Abs(moveInput.y));

        ChekFlip();
        OpenCloseInventory();
    }

    void FixedUpdate()
    {
        rb2d.linearVelocity = moveInput * speed;
    }

    void ChekFlip()
    {
        if (moveInput.x > 0 && transform.localScale.x < 0 || moveInput.x < 0 && transform.localScale.x > 0)
        {
            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
        }
    }

    void OpenCloseInventory()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            UIManager.Instance.OpenOrCloseInventory();
        }
    }
}
