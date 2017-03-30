﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Options : MonoBehaviour {

    public Button backButton;

    void Start()
    {
        backButton.onClick.AddListener(onBackButtonEvent);
    }

    void onBackButtonEvent()
    {
        SceneManager.LoadScene("main-menu");
    }

    void Update()
    {

    }
}
