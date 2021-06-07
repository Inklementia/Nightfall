﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoToNextScene : MonoBehaviour
{
    [SerializeField] private Animator transition;
    [SerializeField] private Animator musicTransition;
    public void NextScene()
    {
        StartCoroutine(TransitionFade());
    }

    IEnumerator TransitionFade()
    {
        transition.SetTrigger("start");
        musicTransition.SetTrigger("fadeOut");

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
