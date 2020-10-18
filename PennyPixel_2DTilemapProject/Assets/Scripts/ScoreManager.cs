/* Broc Edson
 * Assignment 5
 * Manages the score
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
    }

    public void AddScore()
    {
        score++;
    }
}
