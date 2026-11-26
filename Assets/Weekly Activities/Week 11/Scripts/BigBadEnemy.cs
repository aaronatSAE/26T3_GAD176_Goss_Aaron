using UnityEngine;

public class BigBadEnemy : MonoBehaviour
{
    public static int hitPoints = 1;

    private void Start()
    {
        hitPoints = Random.Range(1, 6);
        Debug.Log("Threat is at: " + hitPoints);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Threat is at: " + hitPoints);
        }
    }
}
