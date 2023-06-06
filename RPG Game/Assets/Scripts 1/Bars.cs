using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bars : MonoBehaviour
{
	// Health
	public Slider Health_Slider;

	// Stamina
	public Slider Stamina_Slider;

	

	public void SetMaxHealth(int health)
	{
		Health_Slider.maxValue = health;
		Health_Slider.value = health;

		
	}

	public void SetHealth(int health)
	{
		Health_Slider.value = health;

		
	}

	public void SetMaxStamina(int stamina)
    {
		Stamina_Slider.maxValue = stamina;
		Stamina_Slider.value = stamina;
    }

	public void setStamina(int stamina)
    {
		Stamina_Slider.value = stamina;
    }

}