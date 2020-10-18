/* Broc Edson
 * Assignment 5
 * Wins the game when triggered by the end trigger
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinOnTrigger : MonoBehaviour
{
    public GameObject winText;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "EndTrigger")
        {
            winText.SetActive(true);
        }
    }
}
