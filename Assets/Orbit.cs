using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    [SerializeField]
     Transform worldTreePos;
    /// <summary>
    /// Have it orbit around target object's position around the y axis. Play with degrees later. 90 as a start
    /// </summary>
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(worldTreePos.position, Vector3.right, 90f * Time.deltaTime);
    }
}
