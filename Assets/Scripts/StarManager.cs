﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StarManager : MonoBehaviour {

	public GameObject[] starBases;

	private Dictionary<string, string> baseToGame;

	// Use this for initialization
	void Awake () {
		baseToGame = new Dictionary<string, string>();
		baseToGame.Add("BrainbowStarBase", "Brainbow");
		baseToGame.Add("MemoryMatchStarBase", "MemoryMatch");
		baseToGame.Add("BrainMazeStarBase", "BrainMaze");
		baseToGame.Add("MeetYourFeelingsStarBase", "MonsterEmotions");
		baseToGame.Add("SensesSensationStarBase", "MonsterSenses");

		foreach(GameObject starBase in starBases) {
			int numStars = GameManager.GetInstance().GetNumStars(baseToGame[starBase.name]);

			for(int i = 0; i < numStars; ++i) {
				starBase.transform.GetChild(i).gameObject.SetActive(true);
				starBase.transform.GetChild(i).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 1;
			}
		}

	}

}
