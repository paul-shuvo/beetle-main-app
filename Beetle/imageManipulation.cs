using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Tasks;

namespace Beetle
{
    public class imageManipulation
    {
        
        private String captureImage()
        {
            CameraCaptureTask cct = new CameraCaptureTask();
            cct.Completed += new EventHandler<PhotoResult>(cctFired);
        }

        void cctFired(object Sender, PhotoResult e )
        {
            if (e.TaskResult == TaskResult.OK && e.ChosenPhoto != null)
            {
                

            }

        }

    }
}
