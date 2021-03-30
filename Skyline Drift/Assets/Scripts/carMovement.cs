using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMovement : MonoBehaviour
{

    public GameObject frontLeftWheel;
    public GameObject frontRightWheel;
    public GameObject rearLeftWheel;
    public GameObject rearRightWheel;
    float smooth = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        frontLeftWheel = GameObject.Find("RMCDemo_WheelFrontLeft");
        frontRightWheel = GameObject.Find("RMCDemo_WheelFrontRight");
        rearLeftWheel = GameObject.Find("RMCDemo_WheelRearLeft");
        rearRightWheel = GameObject.Find("RMCDemo_WheelRearRight");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            Quaternion target = transform.rotation;
            target.x++;
            //rearRightWheel.transform.rotation = p;
            rearRightWheel.transform.rotation = target;
            Debug.Log(rearRightWheel.transform.rotation);
        }
    }
}
