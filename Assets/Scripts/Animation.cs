using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    Animator animator;
    public Sprite Up;
    public Sprite Down;
    public Sprite Right;
    public Sprite Left;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 move = transform.position;

        if (Input.GetKey(KeyCode.W))
        {
            animator.SetInteger("AnimState", 3);
            GetComponent<SpriteRenderer>().sprite = Up;
            move = new Vector2(0, speed * Time.deltaTime);

            transform.position += move;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            animator.SetInteger("AnimState", 1);
            GetComponent<SpriteRenderer>().sprite = Left;
            move = new Vector2(speed * Time.deltaTime, 0);

            transform.position -= move;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            animator.SetInteger("AnimState", 2);
            GetComponent<SpriteRenderer>().sprite = Right;
            move = new Vector2(speed * Time.deltaTime, 0);

            transform.position += move;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            animator.SetInteger("AnimState", 4);
            GetComponent<SpriteRenderer>().sprite = Down;
            move = new Vector2(0, speed * Time.deltaTime);

            transform.position -= move;
        }
        else
        {
            animator.SetInteger("AnimState", 0);
        }
    }
}
