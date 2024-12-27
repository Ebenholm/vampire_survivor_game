using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_movement : MonoBehaviour
{
    private Vector2 start_pos = Vector2.zero;
    private Rigidbody2D rb;
    private float time = 0;
	public int damage = 5;
    public int number_of_possible_hits = 1;
	// Start is called before the first frame update
	void Start()
    {
        start_pos = player_movement.player_movement_instance.rb.position;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        rb.position = start_pos + new Vector2(Mathf.Cos(time*3)*time, Mathf.Sin(time*3)*time);
        time += Time.deltaTime*1.5f;
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
        enemy_health hit = collision.GetComponent<enemy_health>();
        if (hit != null)
        {
            Debug.Log("hit");
            hit.health_points -= damage;
            if(hit.health_points <= 0)
            {
                Destroy(collision.gameObject);
                Debug.Log("dead");
            }
           
        }
	}
}
