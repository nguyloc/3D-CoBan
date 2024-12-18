using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class AttributesManager : MonoBehaviour
{
    public int attack;
    public int heath;
    public int amor;
    public float criticalChange;
    public float criticalDamage;
 
    public void TakeDamage(int hp)
    {
        //heath -= hp - (hp * amor/100);
        heath -= hp;
        Vector3 rand = new Vector3(Random.Range(0, 0.25f),
                                   Random.Range(0, 0.25f),
                                   Random.Range(0, 0.25f));
        DamagePopupGenerator.current.CreatePopup(transform.position + rand, hp.ToString(), Color.yellow);
    }

    public void DealDamage(GameObject target)
    {
        var atm = target.GetComponent<AttributesManager>();
        if (atm != null)
        {
            float totalDamage = attack;
            if (Random.Range(0f, 1f) < criticalChange)
            {
                totalDamage *= criticalDamage;
                atm.TakeDamage((int)totalDamage);
            }
        }
    }
}
