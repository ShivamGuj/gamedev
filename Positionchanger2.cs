using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Positionchanger2 : MonoBehaviour
{
    [SerializeField]
    public GameObject ob1;

    [SerializeField]
    public GameObject ob3;
    public float speedy;
    // Start is called before the first frame update
    void Start()
    {
       
       StartCoroutine(MoveBtoC(ob1,ob3,speedy));
       
    }
    IEnumerator MoveBtoC(GameObject gameobject1,GameObject gameobject3, float speed)
    {
        while(gameobject1.transform.position!= gameobject3.transform.position)
        {
            gameobject1.transform.position = Vector3.MoveTowards(gameobject1.transform.position,gameobject3.transform.position,speed*Time.deltaTime);
            yield return null;
        }
    }
    // Update is called once per frame
    void Update()
    { 
        
    }
}
