using UnityEngine;

/// <summary>
/// Attach this to a gameobject with a collider to allow it to move around with WSAD (or arrows) input.
/// </summary>
public class SimpleCharacter : MonoBehaviour
{
    [SerializeField] private float moveSpeedInUnitsPerSecond = 8;

    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * moveSpeedInUnitsPerSecond * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        // If we hit a coin, collect it!
        if(other.GetComponent<ICollectable>() != null)
        {
            // Do coin stuff!
            other.GetComponent<ICollectable>().Collect();
        }
    }
}
