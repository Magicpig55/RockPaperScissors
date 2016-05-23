using UnityEngine;
using System.Collections;
using System;

using HandState = Hand.HandState;

public class GameControl : MonoBehaviour {

	private Hand playerHand;
	private Hand otherHand;
	private Animator inputRPS;

	private bool _showInput;
	public bool ShowInput {
		get {
			return _showInput;
		}
		set {
			if((_showInput = value)) {
				inputRPS.SetTrigger("OnScreen");
			} else {
				inputRPS.SetTrigger("OffScreen");
			}
		}
	}

	// Use this for initialization
	void Start () {
		playerHand = GameObject.Find ("Player_Hand").GetComponent<Hand>();
		otherHand = GameObject.Find ("Other_Hand").GetComponent<Hand>();
		inputRPS = GameObject.Find ("UI_RPS_Input").GetComponent<Animator> ();
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.F)) {
			ShowInput = !ShowInput;
		}
	}

	public void DoInput (HandState state) {
		playerHand.SetState (HandState.Shaking);
		playerHand.SetState (state);
		if (state == HandState.Rock) {

		} else if (state == HandState.Paper) {

		} else if (state == HandState.Scissors) {

		}
	}
	public void DoInput (string state) {
		if(Enum.IsDefined(typeof(HandState), state)) {
			DoInput((HandState)Enum.Parse(typeof(HandState), state));
		}
	}
}
