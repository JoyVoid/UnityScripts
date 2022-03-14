//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using UnityEngine.InputSystem;
//using TMPro;

//public class SoccerBall : MonoBehaviour
//{
//    private int goals1;
//    private int goals2;
//    public TextMeshProUGUI goalText1;
//    public TextMeshProUGUI goalText2;

//   private void OnTriggerEnter(Collider other)
//   {
//       if (other.gameObject.tag == "GoalCollider1")
//       {
//           Debug.Log("GOOOOOOOOAAAAAAAALLLLLLLL!!!!!!!!");
//           goals1++;
//           //SetGoalText(goals1);
//       }

//       if (other.gameObject.tag == "GoalCollider2")
//       {
//           Debug.Log("Goal");
//           goals2++;
//           //SetGoalText(goals2);
//       } 
//       if (other.gameObject.tag == "Ball")
//       {
//           Debug.Log("Ball");
//           //SetGoalText(goals2);
//       } 
//   }

//    private void OnCollisionEnter(Collision other)
//    {
//        if (other.gameObject.tag == "GoalCollider2")
//        {
//            goalText.text = "1";

//        }
//    }
//  /*  void SetGoalText(int goals)
//   {
//        Text goalText = GameObject.Find("Canvas/Goal1").GetComponent<Text>();
//        goalText.text = "changed";

//   } */
//}
