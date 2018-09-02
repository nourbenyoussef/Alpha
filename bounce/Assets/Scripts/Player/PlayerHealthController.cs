using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthController : MonoBehaviour {


    public Slider healthBar;
    public float MaximumHealth;
    public float CurrentHealth
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
            healthBar.value = health;
        }
    }


    float health; 
    // Use this for initialization
	void Start () {
        health = MaximumHealth;
        healthBar.maxValue = MaximumHealth;
        healthBar.value = health;
    }
	
}
