using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float speed = 5;

    Rigidbody2D playerRigid;

    private void Awake()
    {
        playerRigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }

    public void Move(float x, float y)
    {
        playerRigid.velocity = new Vector2(x, y).normalized * speed;
    }
}
