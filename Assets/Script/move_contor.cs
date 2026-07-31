using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class move_contor : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.D) && !Input.GetKeyUp(KeyCode.D))
        {
            this.transform.Translate(new Vector3(2f,0f, 0f) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A) && !Input.GetKeyUp(KeyCode.A))
        {
            this.transform.Translate(new Vector3(-2f, 0f, 0f) * Time.deltaTime);
        }
    }
}
