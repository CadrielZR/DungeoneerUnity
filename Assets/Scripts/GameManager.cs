using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake(){
        if(GameManager.instance != null){
            Destroy(gameObject);
            return;
        }

        PlayerPrefs.DeleteAll();

        instance = this;
        SceneManager.sceneLoaded += LoadState;
        DontDestroyOnLoad(gameObject);
    }

    //Resourses
    public List<Sprite> playerSprites;
    public List<Sprite> enemySprites;
    public List<int> keyAmounts;

    //References
    public player player;
    public FloatingTextManager floatingTextManager;

    //Floating Text
    public void ShowText(string msg, int fontSize, Color color, Vector3 position, Vector3 motion, float duration){
        floatingTextManager.Show(msg,fontSize,color,position,motion,duration);

    }

    //Logic
    public int keys;

    //SaveState
    /*
    *INT keys
    *

    */
    public void SaveState(){
        string s = "";

        s+= keys.ToString() + "|";
        s+= "0";

        PlayerPrefs.SetString("SaveState", s);
    }

    public void LoadState(Scene scene, LoadSceneMode mode){

        if(!PlayerPrefs.HasKey("SaveState"))
            return;

        string[] data = PlayerPrefs.GetString("SaveState").Split('|');
        
        keys = int.Parse(data[0]);
        //Change weapon level
    }
}
