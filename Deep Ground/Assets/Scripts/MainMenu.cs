﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour {

    public Animator anim;
    public void PlayGame()
    {
        anim.SetTrigger("FadeOut");       
            
    }

    public void QuitGame()
    {
        Application.Quit();
    }
   


       
    
}
