using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public GameObject Player;
    public bool Rotating;
    // Use this for initialization
    Vector3 Offset;
    void Start () {
        Offset = new Vector3(-24.64f, 17.66f, -26.87f);
    }
	
	// Update is called once per frame
	void Update () {
        if (!Rotating)
        {
            Vector3 PlayerPosition = Player.GetComponent<Transform>().position;
            gameObject.GetComponent<Transform>().position = PlayerPosition + Offset;
        }
    }
    public void ChangeOffset(float Axis)
    {
        Offset = new Vector3(Offset.z * Axis, 17.66f, Offset.x * Axis * (-1));
    }

}
