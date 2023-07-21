using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class TextGameManager : MonoBehaviour
{
    public TextMeshProUGUI storyTextMeshPro, HPtextMeshPro, STAtextMeshPro;
    public string storyText;
    public int HPvalue, STAvalue;
    public GameObject UI, MainMenu, RetryScreen, Level1Choices, Level2Choices, Level3Choices, Page5Choices;

    // Start is called before the first frame update
    void Start()
    {
        UI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        storyTextMeshPro.text = storyText;
        HPtextMeshPro.text = HPvalue.ToString();
        STAtextMeshPro.text = STAvalue.ToString();
    }

    public void StartGame()
    {
        storyText = "\"I'm pretty bored in this room\" you think to yourself";
        Level1Choices.SetActive(true);
        MainMenu.SetActive(false);
        UI.SetActive(true);
    }

    //Level 1
    public void RollOver() //Look around
    {
        storyText = "A key! Might be useful for that door there";
        Level1Choices.SetActive(false);
        Level2Choices.SetActive(false);
        Level3Choices.SetActive(true);
    }

    public void TurnOffAlarm() //Open the door
    {
        storyText = "The door's locked. \"I think I can bust it open!\"";
        Level1Choices.SetActive(false);
        Level2Choices.SetActive(true);
        STAvalue -= 1;
    }

    //Level 2
    public void GoForIt() //Death
    {
        storyText = "You, person, are one exciting individual :D";
        Level2Choices.SetActive(false);
        RetryScreen.SetActive(true);
        HPvalue = 0;
        STAvalue = 0;
    }

    public void searchRoom()
    {
        storyText = "An explosive! Unsure about \nwhat it is... wanna take it?";
        Level3Choices.SetActive(false);
        Page5Choices.SetActive(true);
        STAvalue -= 1;
    }

    public void openDoor2()
    {
        storyText = "Hey, you, you're finally awake. You were tring to cross the border, right?";
        Level3Choices.SetActive(false);
        RetryScreen.SetActive(true);
        HPvalue = 10;
        STAvalue = 10;
    }

    public void bombYes()
    {
        storyText = "KABOOM";
        Page5Choices.SetActive(false);
        RetryScreen.SetActive(true);
        HPvalue = 0;
        STAvalue = 0;
    }

    public void bombNo()
    {
        storyText = "A wise choice... hey what's that ticking sou- *KABOOM*";
        Page5Choices.SetActive(false);
        RetryScreen.SetActive(true);
        HPvalue = 0;
        STAvalue = 0;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
