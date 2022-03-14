using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldBall : MonoBehaviour
{
    [SerializeField] float offset;
    //movement speed in units per second
    private float movementSpeed = 5f;
    
    private Vector3 currentPosition;

    private void OnTriggerStay(Collider hitObject)
    {
        if(hitObject.tag == "Ball")
        {
            //Northeast
            //currentPosition = transform.position + new Vector3(movementSpeed*Time.deltaTime , offset*movementSpeed*Time.deltaTime , movementSpeed*Time.deltaTime);
            //directly above
            //currentPosition = transform.position + new Vector3(0f , offset*movementSpeed*Time.deltaTime , movementSpeed*Time.deltaTime);
            //directly above
            //currentPosition = transform.position + new Vector3(movementSpeed*Time.deltaTime , offset*movementSpeed*Time.deltaTime , movementSpeed*Time.deltaTime);
            //NorthEast
            //currentPosition = transform.position + new Vector3(offset*movementSpeed*Time.deltaTime , movementSpeed*Time.deltaTime , movementSpeed*Time.deltaTime);
            //
            //currentPosition = transform.position + new Vector3(movementSpeed*Time.deltaTime , movementSpeed*Time.deltaTime , offset*movementSpeed*Time.deltaTime);
            Debug.Log("current position: " + currentPosition);
            Debug.Log("transform: "+ transform.position);
    
            hitObject.transform.position = currentPosition;
        }

    }
}
