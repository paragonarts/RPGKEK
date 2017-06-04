using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed;
//  public delegate void ActionListeners();
//  public event ActionListeners OnPlayersAction;
    public GameObject CameraRotator;
    // Use this for initialization
    void Start () {
        
    }

    // Update is called once per frame
    void Update () {
        gameObject.GetComponent<Transform>().Translate(Input.GetAxis("Horizontal")*speed, 0, Input.GetAxis("Vertical")*speed);

        if (Input.GetButtonDown("CameraRotation"))
        {
            Debug.Log(Input.GetAxis("CameraRotation"));
            CameraRotator.GetComponent<Transform>().RotateAround(gameObject.GetComponent<Transform>().position, Vector3.up, Input.GetAxis("CameraRotation") * 90);

        }
    }
}
