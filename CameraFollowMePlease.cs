using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowMePlease : MonoBehaviour
{

    [SerializeField] Transform targetObject;

    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = Camera.main.transform.position - targetObject.position;
    }

    // Update is called once per frame
    void Update()
    {
        Camera.main.transform.position = targetObject.position + offset;
    }
}
