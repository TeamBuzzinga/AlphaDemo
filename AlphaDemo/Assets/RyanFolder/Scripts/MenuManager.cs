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

    }

    public void creditsButtonPresed()
    {
        cameraAnimator.SetTrigger("Credits");
        menuAnim.SetTrigger("Credits");
    }
}
