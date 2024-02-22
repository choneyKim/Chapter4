using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Managers : MonoBehaviour
{
    static Managers s_instance;
    static Managers _instance { get { Init(); return s_instance; } }
    GameManager _gameManager = new GameManager();
    public static GameManager GameManager { get { return _instance._gameManager; } }

    private void Start()
    {
        Init();
    }
    static void Init()
    {
        if (s_instance == null)
        {
            GameObject manager = GameObject.Find("@Managers");
            if (manager == null)
            {
                manager = new GameObject("@Managers");
                s_instance = manager.AddComponent<Managers>();
            }
            DontDestroyOnLoad(s_instance);
            s_instance = manager.GetComponent<Managers>();

        }
    }

}
