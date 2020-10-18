/* Broc Edson
 * Assignment 5
 * Ends the game when the player enters the end trigger
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameObject endText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "EndTrigger")
        {
            endText.SetActive(true);
        }
    }
}
