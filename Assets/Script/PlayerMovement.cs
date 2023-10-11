using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // Update is called once per frame HELLo
    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime, 0, 0);
        transform.Rotate(new Vector3(0, 0, Time.deltaTime));
		if (Input.GetButtonDown("Jump"))
		{
            transform.position += new Vector3(0, 1, 0);
		}
    }
}
