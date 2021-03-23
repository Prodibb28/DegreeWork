using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ScreenShoot : MonoBehaviour
{
   public void Screenshot(){
       StartCoroutine("ScreenshootEncode");
   }

   string folderPath = "screenshots/";
   string fileName = "filename";

/* Create the folder beforehand if not exists
    if(!System.IO.Directory.Exists(folderPath))
    System.IO.Directory.CreateDirectory(folderPath);

Capture and store the screenshot
Application.CaptureScreenshot(folderPath + fileName);*/


   private IEnumerator ScreenshootEncode(){
     yield return new WaitForEndOfFrame ();
     string data = System.DateTime.Now.ToFileTime().ToString();
     ScreenCapture.CaptureScreenshot(data +".png");
   }
}
