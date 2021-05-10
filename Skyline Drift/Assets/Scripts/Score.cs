using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Rigidbody carRB;
    public Transform carTF;
    public Text scoreText;
    private int score = 0;
    public Text highScoreText;
    private int highScore = 0;

    private void FixedUpdate() {
        checkDrift();
    }

    private void checkDrift() {
        Vector3 dir = carRB.velocity;
        float CarHeading = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg;

        if (CarHeading < 0) {
            CarHeading = CarHeading * -1;
        }

        float CarDirection = carTF.rotation.eulerAngles.y;

        if (CarDirection > 180) {
            CarDirection = CarDirection - 360;
            CarDirection = CarDirection * -1;
        }

        if (CarDirection - CarHeading > 20 || CarDirection - CarHeading < -20) updateScore();
    }

    private void updateScore() {
        score++;
        if (score > highScore) {
            highScore++;
        }

        scoreText.text = score.ToString();
        highScoreText.text = "Highscore: " + highScore.ToString();
    }

    public void Collided() {
        score = 0;
        scoreText.text = score.ToString();
    }

}
