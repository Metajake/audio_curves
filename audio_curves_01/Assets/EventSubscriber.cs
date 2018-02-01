using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

public class EventSubscriber : MonoBehaviour {

	// Use this for initialization
	void Start () {
		 Koreographer.Instance.RegisterForEvents("TestEventID", FireEventDebugLog);
	}

	void FireEventDebugLog(KoreographyEvent koreoEvent) {
     Debug.Log("Koreography Event Fired.");
	}

	// Update is called once per frame
	void Update () {

	}
}
