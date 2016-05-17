using UnityEngine;
using System.Collections;
using System;

using HandState = Hand.HandState;

public class GameControl : MonoBehaviour {

	private Hand playerHand;
	private Hand otherHand;

	// Use this for initialization
	void Start () {
		playerHand = GameObject.Find ("Player_Hand").GetComponent<Hand>();
		otherHand = GameObject.Find ("Other_Hand").GetComponent<Hand>();
	}

	public void DoInput (HandState state) {
		playerHand.SetState (HandState.Shaking);
		playerHand.SetState(state);
		if (state == HandState.Rock) {

		} else if (state == HandState.Paper) {

		} else if (state == HandState.Scissors) {

		}
	}
	public void DoInput (string state) {
		DoInput ((HandState)Enum.Parse(HandState, state));
	}
}
