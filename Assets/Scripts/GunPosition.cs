using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPosition : MonoBehaviour
{
    GameObject player;

    Vector2 mousePos;

    float zAngle;

    private void Awake()
    {
        player = GameObject.Find("Player");
    }

    private void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - player.transform.position;
        zAngle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;

        transform.position = player.transform.position + new Vector3(0.2f, -0.1f, 0);
        transform.rotation = Quaternion.Euler(0, 0, zAngle);
        if (zAngle > 90 || zAngle < -90)
        {
            transform.position = player.transform.position + new Vector3(-0.2f, -0.1f, 0);
        }
    }
}
