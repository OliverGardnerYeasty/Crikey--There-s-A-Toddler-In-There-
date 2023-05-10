using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    GameObject hitbox;
    public float life = 1;

    void Update()
    {
        hitbox = GameObject.FindGameObjectWithTag("Hitbox");
    }

    void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Hitbox")

        {
            collision.GetComponent<AudioSource>().Play();
            Destroy(collision.transform.parent.gameObject,1f);
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Wall") 
        {
            Destroy(gameObject);
        }
    }
}