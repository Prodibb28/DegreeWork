using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
     [SerializeField]
     GameObject TeacherB,CoffeShopB,DirectorB,PorterLodgeB,SchoolCounselorB,courtyardB,
     CoordinatorsB;
     [SerializeField]
     GameObject Teacher,CoffeShop,Director,PorterLodge,SchoolCounselor,courtyard,
     Coordinators;
     Vector2 TeacherInitialPos,PorterLodgeInitialPos,CoffeShopInitialPos,DirectorInitialPos,SchoolCounselorInitialPos,courtyardInitialPos,
     CoordinatorsInitialPos;

void Start(){
   TeacherInitialPos = Teacher.transform.position; 
   PorterLodgeInitialPos = PorterLodge.transform.position; 
   CoffeShopInitialPos = CoffeShop.transform.position; 
   DirectorInitialPos = Director.transform.position;
   SchoolCounselorInitialPos = SchoolCounselor.transform.position; 
   courtyardInitialPos = courtyard.transform.position;
   CoordinatorsInitialPos = Coordinators.transform.position;
}



public void DragTeacher(){
   Teacher.transform.position = Input.mousePosition;   
}

public void DropTeacher(){
    float Distance= Vector3.Distance(Teacher.transform.position, TeacherB.transform.position);
       if (Distance<70){
           Teacher.transform.position = TeacherB.transform.position;
        }    
       else{
           Teacher.transform.position =TeacherInitialPos;          
       }
}


public void DragPorterLodge(){ 
      PorterLodge.transform.position = Input.mousePosition;   
}

public void DropPorterLodge(){
    float Distance= Vector3.Distance(PorterLodge.transform.position, PorterLodgeB.transform.position);
       if (Distance<70){
           PorterLodge.transform.position = PorterLodgeB.transform.position;
        }    
       else{
           PorterLodge.transform.position =PorterLodgeInitialPos;          
       }
}


public void DragCoffeShop(){
       CoffeShop.transform.position = Input.mousePosition;   
}

public void DropCoffeShopr(){
    float Distance= Vector3.Distance(CoffeShop.transform.position, CoffeShopB.transform.position);
       if (Distance<70){
           CoffeShop.transform.position = CoffeShopB.transform.position;
        }    
       else{
           CoffeShop.transform.position =CoffeShopInitialPos;          
       }
}


public void DragDirector(){
  Director.transform.position = Input.mousePosition;   
}
  
public void DropDirector(){
    float Distance= Vector3.Distance(Director.transform.position, DirectorB.transform.position);
       if (Distance<70){
           Director.transform.position = DirectorB.transform.position;
        }    
       else{
           Director.transform.position = DirectorInitialPos;          
       }
}


public void DragSchoolCounselor(){
  SchoolCounselor.transform.position = Input.mousePosition;   
}
  
public void DropSchoolCounselor(){
    float Distance= Vector3.Distance(SchoolCounselor.transform.position, SchoolCounselorB.transform.position);
       if (Distance<70){
           SchoolCounselor.transform.position = SchoolCounselorB.transform.position;
        }    
       else{
           SchoolCounselor.transform.position = SchoolCounselorInitialPos;          
       }
}


public void Dragcourtyard(){
  courtyard.transform.position = Input.mousePosition;   
}
  
public void Dropcourtyard(){
    float Distance= Vector3.Distance(courtyard.transform.position, courtyardB.transform.position);
       if (Distance<70){
           courtyard.transform.position = courtyardB.transform.position;
        }    
       else{
           courtyard.transform.position = courtyardInitialPos;          
       }
}



public void DragCoordinators(){
  Coordinators.transform.position = Input.mousePosition;   
}
  
public void DropCoordinators(){
    float Distance= Vector3.Distance(Coordinators.transform.position, CoordinatorsB.transform.position);
       if (Distance<70){
           Coordinators.transform.position = CoordinatorsB.transform.position;
        }    
       else{
           Coordinators.transform.position = CoordinatorsInitialPos;          
       }
}
}