using UnityEngine;
using System.Collections;

public class carController : MonoBehaviour
{

    //Car turning speed
    public float turningSpeed = 10f;
    Vector2 carPosition;
    //
    float maxHorizotalPosition = 1.8f;
    float minHorizontallPosition = -1.7f;
    float maxVerticalPosition = 3.9f;
    float minVerticalPosition = -4.15f;


    // Use this for initialization
    void Start()
    {
        carPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {   
        //Control car horizonatally
        carPosition.x += Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime;
        carPosition.x = Mathf.Clamp(carPosition.x, minHorizontallPosition, maxHorizotalPosition);

        //Control car vertically
        carPosition.y += Input.GetAxis("Vertical") * turningSpeed * Time.deltaTime;
        carPosition.y = Mathf.Clamp(carPosition.y, minVerticalPosition, maxVerticalPosition);

        transform.position = carPosition;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
        }
    }
}
