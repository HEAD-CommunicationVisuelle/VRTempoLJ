using UnityEngine;
using UnityEngine.EventSystems;

public class Fob : MonoBehaviour, IPointerClickHandler
{

    public float speed = 1f;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the object on z axis
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (Vector3.Distance(transform.position, Camera.main.transform.position) < 1.5f)
        Catch();
    }

    // This function is called when the object is clicked or touched
    public void Catch (){
        Debug.Log("Catch");
        
        // Destroy the object
        Destroy(gameObject);
    }

}
