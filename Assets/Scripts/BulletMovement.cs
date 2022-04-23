using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField]
    float speed = 25f;

    Vector2 mousePos;
    Vector3 dir;

    private void Awake()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        dir = new Vector3(mousePos.x, mousePos.y, 0);

        Destroy(gameObject, 5f);
    }

    private void Update()
    {


        transform.position += dir.normalized * speed * Time.deltaTime;
    }
}
