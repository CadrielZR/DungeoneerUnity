using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : colidable
{
    protected override void OnCollide (Collider2D coll){
        Debug.Log("Yo");
    }
}
