using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodBreak : MonoBehaviour {
    public GameObject Wood;
    float maxDistance = 100;
    public float walkingDistance = 5f;
    public Transform player;
    public GameObject target;
    public GameObject AxeWeapon;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Ray ray = new Ray(player.position, player.forward);
        RaycastHit hit;

        float distance = Vector3.Distance(transform.position, player.position);

        if (Input.GetMouseButtonDown(0) && distance < walkingDistance && Physics.Raycast(ray, out hit, 100) && !AxeWeapon)
        {
            
            Destroy(gameObject);
        }
    }
}
