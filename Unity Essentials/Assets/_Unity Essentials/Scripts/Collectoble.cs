
using UnityEngine;

public class Collectoble : MonoBehaviour
{
    private float _rotateSpeed = 100f;
    
    public GameObject effectGameObject; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,1,0) * _rotateSpeed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player"))
        {
            Instantiate(effectGameObject,transform.position,transform.rotation);
        Destroy(gameObject);
        }
        
    }
}
