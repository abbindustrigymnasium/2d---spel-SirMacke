using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCollision : MonoBehaviour
{
    public void OnCollisionEnter(Collision collisionInfo) {

        if (collisionInfo.collider.tag == "Obstacle") {

            FindObjectOfType<Score>().Collided();

        }
    }
}
