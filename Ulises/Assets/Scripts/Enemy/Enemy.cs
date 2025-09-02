
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{

    public float speed = 2;
    private Rigidbody2D rb2d;
    public Transform target;

    NavMeshAgent navMeshAgent;

    Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();

        navMeshAgent.updateRotation = false;
        navMeshAgent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        navMeshAgent.SetDestination(target.position);

        AdjustAnimationRotation();
    }

    public void AdjustAnimationRotation()
    {
        bool isMoving = navMeshAgent.velocity.sqrMagnitude > 0.1f;

        animator.SetBool("IsRunning", isMoving);

        if (navMeshAgent.desiredVelocity.x > 0.01f)
            transform.localScale = new Vector3(1, 1, 1);

         if (navMeshAgent.desiredVelocity.x < -0.01f)
            transform.localScale = new Vector3(-1, 1, 1);
    }
}
