using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Colectable
{
    public Sprite emptyChest;
    public int keyAmount = 1;


    protected override void OnCollect(){
        if(!collected){
            collected = true;
            GetComponent<SpriteRenderer>().sprite = emptyChest;
            GameManager.instance.ShowText("+" + keyAmount + " key!", 30, Color.yellow, transform.position, Vector3.up * 25, 1.5f);
        }

    }
}
