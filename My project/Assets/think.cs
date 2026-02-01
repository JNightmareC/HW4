using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Spell : MonoBehaviour
{
    // Start is called before the first frame update
    
    
    protected float _damage;
    public float _manacast;
    public abstract void Cast();
    public void SpendMana();

}
public class Fireball : Spellxs
{
    
    public override void Cast()
    {
        Debug.Log("cast");
        
    }

    public override void SpendMana()
    {
        Debug.Log("spent mana");
    }
}
