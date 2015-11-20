using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuManager : MonoBehaviour {
    public Animator cameraAnimator;
    public Animator creditsAnimator;

    public float timeDelay;//The amount of time before switching to another option

    float lastHInput;
    float lastVInput;
    float verticalTimer;
    float horizontalTimer;
    Vector2 currentButtonsPosition;
    Animator menuAnim;

    Button[,] introButtons = new Button[4, 1];

    enum State { Intro, Options, Credits };
    State currentState;

    void Start()
    {
        currentButtonsPosition = Vector2.zero;
        currentState = State.Intro;
        menuAnim = GetComponent<Animator>();
    }

    void setUpIntroButtons()
    {

    }

    void shiftCursor(int horizontalShift, int verticalShift)
    {
        Button[,] buttons = retrieveCurrentArray();
        currentButtonsPosition += new Vector2(horizontalShift, verticalShift);
        if (currentButtonsPosition.x >= buttons.Length)
        {
            currentButtonsPosition += Vector2.left;
        }
        
    }

    Button[,] retrieveCurrentArray()
    {
        switch(currentState)
        {
            case State.Intro:
                return introButtons;
        }
        return null;
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
        creditsAnimator.SetTrigger("Credits");
    }

    public void toIntroScreen()
    {
        cameraAnimator.SetTrigger("Intro");
        menuAnim.SetTrigger("Intro");
        creditsAnimator.SetTrigger("Intro");
    }
}
