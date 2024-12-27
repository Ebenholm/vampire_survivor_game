using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boomerang : weapons
{

	//public GameObject boomerang_shot;
	private void Awake()
	{
		cooldown = 3;
		current_cooldown = cooldown;
		dmg = 3;
		amount = 1;
		num_of_hits = 1;
		current_num_of_hits = num_of_hits;

	}


	public override void shoot()
	{
		cooldown_timer();
		if(current_cooldown <= 0)
		{
			current_num_of_hits = num_of_hits;
			current_cooldown = cooldown;
			for(int i = 0; i < amount; i++)
			{
				GameObject shot = Instantiate(shot_object, player_character.character.transform);
				Destroy(shot, 2.5f);
			}
			
		}
		//Debug.Log("boomerang");
		//GameObject temp = Instantiate(boomerang_shot);
		//Destroy(temp, 3);
	}

	public override void cooldown_timer()
	{
		current_cooldown -= 0.02f;
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		enemy_health hit = collision.GetComponent<enemy_health>();
		Debug.Log(current_num_of_hits);
		if (hit != null && current_num_of_hits > 0)
		{
			current_num_of_hits -= 1;

			Debug.Log("amount of hits left" + current_num_of_hits);
			hit.health_points -= dmg;
			Debug.Log("Number of health points on current enemy" + hit.health_points);
			if(hit.health_points <= 0)
			{
				Destroy(collision.gameObject);
				Debug.Log("dead");
			}
			if(current_num_of_hits <= 0) { /*should destroy object that we shoot*/}
		}
	}
}
