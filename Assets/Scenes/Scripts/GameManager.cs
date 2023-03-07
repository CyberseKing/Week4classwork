using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int objNum;
    public GameObject objCollect;

    public Transform leftTop;
    public Transform rightBottom;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i <objNum; i++)
        {
            float newX = Random.Range(leftTop.position.x, rightBottom.position.x);
            float newZ = Random.Range(rightBottom.position.z, leftTop.position.z);
            Vector3 newPos = new Vector3(newX, transform.position.y, newZ);
            GameObject newObj = Instantiate(objCollect, newPos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hit");
        if(other.gameObject.tag == "Collect") ;
        {
            Destroy(other.gameObject);
        }
    }
    void Update()
    {
        
    }
}
