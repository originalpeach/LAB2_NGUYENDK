using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject eggBroken;
    public GameObject Egg;  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("dat"))
        {
            Instantiate(eggBroken, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.1f);
            Destroy(this, 0.1f);
        }
        if (col.gameObject.name.Equals("Famer"))
        {
            Instantiate(eggBroken, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.1f);
            Destroy(this, 0.1f);
        }
        if (col.gameObject.name.Equals("Box"))
        {
            Destroy(gameObject, 0.1f);
            Destroy(this, 0.1f);
        }
    }
}
