
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float moveSpeed = 5f;
    float rotateSpeed = 50f;
    bool daggerHeld = false;
    public static int score = 6;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");
        gameObject.transform.Translate(gameObject.transform.forward * Time.deltaTime * moveSpeed * vAxis, Space.World);
        gameObject.transform.Rotate(0, rotateSpeed * Time.deltaTime * hAxis, 0);

       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectables"))
        {
            Destroy(other.gameObject);
            score--;
        }
        if (other.name == "Dagger")
        {
            daggerHeld = true;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Enemy"))
        {

            if (daggerHeld == false)
            {
                Destroy(gameObject);
               
            }
            else if (daggerHeld == true)
            {
                Destroy(other.gameObject);
            }

        }
    }


}
