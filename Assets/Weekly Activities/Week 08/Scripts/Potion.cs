using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{
    // could be "Heal" or "Poison" or something else
    [SerializeField] private List<PotionEffect> effects = new List<PotionEffect>();

    private void Start()
    {
        // Let's try and output "effects[0].amountOfDamageHealed"
        Debug.Log(effects[0].amountOfDamageHealed);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DrinkPotion();
        }
    }

    private void DrinkPotion()
    {
        // Play sound effect
        // Show visual effect
        // Play animation of drinking
        // Pause gameplay logic
        // Force enemy time to slow down
    }
}
