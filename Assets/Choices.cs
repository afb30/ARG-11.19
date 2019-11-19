using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choices : MonoBehaviour
{
public GameObject TextBox;
public GameObject Choice01;
public GameObject Choice02;
public int ChoiceMade;

public void ChoiceOption1 () {
TextBox.GetComponent<Text>().text = "You died.";
ChoiceMade = 1;
}

public void ChoiceOption2 () {
TextBox.GetComponent<Text>().text = "You survived this scenario! But will you survive the next one?";
ChoiceMade = 2;
}

    void Update()
    {
        if (ChoiceMade >= 1)
Choice01.SetActive (false);
Choice02.SetActive (false);
    }
}
