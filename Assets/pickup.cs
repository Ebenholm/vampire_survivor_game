using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
	public string weapon_type = string.Empty;
	public GameObject boomerang_shot;
	public GameObject axe_shot;

	

	private void OnTriggerEnter2D(Collider2D collision)
	{
		
		
		if(collision.gameObject.tag == "Player")
		{
			GameObject weaponobject = new GameObject("weapon");
			switch (weapon_type)
			{
				case "boomerang":
					
					boomerang new_boomerang = weaponobject.AddComponent<boomerang>();
					player_character.character.player_weapons.Add(new_boomerang);
					player_character.character.player_weapons[^1].shot_object = boomerang_shot;
					break;
				case "axe":
					
					axe new_axe = weaponobject.AddComponent<axe>();
					player_character.character.player_weapons.Add(new_axe);
					player_character.character.player_weapons[^1].shot_object = axe_shot;
					break;
			}
			Destroy(gameObject);
		}
				
				
		

	}
	
}
