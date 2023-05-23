using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHP : MonoBehaviour
{
    public int maxHits;
    int timesHit;

    void OnTriggerEnter2D(Collider2D collision)
    {
        timesHit++;
        if (timesHit >= maxHits)
        {
            Destroy(this.transform.parent.gameObject, 1f);
        }
    }
}
