using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextGameManager : MonoBehaviour
{
    public TextMeshProUGUI storyTextMeshPro, HPtextMeshPro, STAtextMeshPro;
    public string storyText;
    public int HPvalue, STAvalue;
    public GameObject UI, MainMenu, Level1Choices, Level2Choices;

    // Start is called before the first frame update
    void Start()
    {
        UI.SetActive(false);
        Level1Choices.SetActive(false);
        Level2Choices.SetActive(false);
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
        storyText = "You woke up from a good dream";
        Level1Choices.SetActive(true);
        MainMenu.SetActive(false);
        UI.SetActive(true);
    }

    public void RollOver()
    {
        storyText = "You can't fall asleep because of a deafened, but still annoying, noise";
        HPvalue-= 3;
        STAvalue-= 5;
        Level1Choices.SetActive(false);
        Level2Choices.SetActive(true);
    }

    public void GoBackToSleep()
    {
        storyText = "You can't fall asleep because of an annoying noise";
        HPvalue-= 9;
        Level1Choices.SetActive(false);
        Level2Choices.SetActive(true);
    }

    public void TurnOffAlarm()
    {
        storyText = "No more annoying noise, but you have responsibilities for today ;-;";
        STAvalue-= 3;
        Level1Choices.SetActive(false);
        Level2Choices.SetActive(true);
    }

    public void BegForTime()
    {
        storyText = "That's not happening, now go to school";
        HPvalue-= 1;
        Level2Choices.SetActive(false);
    }

    public void Accept()
    {
        storyText = "Aight champ, get it over with";
        HPvalue-= 2;
        STAvalue-= 1;
        Level2Choices.SetActive(false);
    }

    public void Cry()
    {
        storyText = "Just let it all out";
        HPvalue += 1;
        STAvalue += 1;
        Level2Choices.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
