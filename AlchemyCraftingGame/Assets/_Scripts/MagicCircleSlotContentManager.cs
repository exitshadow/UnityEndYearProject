using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicCircleSlotContentManager : MonoBehaviour
{
    RecipeSO activeRecipe;

    public ItemSO.ElementalType element;    //need to point out the class where the enum is!
    // Start is called before the first frame update
    void Start()
    {
        DraggableItem[] ingredients = FindObjectsOfType<DraggableItem>();
        
    }

    
}