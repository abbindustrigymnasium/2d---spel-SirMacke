using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarEffects : MonoBehaviour
{
    public TrailRenderer[] tireMarks;
    private bool tireMarksFlag;
    public Rigidbody carRB;

    private void Start() {

    }

    private void FixedUpdate() {
        checkDrift();
    }

    private void checkDrift() {
        //if () startEmitter();
        //else stopEmitter();

        Vector3 dir = carRB.velocity;
        float CarHeading = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg;

        //transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);


        if (CarHeading < 0) {
            CarHeading = CarHeading * -1;
        }

        float CarDirection = transform.rotation.eulerAngles.y;

        if (CarDirection > 180) {
            CarDirection = CarDirection - 360;
            CarDirection = CarDirection * -1;
        }

        //Debug.Log(CarDirection - CarHeading);

        if (CarDirection - CarHeading > 20 || CarDirection - CarHeading < -20 || Input.GetKey("space")) startEmitter();
        else stopEmitter();

        //Debug.Log(Math.cos(carRB.velocity.x / carRB.velocity.z));
    }

    private void startEmitter() {
        if (tireMarksFlag) return;
        foreach (TrailRenderer T in tireMarks) {
            T.emitting = true;
        }

        tireMarksFlag = true;
    }

    private void stopEmitter() {
        if (!tireMarksFlag) return;
        foreach (TrailRenderer T in tireMarks) {
            T.emitting = false;
        }

        tireMarksFlag = false;
    }
}
