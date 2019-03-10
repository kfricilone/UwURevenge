using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ModeSelectManager : MonoBehaviour
{   
    public static ModeSelectManager instance;
    public int mode = 0;
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void SetMode(int _mode)
    {
        mode = _mode;
        StartGame();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Garage");
    }
}
