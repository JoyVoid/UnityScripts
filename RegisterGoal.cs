using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegisterGoal : MonoBehaviour
{

   private int goals;

   private void OnTriggerEnter(Collider hit)
   {
       if(hit.tag == "Ball")
       {
           goals++;
           Debug.Log($"Goals: {goals}");
           //UIController.DisplayScore(goals);
           //pass goal to UI controller
       }
   }
} 
