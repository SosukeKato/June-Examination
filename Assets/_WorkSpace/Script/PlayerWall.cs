using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWall : MonoBehaviour
{
    public Transform _tr;
    // Start is called before the first frame update
    void Start()
    {
        _tr = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Keypad1))
        {
            _tr.position = new Vector3(-1, 0, -1);
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            _tr.position = new Vector3(0, 0, -1);
        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            _tr.position = new Vector3(1, 0, -1);
        }
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            _tr.position = new Vector3(-1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            _tr.position = new Vector3(1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            _tr.position = new Vector3(-1, 0, 1);
        }
        if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            _tr.position = new Vector3(0, 0, 1);
        }
        if (Input.GetKeyDown(KeyCode.Keypad9))
        {
            _tr.position = new Vector3(1, 0, 1);
        }
    }
}
