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
    public TMP_Text displayTextLives = null;
    public TMP_Text displayTextHealth = null;
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
        if (displayTextLives != null)
        {
            displayTextLives.text = "Lives: " + Player.GetComponent<Health>().currentLives.ToString();
            Debug.Log(Player.GetComponent<Health>().currentLives.ToString());
        }
    }
    public void HealthDisplay()
    {
        if (displayTextHealth != null)
        {
            displayTextHealth.text = "Health: " + Player.GetComponent<Health>().currentHealth.ToString();
            Debug.Log(Player.GetComponent<Health>().currentHealth.ToString());
        }
    }
}