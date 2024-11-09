using Business_Layer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Project_C_
{
    internal static class clsGlobalClient
    {
        public static clsClients CurrentClient;
        public static bool RememberAccountNumberAndPincode(string AccountNumber, string Pincode)
        {

            try
            {
                string currentDirectory = System.IO.Directory.GetCurrentDirectory();


                string filePath = currentDirectory + "\\dataClientLogin.txt";

                if (AccountNumber == "" && File.Exists(filePath))
                {
                    File.Delete(filePath);
                    return true;

                }

                string dataToSave = AccountNumber + "#//#" + Pincode;

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(dataToSave);

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }

        }

        public static bool GetStoredCredential(ref string AccountNumber, ref string Pincode)
        {
            try
            {
                string currentDirectory = System.IO.Directory.GetCurrentDirectory();

                string filePath = currentDirectory + "\\dataClientLogin.txt";

                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                            string[] result = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

                            AccountNumber = result[0];
                            Pincode = result[1];
                        }
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
    }   }
}
