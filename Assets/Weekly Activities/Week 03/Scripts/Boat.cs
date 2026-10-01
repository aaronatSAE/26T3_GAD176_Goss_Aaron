using UnityEngine;

public class Boat : Vehicle
{
    private void Start()
    {
        Debug.Log("This vehicle's name is: " + carCharacterName);
    }

    private void Update()
    {
        // Player input
        // When player holds UP arrow (accelerate)
        // Add physics forward to accelerate the vehicle
        // using the "accelerationRate" variable
    }
}
