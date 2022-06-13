using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAvoidance : MonoBehaviour
{
    public Transform player;

    [Range(0.5f, 5f)]
    public float moveSpeed = 0.5f;

    private Rigidbody2D rb;
    private Vector2 movement;


    private void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 oppositeDirection = (player.position - transform.position) * -1;

        oppositeDirection.Normalize();

        movement = oppositeDirection;
    }


    private void FixedUpdate()
    {
        MoveCharacter(movement);
    }


    void MoveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2) transform.position + (direction * moveSpeed * Time.deltaTime));
    }
}
