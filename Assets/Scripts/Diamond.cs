using UnityEngine;

public class Diamond : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
       if(other.tag == "Player")
        {
            FindObjectOfType<ScoreManager>().UpdateScore();
            Destroy(gameObject);
        } 
    }
}
