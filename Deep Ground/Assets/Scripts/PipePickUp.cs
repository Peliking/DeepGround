using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipePickUp : MonoBehaviour {

    public GameObject PipeWeaponPlayer;
    float maxDistance = 100;
    public float walkingDistance = 5f;
    public Transform player;
    public GameObject target;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Ray ray = new Ray(player.position, player.forward);
        RaycastHit hit;

        float distance = Vector3.Distance(transform.position, player.position);

        if (Input.GetKeyDown(KeyCode.E) && distance < walkingDistance && Physics.Raycast(ray, out hit, 100))
        {
            PipeWeaponPlayer.SetActive(true);
            Destroy(gameObject);
        }
    }
}
