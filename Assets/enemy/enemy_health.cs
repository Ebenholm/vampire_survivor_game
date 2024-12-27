using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_health : MonoBehaviour
{

	public int health_points = 50;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		string tag = collision.gameObject.tag;
		switch (tag)
		{
			case "boomerang":
				boomerang player_weapon = collision.gameObject.GetComponent(typeof(boomerang)) as boomerang;
				health_points -= player_weapon.dmg;
				Debug.Log(health_points);
				break;
			case "axe":
				break;
		}
	}
	
}
