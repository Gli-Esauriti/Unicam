using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/UsableTools")]
public class UsableTools : ScriptableObject
{
    public string Name { get; set; }

    [field: TextArea]
    public string Description { get; set; }
    
    public float health { get; set; }
}
