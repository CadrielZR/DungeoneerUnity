using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        sprite = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float dirX = 1;
        rb.velocity = new Vector2(dirX * 1f, 0);

        if (rb.velocity.x != 0f)
        {
            anim.SetBool("npc_walk", true);
            
            if (rb.velocity.x < 0f)
            {
                sprite.flipX = true;
            }
        }
        else
        {
            dirX = -1;
            anim.SetBool("npc_walk", false);
        }
    }
}
