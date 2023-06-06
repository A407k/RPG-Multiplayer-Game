using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Bars : MonoBehaviour
{
    public GameObject Menu;
    public int P = 1;

    // Health Bar
    public int maxHealth = 100;
    public int currentHealth;

    public Bars healthBar;

    // Stamina Bar
    public int maxStamina = 100;
    public int currentStamina;

    public Bars staminaBar;

    void Start()
    {
        // Health
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        // Stamina
        currentStamina = maxStamina;
        staminaBar.SetMaxStamina(maxStamina);

    }

    // Update is called once per frame

    void Update()
    {
       

        // Pause the Game

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (P == 1)
            {

                P = 0;
                Menu.SetActive(true);
            
            }

           else if(P == 0)
            { 
                P = 1;
                Menu.SetActive(false);
            }

        }

       

    }

   

}
