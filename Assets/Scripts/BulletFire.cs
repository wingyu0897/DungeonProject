using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour
{
    [SerializeField]
    GameObject bulletFire;

    [SerializeField]
<<<<<<< HEAD
    float fireRate = 0.15f;
=======
    float timer = 1f;
>>>>>>> main

    bool canFire = true;

    private void Awake()
    {
        
    }

    IEnumerator Fire()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && canFire)
        {
            canFire = false;

            GameObject bullet = Instantiate(bulletFire, transform.position, transform.rotation);

<<<<<<< HEAD
            yield return new WaitForSeconds(fireRate);
=======
            yield return new WaitForSeconds(0.3f);
>>>>>>> main

            canFire = true;
        }

    }

    private void Update()
    {
        StartCoroutine("Fire");
    }
}
