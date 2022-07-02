using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Pig : MonoBehaviour
{
    Bandit bt;
    // Use this for initialization
    void Start()
    {
        //Warrior adl nama dari game object yg ada di hierarchy
        bt = GameObject.Find("Warrior").GetComponent<Bandit>();
    }
    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            bt.nyawa--;
        }
        if (bt.nyawa < 0)
        {
            bt.play_again = true;
        }
    }
}