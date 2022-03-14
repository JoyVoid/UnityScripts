using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    private int goals;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Debug.Log("GOOOOAAAALLL!!!");
            goals++;
            //SetGoalText(goals);
        }
        //if (other.gameObject.tag == "GoalColider2")
    }

   /*  private void SetGoalText(int goals)
    {
        Text goalText = GameObject.Find("Canvas/Goal1").GetComponent<Text>();
        goalText.text = "1";
    } */
}
