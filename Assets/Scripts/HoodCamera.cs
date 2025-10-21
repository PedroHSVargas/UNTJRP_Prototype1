using UnityEngine;

public class HoodCamera : MonoBehaviour
{
    public GameObject player;
    private Vector3 HCoffset = new Vector3(0, 2.1f, 0.1f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + HCoffset;
    }
}
