using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// namespace Inventory.Model
// {
[CreateAssetMenu(fileName = "Recipe Data", menuName = "ScriptableObjects/Recipe SO")]
public class RecipeSO : ScriptableObject
{
    public enum ElementalType
    {
        Sun = 0,
        Fire = 1,
        Electricity = 2,
        Earth = 3,
        Moon = 4,
        Time = 5,
        Wind = 6
    }


    [field: SerializeField]
    public string RecipeName { get; set; }

    public int ID => GetInstanceID();

    [field: SerializeField]


    /// <summary>
    /// First ingredient of the recipe
    /// </summary>
    /// <value>Type SciptableObject ItemSO</value>
    public ItemSO[] Ingredient { get; set; }

    // [field : SerializeField]
    // /// <summary>
    // /// Second ingredient of the recipe
    // /// </summary>
    // /// <value>Type SciptableObject ItemSO</value>
    // public ItemSO SecondIngredient {get;set;}

    // [field : SerializeField]
    // /// <summary>
    // /// Third ingredient of the recipe
    // /// </summary>
    // /// <value>Type SciptableObject ItemSO</value>
    // public ItemSO ThirdIngredient {get;set;}

    // [field : SerializeField]
    // /// <summary>
    // /// Fourth optional ingredient of the recipe
    // /// </summary>
    // /// <value>Type SciptableObject ItemSO</value>
    // public ItemSO FourthIngredient {get;set;}

    /// <summary>
    /// Ingredient's respective elements by order of input
    /// </summary>
    /// <value>Type ElementalType</value>
    [field: SerializeField]
    public ElementalType[] ElementType { get; set; }

    [field: SerializeField]
    [field: TextArea]
    /// <summary>
    /// Description of recipe
    /// </summary>
    /// <value>String of text</value>
    public string Description { get; set; }

    [field: SerializeField]
    public Sprite PotionImage { get; set; }
}
// }