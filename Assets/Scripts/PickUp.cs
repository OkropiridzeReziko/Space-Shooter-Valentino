using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public int healing = 3;
    public int extraLives = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Health>().teamId == 0 && healing != 0)
        {
            collision.gameObject.GetComponent<Health>().currentHealth += healing;
            if (collision.gameObject.GetComponent<Health>().currentHealth > collision.gameObject.GetComponent<Health>().maximumHealth)
            {
                collision.gameObject.GetComponent<Health>().currentHealth = collision.gameObject.GetComponent<Health>().maximumHealth;
            }
        }
        if (collision.gameObject.GetComponent<Health>().teamId == 0 && extraLives > 0)
        {
            collision.gameObject.GetComponent<Health>().currentLives += extraLives;
            if (collision.gameObject.GetComponent<Health>().currentLives > collision.gameObject.GetComponent<Health>().maximumLives)
            {
                collision.gameObject.GetComponent<Health>().currentLives = collision.gameObject.GetComponent<Health>().maximumLives;
            }
        }
        gameObject.SetActive(false);
    }
}