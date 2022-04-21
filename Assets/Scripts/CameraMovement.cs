using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    GameObject player;

    private void Awake()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -1);
    }
}
