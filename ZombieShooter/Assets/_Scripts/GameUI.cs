﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUI : MonoBehaviour {

    private int health;
    private int score;
    private int stamina;
    //private string gameInfo = "";

    public GameObject healthSlider;
    public GameObject staminaSlider;
    public GameObject scoreText;

    //private Rect boxRect = new Rect(10, 10, 300, 50);

    private void OnEnable()
    {
        PlayerBehaviour.OnUpdateHealth += HandleonUpdateHealth;
        AddScore.OnSendScore += HandleonSendScore;
    }

    private void OnDisable()
    {
        PlayerBehaviour.OnUpdateHealth -= HandleonUpdateHealth;
        AddScore.OnSendScore -= HandleonSendScore;
    }

    void Start ()
    {
        UpdateUI();	
	}

    void HandleonUpdateHealth(int newHealth)
    {
        health = newHealth;
        UpdateUI();
    }

    void HandleonSendScore(int theScore)
    {
        score += theScore;
        UpdateUI();
    }
	
	void UpdateUI()
    {
		//gameInfo = "Score: " + score.ToString() + "\nHealth: " + health.ToString();
        scoreText.GetComponent<UnityEngine.UI.Text>().text = score.ToString();
	}

    //void OnGUI()
    //{
    //    GUI.Box(boxRect, gameInfo);
    //}
}