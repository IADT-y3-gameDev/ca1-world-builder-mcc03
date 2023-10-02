using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport2 : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject thePlayer;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("teleportTarget" + teleportTarget);
        Debug.Log("player" + thePlayer );
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other) {
        Debug.Log("Player: " + thePlayer.transform.position);
        Debug.Log("Target: " + teleportTarget.transform.position);
        thePlayer.transform.position = teleportTarget.transform.position;
    }
}
