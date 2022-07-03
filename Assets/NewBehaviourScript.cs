using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public Camera cam;
    public SphereCollider myCollider;


    public GameObject cap, cap2, cap3;
    public GameObject cube;
    public GameObject Sphere;

    public Rigidbody body;
    // Start is called before the first frame update
    void Start() {

      //  body = GetComponent<Rigidbody>();
        cam.backgroundColor = Random.ColorHSV();

        print(cam.depth);
        print(myCollider.radius);
        cap.transform.localScale = new Vector3(3, 3, 3);
        cap2.transform.localScale = new Vector3(2, 2, 2);
        cap3.transform.localScale = new Vector3(1, 1, 1);

    }

    // Update is called once per frame
    void Update() {
        Sphere.transform.Rotate(90.0f*Time.deltaTime , 0.0f, 0.0f, Space.Self);
       cube.transform.LookAt(Sphere.transform, new Vector3(4, 4, 4));
        body.AddForce(new Vector3(0, 2, 0));
    }
}
