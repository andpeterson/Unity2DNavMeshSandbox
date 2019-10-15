using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 destination;

    public float moveSpeed = 5f;
    public Animator animator;
    private NavMeshAgent agent;
    public Vector2 desitination;
    public Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 desitination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            desitination.z = 0;
            agent.SetDestination(desitination);
        }
        velocity = agent.velocity;
        animator.SetFloat("X", velocity.x);
        animator.SetFloat("Y", velocity.y);
        animator.SetFloat("Speed", velocity.magnitude);
    }
}
