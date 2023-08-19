using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolderDestroy : MonoBehaviour
{
    public void Update()
    {
        Destroy(gameObject, 3);
    }
}
