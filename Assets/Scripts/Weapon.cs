using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : colidable
{
    public int damagePoint = 1;
    public float pushForce = 2.0f;

    private float cooldown = 0.5f;
    private float lastSwing;

    protected override void Start(){
        base.Start();
    }


    protected override void Update(){
        base.Update();

        if(Input.GetKeyDown(KeyCode.Space)){
            if(Time.time - lastSwing > cooldown){
            lastSwing = Time.time;
            Swing();
            }
        }
    }

    protected override void OnCollide(Collider2D coll){
        if(coll.tag == "Fighter")
        {
            if (coll.name == "hero")
                return;

            Damage dmg = new Damage()
            {
                damageAmount = damagePoint,
                origin = transform.position,
                pushForce = pushForce
            };

            coll.SendMessage("ReceiveDamage", dmg);

        }
        
    }

    protected void Swing(){
    }

    
}
