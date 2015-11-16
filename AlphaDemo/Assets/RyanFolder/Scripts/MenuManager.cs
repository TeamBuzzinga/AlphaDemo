using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour {
    public Animator cameraAnimator;
    Animator menuAnim;

    void Start()
    {
        menuAnim = GetComponent<Animator>();
    }

    void Upate()
    {

    }

    public void optionsPressed()
    {
        cameraAnimator.SetTrigger("Options");
        menuAnim.SetTrigger("Options");
    }

    public void playButtonPressed()
    {
        Application.LoadLevel("Office v1.3");
    }

    public void creditsButtonPresed()
    {
        cameraAnimator.SetTrigger("Credits");
        menuAnim.SetTrigger("Credits");
    }

    public void toIntroScreen()
    {
        cameraAnimator.SetTrigger("Intro");
        menuAnim.SetTrigger("Intro");
    }
}
