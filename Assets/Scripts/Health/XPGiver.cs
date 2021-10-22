using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPGiver : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Health>().OnDeath += GiveXP;
    }

    void GiveXP()
    {
        Debug.Log("More XP!");
    }
}
