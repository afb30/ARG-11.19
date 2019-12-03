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
TextBox.GetComponent<Text>().text = "That doesn't seem like the best idea.";
ChoiceMade = 1;
}

public void ChoiceOption2 () {
TextBox.GetComponent<Text>().text = "Exactly! You handled this well.";
ChoiceMade = 2;
}

    void Update()
    {

    }
}
