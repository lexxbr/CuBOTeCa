using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btAvalia : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Application.OpenURL("https://goo.gl/maps/ZLh6ui9hFEiHeQsL9");
        Debug.Log("Esta Funcionando?");
    }
}
