using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCreator : MonoBehaviour {
    public GameObject cube;

    void Start() {
        for (int i = 0; i < 1000; i++) {
            createCube();
        }
    }

    void createCube() {
        float xValue = Random.Range(-500f, 500f);
        float zValue = Random.Range(-500f, 500f);
        Instantiate(cube, new Vector3(xValue, 0, zValue), Quaternion.identity);
    }
}
