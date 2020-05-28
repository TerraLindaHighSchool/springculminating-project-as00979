using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragMouseMove : MonoBehaviour
{
    public GameObject player;
    public float horizontalSpeed = 2.0f;
    public float verticalSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(.ScreenToWorldPoint(Input.mousePosition));
        /*   float h = horizontalSpeed * Input.GetAxis("Mouse X");
           float v = verticalSpeed * Input.GetAxis("Mouse Y");
           transform.RotateAround(player.transform.Translate, 1);
      */
    }
}
