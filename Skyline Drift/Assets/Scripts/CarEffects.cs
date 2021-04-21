using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarEffects : MonoBehaviour
{
    public TrailRenderer[] tireMarks;
    private bool tireMarksFlag;

    private void Start() {

    }

    private void FixedUpdate() {
        checkDrift();
    }

    private void checkDrift() {
        if (Input.GetKey("space")) startEmitter();
        else stopEmitter();
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
