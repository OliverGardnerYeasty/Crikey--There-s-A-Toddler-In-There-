using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player;
    private float changeX = 0f;
    private float changeY = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 playerPos = player.gameObject.GetComponent<Transform>().position;
        Vector3 camPos = this.gameObject.GetComponent<Transform>().position;

        changeX = playerPos.x - camPos.x;
        changeY = playerPos.y - camPos.y;

        if (changeX > 5)
        {
            camPos.x += 10;
        }
        if (changeX < -5)
        {
            camPos.x -= 10;
        }
        if (changeY > 5)
        {
            camPos.y += 10;
        }
        if (changeY < -5)
        {
            camPos.y -= 10;
        }
        this.gameObject.GetComponent<Transform>().position = camPos;
    }
}
