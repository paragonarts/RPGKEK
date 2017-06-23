using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Vector3 CameraCoords;
    public bool IsRotating = false;
    //  public delegate void ActionListeners();
    //  public event ActionListeners OnPlayersAction;
    public GameObject CameraRotator;
    public Ray r;
    Vector3 hited;
    public Vector3 jopa;
    public CameraController CameraScript;
    // Use this for initialization
    void Start()
    {
        CameraScript = CameraRotator.GetComponent<CameraController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 jopa = new Vector3(Input.mousePosition.x, 0f, Input.mousePosition.y);
        r = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(r, out hit))
        {
            hited = hit.point;
        }
        else { hited = Vector3.zero; }
        Debug.Log(hited);
        jopa = new Vector3(hited.x, 1, hited.z);
        gameObject.GetComponent<Transform>().LookAt(jopa);
        //gameObject.GetComponent<Transform>().LookAt(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        gameObject.GetComponent<Transform>().Translate(Input.GetAxis("Horizontal") * speed, 0, Input.GetAxis("Vertical") * speed);

        if (Input.GetButtonDown("CameraRotation") && !IsRotating)
        {
            IsRotating = true;
            CameraScript.Rotating = true;
            CameraCoords.x = CameraRotator.GetComponent<Transform>().localPosition.x;
            CameraCoords.y = CameraRotator.GetComponent<Transform>().eulerAngles.y;
            CameraCoords.z = CameraRotator.GetComponent<Transform>().localPosition.z;
            StartCoroutine(CameraRotate(Input.GetAxis("CameraRotation"), 0f));
            CameraScript.ChangeOffset(Input.GetAxis("CameraRotation"));


        }
    }
    IEnumerator CameraRotate(float Axis, float angle)
    {

        while (angle <= 90)
        {
            CameraRotator.GetComponent<Transform>().RotateAround(gameObject.GetComponent<Transform>().position, Vector3.up, Axis * 90 * Time.deltaTime);
            angle += 90 * Time.deltaTime;
            yield return null;
        }
        CheckCoords(Axis);
        IsRotating = false;
        CameraScript.Rotating = false;
        yield break;
    }
    private void CheckCoords(float axis)
    {
        //CameraRotator.GetComponent<Transform>().localPosition = new Vector3(CameraCoords.z * axis, CameraRotator.GetComponent<Transform>().localPosition.y, CameraCoords.x * axis * (-1));
        //CameraRotator.GetComponent<Transform>().rotation = Quaternion.Euler(30, CameraCoords.y + 90 * axis, 0);
    }
}
