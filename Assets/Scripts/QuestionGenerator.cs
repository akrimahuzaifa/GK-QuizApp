using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerator : MonoBehaviour
{
    public static string actualAnswer;
    public static bool displayingQuestion = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!displayingQuestion)
        {
            displayingQuestion = true;
            QuestionDisplay.newQuestion = "How much wood could a wood chuck chuck if a wood chuck could chuck wood?";
            QuestionDisplay.newA = "A. Lots and Lots";
            QuestionDisplay.newB = "B. None";
            QuestionDisplay.newC = "C. Hardly any";
            QuestionDisplay.newD = "D. Six only";
            actualAnswer = "A";
        }
    }
}
