using UnityEngine;
using System.Collections;

public class Hand : MonoBehaviour {

	Animator animator;
	private HandState _handstate;
	public HandState CurrentHandState {
		get {
			return _handstate;
		}
	}

	public enum HandState {
		Shaking,
		Rock,
		Paper,
		Scissors
	}
	
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}

	public void SetState(HandState state) {
		ClearAllAnim();
		if(CurrentHandState != HandState.Shaking)
			animator.SetTrigger("Reset");
		_handstate = state;
		switch (state) {
		case HandState.Rock: {
			animator.SetBool("Rock", true);
			animator.SetTrigger("Shoot");
			break;
		}
		case HandState.Paper: {
			animator.SetBool("Paper", true);
			animator.SetTrigger("Shoot");
			break;
		}
		case HandState.Scissors: {
			animator.SetBool("Scissors", true);
			animator.SetTrigger("Shoot");
			break;
		}
		default: {

			break;
		}
		}
	}
	private void ClearAllAnim() {
		animator.SetBool("Rock", false);
		animator.SetBool("Paper", false);
		animator.SetBool("Scissors", false);
	}
}
