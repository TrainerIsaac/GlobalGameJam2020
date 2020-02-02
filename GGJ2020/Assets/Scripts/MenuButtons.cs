﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{

    [SerializeField] int levelID;

    public void GameStart ()
    {
        SceneManager.LoadScene(levelID);
    }

    public void ExitGame ()
    {
        Application.Quit();
    }
}
