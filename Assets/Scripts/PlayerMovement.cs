using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rigidBody;

    [SerializeField]
    [Range(0, 10)]
    float moveSpeed = 1;

    [SerializeField]
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");

        Vector3 currentPosition = transform.position;

        Vector3 velocity = new Vector3(inputX, inputY, 0) * moveSpeed;
        animator.SetFloat("Speed", velocity.sqrMagnitude);

        CardinalDirection facing = CardinalDirection.SOUTH;
        if (velocity.x > 0 )
        {
            facing = CardinalDirection.EAST;
        }else if (velocity.x < 0)
        {
            facing = CardinalDirection.WEST;
        }else if (velocity.y < 0)
        {
            facing = CardinalDirection.SOUTH;
        }
        else if (velocity.y > 0)
        {
            facing = CardinalDirection.NORTH;
        }
        animator.SetInteger("FacingDirection", (int)facing);

        rigidBody.velocity = velocity;
    }
}
