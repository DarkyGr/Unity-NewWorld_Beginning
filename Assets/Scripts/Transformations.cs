using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformations : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Position
        /*
         * Right - Left => X
         * Up - Down => Y
         * Forward - Back => Z
         */
        transform.position = new Vector3(3, 2, 10);             // Position (3, 2, 10)
        transform.position += Vector3.right;                    // Position (4, 2, 10)
        transform.position += Vector3.right * 10;               // Position (14, 2, 10)

        // Rotation
        // In rotation it can't sum, only multiplication
        //transform.rotation = Quaternion.Euler(0, 45, 0);        // Rotation (0, 45, 0)
        //transform.rotation *= Quaternion.Euler(0, 0, 15);       // Rotation (0, 45, 15)
        //transform.rotation = Quaternion.identity;               // Rotation (0, 0, 0)

        // Scale
        //transform.localScale = new Vector3(2, 2, 2);            // Scale (2, 2, 2)
        //transform.localScale += new Vector3(1, 1, 1);           // Scale (3, 3, 3)
        //transform.localScale *= 2;                              // Scale (6, 6, 6)
        //transform.localScale += new Vector3(0, 0.5f, 0);        // Scale (6, 6.5, 6)
        //transform.localScale += Vector3.one;                    // Scale (1, 1, 1)
    }
}
