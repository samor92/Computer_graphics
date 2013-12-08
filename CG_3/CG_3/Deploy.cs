using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CG_3
{
    public partial class Deploy
    {
        public void RecreateAllExecutableResources()
        {
            // Get Current Assembly refrence
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            // Get Assembly name
            string assemblyName = typeof(Program).Assembly.GetName().Name + ".";
            // Get all imbedded resources
            string[] arrResources = currentAssembly.GetManifestResourceNames();

            foreach (string resourceName in arrResources)
            {
                if (resourceName.EndsWith(".exe") || resourceName.EndsWith(".dll"))
                { //or any other extension desired
                    //Name of the file saved on disk
                    string saveAsName = resourceName;
                    saveAsName = saveAsName.Remove(0, 9);
                    FileInfo fileInfoOutputFile = new FileInfo(saveAsName);

                    if (fileInfoOutputFile.Exists)
                    {
                        //overwrite if desired or break (depending on your needs)
                        //fileInfoOutputFile.Delete();
                    }
                    //OPEN NEWLY CREATING FILE FOR WRITTING
                    FileStream streamToOutputFile = fileInfoOutputFile.OpenWrite();
                    //GET THE STREAM TO THE RESOURCES
                    Stream streamToResourceFile = currentAssembly.GetManifestResourceStream(resourceName);

                    //---------------------------------
                    //SAVE TO DISK OPERATION
                    //---------------------------------
                    const int size = 4096;
                    byte[] bytes = new byte[4096];
                    int numBytes;
                    while ((numBytes = streamToResourceFile.Read(bytes, 0, size)) > 0)
                        streamToOutputFile.Write(bytes, 0, numBytes);
                    streamToOutputFile.Close();
                    streamToResourceFile.Close();
                }//if

            }//end_foreach
        }//end_mRecreateAllExecutableResources
    }
}
