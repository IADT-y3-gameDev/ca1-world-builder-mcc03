using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapScript : MonoBehaviour
{
    public Transform player;

    void LateUpdate () {

        // this makes the minimap camera follow the player
        Vector3 newPosition = player.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;

        // this makes the minimap camera rotate with the player
        // transform.rotation = Quaternion.Euler(90f, player.eulerAngles.y, 0f);
    }

}
