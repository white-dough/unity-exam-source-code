using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q6Debugging : MonoBehaviour
{
    void Start()
    {
        /*--ORIGINAL--
            int playerScore = 0
            playerScore++;
            Debug.Log("Player Score: " + playerSocre);
        */
        //line 1: missing semicolon
        //line 3: misspelled variable name

        int playerScore = 0;
        playerScore++;
        Debug.Log("Player Score: " + playerScore);
    }
}
