using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    public GameObject[] items;
    float randX, randY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Dropp()
    {
        for (int i = 0; i< items.Length; i++)
        {
            do
            {
                randX = transform.position.x + Random.Range(-1f, 1f);
            } while (randX < transform.position.x + 0.8f && randX > transform.position.x - 0.8f);

            do
            {
                randY = transform.position.y + Random.Range(-1f, 1f);
            } while (randY < transform.position.y + 0.8f && randY > transform.position.y - 0.8f);
            
      
            GameObject clone = Instantiate(items[i], new Vector3(randX, randY, transform.position.z), new Quaternion()) as GameObject;
        }
    }    
}
