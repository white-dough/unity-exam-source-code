using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class LevelControls : MonoBehaviour
{
    private ObjectPooling objectPool;

    void Start()
    {
        objectPool = FindObjectOfType<ObjectPooling>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }

    private void Fire()
    {
        GameObject bullet = objectPool.GetPooledBullet();

        if (bullet != null)
        {
            // Set the bullet's position and activate it
            bullet.transform.position = transform.position;
            bullet.SetActive(true);
        }
    }
}
