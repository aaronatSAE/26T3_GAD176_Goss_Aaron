using UnityEngine;

[CreateAssetMenu(fileName = "New Potion Effect", menuName = "Alchemy/Potion Effect")]
public class PotionEffect : ScriptableObject
{
    public int amountOfDamageHealed;
    [SerializeField] private bool canCureBlindness;
    [SerializeField] private bool doesGiveWings;
}
