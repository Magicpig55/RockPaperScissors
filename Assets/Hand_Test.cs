using UnityEngine;
using System.Collections;

public class Hand_Test : MonoBehaviour {

    Animator animator;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(KeyCode.A)) {
            ClearAllAnim();
            animator.SetBool("Rock", true);
            animator.SetTrigger("Shoot");
        }
        if (Input.GetKeyDown(KeyCode.S)) {
            ClearAllAnim();
            animator.SetBool("Paper", true);
            animator.SetTrigger("Shoot");
        }
        if (Input.GetKeyDown(KeyCode.D)) {
            ClearAllAnim();
            animator.SetBool("Scissors", true);
            animator.SetTrigger("Shoot");
        }
        if (Input.GetKeyDown(KeyCode.F)) {
            ClearAllAnim();
            animator.SetTrigger("Reset");
        }
    }

    private void ClearAllAnim() {
        animator.SetBool("Rock", false);
        animator.SetBool("Paper", false);
        animator.SetBool("Scissors", false);
    }
}
