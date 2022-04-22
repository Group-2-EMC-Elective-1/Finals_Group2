using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DragMouseMove : MonoBehaviour
{

    private Plane draggingPlane;
    private Vector3 offset;
    private Vector3 lastPos;
    public Transform target;
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
        Vector3 screenPos = mainCamera.WorldToScreenPoint(target.position);
        lastPos = this.transform.position; ;
    }

    void OnMouseDown()
    {
        draggingPlane = new Plane(mainCamera.transform.forward,transform.position);
            Ray camRay = mainCamera.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(camRay.origin, camRay.direction *10, Color.green);

            float planeDistance;
            draggingPlane.Raycast(camRay, out planeDistance);
            offset = transform.position - camRay.GetPoint(planeDistance);
    }
    void OnMouseDrag()
    {
            Ray camRay = mainCamera.ScreenPointToRay(Input.mousePosition);
            float planeDistance;
            draggingPlane.Raycast(camRay, out planeDistance);
            transform.position = camRay.GetPoint(planeDistance) + offset;
        Vector3 screenPos = mainCamera.WorldToScreenPoint(target.position);
    }
    private void OnMouseUpAsButton()
    {
        transform.position = lastPos;
    }
}