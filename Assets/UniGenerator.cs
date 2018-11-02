using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniGenerator : MonoBehaviour {
    public GameObject UniPrefab;
    public Transform Uni;
    public float speed = 100;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(1))
        {
            GameObject go = Instantiate(UniPrefab) as GameObject;
            go.transform.position = transform.position;

            go.GetComponent<Rigidbody2D>().AddForce(Vector2.right * speed, ForceMode2D.Impulse);
            //Vector3 force;

            //force = this.gameObject.transform.forward * speed;
        }
    }
}
