using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stamina : MonoBehaviour {

    public Slider staminaBar;

    public float maxStamina;

    public float staminaLoss;
	// Use this for initialization
	void Start () {
        staminaBar.maxValue = maxStamina;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            maxStamina -= staminaLoss * Time.deltaTime;
            staminaBar.value = maxStamina;
            
            }
        if (maxStamina <= 1 && !Input.GetKey(KeyCode.LeftShift))
        {
            maxStamina += 0.1f;
            if (maxStamina <= 0)
            {
                maxStamina += 0.05f;
            }
        }


       
	}
}
