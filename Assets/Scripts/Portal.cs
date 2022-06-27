using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : colidable
{
    public string[] sceneNames;

    protected override void OnCollide(Collider2D coll){
        if(coll.name == "hero"){
           GameManager.instance.SaveState();

           string sceneName = sceneNames[1];
           UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName); 
        }
    }

}
