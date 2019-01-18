using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardPickUp : MonoBehaviour {
    public GameObject Card;
    float maxDistance = 100;
    public float walkingDistance = 5f;
    public Transform player;
    public GameObject target;
    public static bool CardCollect;
    // Use this for initialization
    void Start () {
        CardCollect = false;
	}
	
	// Update is called once per frame
	void Update () {
        Ray ray = new Ray(player.position, player.forward);
        RaycastHit hit;

        float distance = Vector3.Distance(transform.position, player.position);

        if (Input.GetKeyDown(KeyCode.E) && distance < walkingDistance && Physics.Raycast(ray, out hit, 100))
        {
            Destroy(gameObject);
            CardCollect = true;
        }
        if (CardCollect == true)
        {
            Debug.Log("Working");
        }
    }
}
