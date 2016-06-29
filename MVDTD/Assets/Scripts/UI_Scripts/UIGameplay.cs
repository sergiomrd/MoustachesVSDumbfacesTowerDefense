﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIGameplay : MonoBehaviour {

	public Text moneyText;
    public Text livesText;

	void Awake()
	{

	}


	public void UpdateMoney()
	{
		moneyText.text = "Money: " + GameManagerController.Instance.Money.ToString() + " $";
	}

    public void UpdateLives()
    {
        livesText.text = "Lives: " + GameManagerController.Instance.Lives.ToString();
    }
}
