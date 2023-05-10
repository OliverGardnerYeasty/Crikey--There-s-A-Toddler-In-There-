using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform bulletspawnpoint;
    public GameObject bulletprefab;
    public float bulletspeed = 10;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            var bullet = Instantiate(bulletprefab, bulletspawnpoint.position, bulletspawnpoint.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = bulletspawnpoint.up * bulletspeed;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            var bullet = Instantiate(bulletprefab, bulletspawnpoint.position, bulletspawnpoint.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = bulletspawnpoint.right * bulletspeed;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            var bullet = Instantiate(bulletprefab, bulletspawnpoint.position, bulletspawnpoint.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = -bulletspawnpoint.right * bulletspeed;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            var bullet = Instantiate(bulletprefab, bulletspawnpoint.position, bulletspawnpoint.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = -bulletspawnpoint.up * bulletspeed;
        }
    }
}

