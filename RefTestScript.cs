using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefTestScript : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject primaryBallGO;
    Transform primaryBallTxfrm;
    Rigidbody primaryBallRB;

    void Start()
    {

        primaryBallGO = GameObject.Find("/PrimaryBall");
        primaryBallTxfrm = primaryBallGO.transform;

        primaryBallRB = primaryBallGO.GetComponent<Rigidbody>();

        primaryBallRB.useGravity = false;
        primaryBallRB.Sleep();


        TriggerTestScript testScript = GameObject.Find("/TriggerTest").GetComponent<TriggerTestScript>();
        testScript.BallEnteredTrigger += TestScript_BallEnteredTrigger;



        Debug.Log("primaryBallGO: " + primaryBallGO);
    }

    private void TestScript_BallEnteredTrigger(object sender, System.EventArgs e)
    {
        Debug.Log("Gooooaaall!");
    }



    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            primaryBallRB.useGravity = true;
        }
    }
}
