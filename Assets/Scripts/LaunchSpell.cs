using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchSpell : MonoBehaviour
{
    #region Variables
    Rigidbody rigid;
    public float force = 100;
    #endregion

    #region Internal
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        Destroy(gameObject, 2); //destroy it after 2 seconds
    }


    void FixedUpdate()
    {
        rigid.AddForce(new Vector3(0, 0, force), ForceMode.Acceleration);
    }
    #endregion


}
