using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public string name;
    [SerializeField]
    private string secret_name;

    // Start is called before the first frame update
    void Start()
    {
        name = "MyName";
    }

    // Update is called once per frame
    void Update()
    {
        Transform t = this.gameObject.transform;
        Vector3 p = t.position;

        Debug.Log(p);
        Debug.Log("Hello World");
    }
}
