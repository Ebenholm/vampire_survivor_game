using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_shot : MonoBehaviour
{
    public GameObject bullet;
    private float cooldown = 4f;
    private float current_time = 0;
    public int number_of_bullets = 1;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        current_time += Time.deltaTime;
        
    }
	private void FixedUpdate()
	{
		if(current_time >= cooldown) {
            //shoot();
            //current_time = 0;
        }
	}
    void shoot()
    {
        float random_x = Random.value;
        float random_y = Random.value;
        Vector2 rand_pos = new Vector2(random_x, random_y).normalized;
        bullet.transform.position = rand_pos + player_movement.player_movement_instance.rb.position;
        GameObject temp = Instantiate(bullet);

        Destroy(temp,cooldown);

    }
}
