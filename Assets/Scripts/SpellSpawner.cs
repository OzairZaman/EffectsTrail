using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellSpawner : MonoBehaviour
{

    #region
    public GameObject spellPrefab;
    #endregion

    void Start()
    {
        GameObject spellClone = Instantiate(spellPrefab, gameObject.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
