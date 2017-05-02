using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed;

    // Use this for initialization
    void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector2.right * movementSpeed * Time.deltaTime);
	}
}
