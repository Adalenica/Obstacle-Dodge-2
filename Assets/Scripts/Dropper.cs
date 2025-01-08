using UnityEngine;

public class Dropper : MonoBehaviour
{
  [SerializeField] float DropTime = 2f;
  MeshRenderer myMeshRenderer;
  Rigidbody myRigidBody;
   void Start ()
   {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidBody = GetComponent<Rigidbody>();
        myMeshRenderer.enabled = false;
        myRigidBody.useGravity = false;
   }   
    void Update()
    {
        if(Time.time > DropTime)
        {
            myMeshRenderer.enabled = true;
            myRigidBody.useGravity = true;
        }
    }
}
