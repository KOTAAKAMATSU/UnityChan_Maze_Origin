using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	Animator anim;

	UnityChan.UnityChanControlScriptWithRgidBody unitychan;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		unitychan = GetComponent< UnityChan.UnityChanControlScriptWithRgidBody >();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGoal() {
		unitychan.enabled = false;
		anim.SetBool( "Win", true );
	}
}
