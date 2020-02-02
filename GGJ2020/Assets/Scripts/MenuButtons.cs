﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{

    public void GameStart ()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame ()
    {
        Application.Quit();
    }
}
