using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    // Start is called before the first frame update
    bool inputActivo = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            inputActivo = !inputActivo;
        }
    }

    void FixedUpdate()
    {
        if (inputActivo)
        {
            float movimientoMouse = Input.GetAxis("Mouse X");
            transform.Translate(new Vector3(1, 0, 0) * movimientoMouse);
        }
    }
}
