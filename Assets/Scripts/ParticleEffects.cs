using UnityEngine;
using System.Collections;

public class ParticleEffects : MonoBehaviour {

	// Use this for initialization
	void Start () {
		particleSystem.renderer.sortingLayerName = "player";
		particleSystem.renderer.sortingOrder = 1;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
