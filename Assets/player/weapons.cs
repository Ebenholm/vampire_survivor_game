using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class weapons : MonoBehaviour
{
    public int dmg = 0;
    public int amount = 1;
    public float cooldown = 0;
    public float current_cooldown = 0;
    public int num_of_hits = 5;
    public int current_num_of_hits = 5;
	public GameObject shot_object;

	public abstract void shoot();
    public abstract void cooldown_timer();
}



