using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_movement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float enemy_speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

	private void FixedUpdate()
	{
        Vector2 move_dir = (player_movement.player_movement_instance.rb.position-rb.position).normalized;
        rb.velocity = move_dir * enemy_speed;
	}
}
