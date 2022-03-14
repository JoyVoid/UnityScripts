using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTestScript : MonoBehaviour
{
    public event EventHandler<EventArgs> BallEnteredTrigger;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter from TriggerTest cube. Other object: " + other);

        if(other.gameObject.name == "PrimaryBall")
        {
            //EventHandler<EventArgs> temp = BallEnteredTrigger;
            //if(temp != null)
            //{
            //    temp(this, EventArgs.Empty);
            //}

            BallEnteredTrigger?.Invoke(this, EventArgs.Empty);
        }

    }
}
