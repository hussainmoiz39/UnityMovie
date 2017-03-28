using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class space : MonoBehaviour {
    public int a = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        a++;
        if (a > 0)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 1000);
        }
    }
}
