using DPFP;
using DPFP.Capture;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CafeRomaraBiometric
{
    public class FingerPrintScanner : DPFP.Capture.EventHandler

    {
    public void EnrollAndSavePicture()
    {
     
        //capture.EventHandler = this;
        //capture.StartCapture();
         
  

        //DPFP.Verification.Verification.Verify(
    }
    
    public void OnComplete(object capture, string readerSerialNumber, Sample sample)
    {

      
       
        ((Capture)capture).StopCapture();
        MessageBox.Show("asdasda");
      
 
        //var sampleConvertor = new SampleConversion();
        //Bitmap bitmap = null;
        //byte[] samp=new byte[1000];
        //byte[] result = new byte[1000];
        //result= sampleConvertor.ConvertToANSI381(sample, ref samp);
        //MessageBox.Show(result.ToString());
       
        
        //Bitmap converted=sampleConvertor.ConvertToPicture(sample, ref bitmap);
      
        //converted.Save(@"C:\Users\CCSIT\Desktop\finger.bmp");
        //bitmap.Dispose();
    }
 
    public void OnFingerGone(object capture, string readerSerialNumber) { }
    public void OnFingerTouch(object capture, string readerSerialNumber) 
    {
      
    }
    public void OnReaderConnect(object capture, string readerSerialNumber) { }
    public void OnReaderDisconnect(object capture, string readerSerialNumber) { }
    public void OnSampleQuality(object capture, string readerSerialNumber, CaptureFeedback captureFeedback) { }
}
}
