using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetTextToIP : MonoBehaviour {
    // Use this for initialization
	void Start () {
        this.GetComponent<Text>().text = Network.player.ipAddress;
        Debug.Log(Network.player.ipAddress);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
