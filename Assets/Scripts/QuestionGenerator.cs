using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerator : MonoBehaviour
{
    public static string actualAnswer;
    public static bool displayingQuestion = false;
    int questionNumber;
    public GameObject visual001;

    // Update is called once per frame
    void Update()
    {
        if (!displayingQuestion)
        {
            displayingQuestion = true;
            questionNumber = Random.Range(1, 7);
            //Debug.Log(questionNumber);

            if (questionNumber == 1)
            {
                QuestionDisplay.newQuestion = "How much wood could a wood chuck chuck if a wood chuck could chuck wood?";
                QuestionDisplay.newA = "A. Lots and Lots";
                QuestionDisplay.newB = "B. None";
                QuestionDisplay.newC = "C. Hardly any";
                QuestionDisplay.newD = "D. Six only";
                actualAnswer = "A";
            }
            if (questionNumber == 2)
            {
                QuestionDisplay.newQuestion = "Who invented the bulb?";
                QuestionDisplay.newA = "A. Enistein";
                QuestionDisplay.newB = "B. Newton";
                QuestionDisplay.newC = "C. Edison";
                QuestionDisplay.newD = "D. William Wordsworth";
                actualAnswer = "C";
            }
            if (questionNumber == 3)
            {
                QuestionDisplay.newQuestion = "Where is Japan?";
                QuestionDisplay.newA = "A. Africa";
                QuestionDisplay.newB = "B. Asia";
                QuestionDisplay.newC = "C. Europe";
                QuestionDisplay.newD = "D. Antartica";
                actualAnswer = "B";
            }
            if (questionNumber == 4)
            {
                QuestionDisplay.newQuestion = "How old is the world?";
                QuestionDisplay.newA = "A. 1400 years";
                QuestionDisplay.newB = "B. None";
                QuestionDisplay.newC = "C. 3000 years";
                QuestionDisplay.newD = "D. Billions of years";
                actualAnswer = "D";
            }
            if (questionNumber == 5)
            {
                QuestionDisplay.newQuestion = "Where is Eiffel Tower?";
                QuestionDisplay.newA = "A. London";
                QuestionDisplay.newB = "B. Paris";
                QuestionDisplay.newC = "C. NewYork";
                QuestionDisplay.newD = "D. New Jersey";
                actualAnswer = "B";
            }            
            if (questionNumber == 6)
            {
                QuestionDisplay.newQuestion = "Which is the capital City of Saudi Arabia?";
                QuestionDisplay.newA = "A. Jaddah";
                QuestionDisplay.newB = "B. Madina";
                QuestionDisplay.newC = "C. Makkah";
                QuestionDisplay.newD = "D. Riyadh";
                visual001.SetActive(true);
                actualAnswer = "D";
            }
            //^^^^^^^^^^^^^^All questions go above this line^^^^^^^^^^^^^^

            QuestionDisplay.update = false;

        }
    }
}
