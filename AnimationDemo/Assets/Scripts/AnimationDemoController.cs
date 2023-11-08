using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimationDemoController : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rb;

    float xvel = 0;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(xvel * 5f, rb.velocity.y);
    }


    public void OnMove(InputValue val)
    {
        Vector2 input = val.Get<Vector2>();

        if (input.x != 0)
        {
            anim.SetBool("walking", true);
        } else
        {
            anim.SetBool("walking", false);
        }

        if (input.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        } else
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

    // Simple movement, not realistic or very scalable
        xvel = input.x;
    }
}
