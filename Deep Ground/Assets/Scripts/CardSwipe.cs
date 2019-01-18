using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSwipe : MonoBehaviour {
    public GameObject CardSwiper;
    float maxDistance = 100;
    public float walkingDistance = 5f;
    public Transform player;
    public GameObject target;
    public GameObject ElectricalDoor;
    public bool DoorMove;
    public float movementSpeed = 1.0f;
    float timeLeft = 10.0f;
    public Material Off;
    public Material On;
    public GameObject Light;

    // Use this for initialization
    void Start () {
        DoorMove = false;
	}
	
	// Update is called once per frame
	void Update () {
        Ray ray = new Ray(player.position, player.forward);
        RaycastHit hit;

        float distance = Vector3.Distance(transform.position, player.position);

        if (Input.GetKey(KeyCode.E) && distance < walkingDistance && Physics.Raycast(ray, out hit, 100) && CardPickUp.CardCollect == true)
        {
            DoorMove = true;
            
        }
        if (DoorMove == true)
        {
            ElectricalDoor.transform.position += Vector3.right * Time.deltaTime * movementSpeed;
            Light.GetComponent<Renderer>().material = On;
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                Destroy(ElectricalDoor);
            }

        }
       
    }
}
