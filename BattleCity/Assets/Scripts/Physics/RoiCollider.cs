using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoiCollider : MonoBehaviour
{
    // max , min transform information
    private Vector3 minPoint, maxPoint;
    private Transform objTr;

    private Vector3 center;
    [SerializeField]
    private Vector3 size;
    // Start is called before the first frame update
    void Awake()
    {
        objTr = GetComponent<Transform>();
        minPoint.x = objTr.position.x - (objTr.localScale.x * 0.5f);
        minPoint.y = objTr.position.y -  objTr.localScale.y * 0.5f;
        //maxPoint = objTr.position + objTr.localScale * 0.5f + objTr.localScale * 0.5f; 좀이따 수정할게요....
    }

    private void Start()
    {
        print(minPoint);
        print(maxPoint);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
