using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// This class inherits from the UIelement class and handles the display of the high score
/// </summary>
public class Lives : UIelement
{
    [Tooltip("The text UI to use for display")]
    public TMP_Text displayText = null;
    public GameObject Player;

    /// <summary>
    /// Description:
    /// Changes the high score display
    /// Inputs:
    /// none
    /// Returns:
    /// void (no return)
    /// </summary>
    public void LiveLost()
    {
        if (displayText != null)
        {
            displayText.text = "Lives: " + Player.GetComponent<Health>().currentLives.ToString();
            Debug.Log(Player.GetComponent<Health>().currentLives.ToString());
        }
    }
}