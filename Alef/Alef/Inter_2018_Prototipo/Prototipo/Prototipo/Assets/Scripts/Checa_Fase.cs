﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checa_Fase : MonoBehaviour {

    public static int fase02 = 0;

    public static  int fase03Liberado = 0;

    public static int ilhaLiberado = 0;

    public GameObject camela;

    public GameObject camela02;

    public bool ok;
    public bool ok2;

    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        if (sceneName == "Level_02")
        {
            fase03Liberado = 1;
        }

      else if  (sceneName == "Level_03")
        {
            ilhaLiberado = 1;
        }
    }

    void Update () {

        if(fase03Liberado == 1)
        {
            ok = true;
            camela.SetActive(true);
        }

       else if (fase03Liberado == 0)
        {
            camela.SetActive(false);
        }

        if(ilhaLiberado == 1)
        {
            ok2 = true;
            camela02.SetActive(true);
        }

       else if(ilhaLiberado == 0)
        {
            camela02.SetActive(false);
        }


	}
}
