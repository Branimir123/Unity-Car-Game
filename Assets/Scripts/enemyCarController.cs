using UnityEngine;
using System.Collections;

public class enemyCarController : MonoBehaviour {

    public float enemySpeed = 6f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, enemySpeed * Time.deltaTime, 0);	
	}
}
