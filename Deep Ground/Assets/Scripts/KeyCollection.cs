using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollection : MonoBehaviour {
    public GameObject VaultDoor;
    public GameObject VaultDoorHandle;
    public GameObject VaultDoorPipe;
    public GameObject VaultDoorSwitch;
    public GameObject VaultDoorSwitch2;
    public GameObject KeyPiece1;
    public GameObject KeyPiece2;
    public GameObject KeyPiece3;
    public GameObject KeyPiece4;
    public GameObject KeyPiece5;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!KeyPiece1 && !KeyPiece2 && !KeyPiece3 && !KeyPiece4 && !KeyPiece5)
        {
            VaultDoor.SetActive(false);
            VaultDoorHandle.SetActive(false);
            VaultDoorPipe.SetActive(false);
            VaultDoorSwitch.SetActive(false);
            VaultDoorSwitch2.SetActive(false);
        }
	}
}
