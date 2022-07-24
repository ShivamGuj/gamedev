using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionchange : MonoBehaviour
{
    [SerializeField]
    public GameObject ob1;
    
    [SerializeField]
    public GameObject ob2;
    public float speedy;
    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(MoveAtoB(ob1,ob2,speedy)); 
    }
    IEnumerator MoveAtoB(GameObject gameobject1,GameObject gameobject2, float speed)
    {
        while(gameobject1.transform.position!= gameobject2.transform.position)
        {
            gameobject1.transform.position = Vector3.MoveTowards(gameobject1.transform.position,gameobject2.transform.position,speed*Time.deltaTime);
            yield return null;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
