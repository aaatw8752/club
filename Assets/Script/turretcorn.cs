using Unity.VisualScripting;
using UnityEngine;

public class turretcorn : MonoBehaviour
{

    public GameObject player;
    public GameObject bulletPrefab;

    public bool wakeUp ;
    public float fireTime= 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.transform.eulerAngles = Vector3.zero;
        wakeUp = false;
    }

    // Update is called once per frame
    void Update()
    {
       if(wakeUp)
        {
            aim();
            fireTime += Time.deltaTime;
            if (fireTime >= 2.0f)
            {
                fire();
                fireTime = 0f;
            }
        }
    }
    
    private void fire()
    {
        Debug.Log("fire");

        Instantiate(bulletPrefab, this.transform.Find("bulletspawn").position, this.transform.rotation);
    }
    private void aim ()
    {
        this.transform.LookAt(player.transform.position);
        if(player.transform.position.x < this.transform.position.x)
        {
            this.transform.eulerAngles = new Vector3(0, 0, this.transform.eulerAngles.x-90);
        }
        else
        {
            this.transform.eulerAngles = new Vector3(0, 0, -this.transform.eulerAngles.x+90);
        }
        
    }
}
