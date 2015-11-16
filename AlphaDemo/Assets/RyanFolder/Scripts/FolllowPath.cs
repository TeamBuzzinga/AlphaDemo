using UnityEngine;
using System.Collections;

public class FolllowPath : MonoBehaviour {
    public Transform[] followPositions = new Transform[0];

    Vector3[] positions;
    int currentPostion;

    void Start()
    {
        setUpPositions();
    }

    void Update()
    {

    }

    void updatePostion()
    {
        Vector3 goalPosition = positions[currentPostion];
        transform.position = Vector3.Lerp(transform.position, goalPosition, Time.deltaTime);

    }

    void setUpPositions()
    {
        for(int i = 0; i < followPositions.Length; i++)
        {
            positions[i] = followPositions[i].position;
        }
    }

}
