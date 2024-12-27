using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_spawner : MonoBehaviour
{
    public int max_num_of_units = 20;
	public int current_num_of_units = 0;
	public float cooldown = 0.3f;
	public float current_cooldown = 0.3f;
    public GameObject enemy;
	private float minX = -5;
	private float maxX = 5;
	private float minY = -5;
	private float maxY = 5;

	
	private void FixedUpdate()
	{
		cooldown_timer();
		if (current_cooldown <= 0 && current_num_of_units < max_num_of_units)
		{
			float x = Random.Range(minX, maxX);
			float y = Random.Range(minY, maxY);

			current_cooldown = cooldown;
			Instantiate(enemy,player_character.character.transform.position + 1.5f * new Vector3(x,y,0),Quaternion.identity);
			current_num_of_units++;
		}
	}

	void cooldown_timer()
	{
		current_cooldown -= 0.02f;
	}
}
