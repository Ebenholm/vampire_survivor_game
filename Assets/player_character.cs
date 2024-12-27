using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

public class player_character : MonoBehaviour
{
    public static player_character character;
	public List<weapons> player_weapons = new List<weapons>(); //In the future, I might want to look into dictionarys. I haven't made alot of effort researching this
	//but it seems to have a constant time complexity when searching in a list, asuming the word doesnt show up multiple times in the list which it will not in my game.
	//This might not be true (the time complexity) but at first glance it looks like it would be.
	


	public void Awake()
	{
		character = this;
		//player_weapons.Add(new axe());
		//player_weapons.Add(new boomerang());
	}
	public void FixedUpdate()
	{
		for(int i = 0; i < player_weapons.Count; i++)
		{
			player_weapons[i].shoot();
			
		}
		
	}

	

	
}

