using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class axe : weapons
{
	private void Update()
	{
		cooldown_timer();
	}
	public override void shoot()
	{
		cooldown_timer();
		Debug.Log("yxa");
	}
	public override void cooldown_timer()
	{
		current_cooldown -= 0.02f;	
	}
}
