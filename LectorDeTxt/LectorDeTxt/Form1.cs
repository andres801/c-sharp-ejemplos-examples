using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LectorDeTxt
{
     public partial class Form1 : Form
     {
          public Form1()
          {
               InitializeComponent();
          }

          private void Btn1_Click(object sender, EventArgs e)
          {
               try
               {
                    OpenFileDialog dialogo = new OpenFileDialog();
                    if (dialogo.ShowDialog() == DialogResult.OK)
                    {
                         string ruta;
                         ruta = dialogo.FileName;
                         // Create an instance of StreamReader to read from a file.
                         // The using statement also closes the StreamReader.
                         using (StreamReader sr = new StreamReader(ruta))
                         {
                              string line;
                              // Read and display lines from the file until the end of 
                              // the file is reached.
                              bool d = true;
                              while ((line = sr.ReadLine()) != null)
                              {
                                   string c = "columna";
                                   Console.WriteLine(line);
                                   
                                   string [] b = line.Split(',');
                                   if (d == true)
                                   {
                                        for (int i = 0; i < b.Length; i++)
                                        {
                                             c = c + " " + (i + 1);
                                             listView1.Columns.Add(c, 90);

                                             c = "columna";
                                        }
                                   }
                                   ListViewItem f = new ListViewItem(b[0]);
                                   f.Name = b[0];
                                   

                                   for (int i = 1; i < b.Length; i++)
                                   {
                                        f.SubItems.Add(b[i]);
                                   }
                                   listView1.Items.Add(f);

                                   d = false;


                              }
                         }

                    }
                    
               }
               catch (Exception a)
               {
                    // Let the user know what went wrong.
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(a.Message);
               }
          }

          private void Button1_Click(object sender, EventArgs e)
          {
               
               string c = "columna";
               listView1.Columns.Add("columna", 500,HorizontalAlignment.Left);
               listView1.Columns.Add(c, 500);
          }

          private void Button1_Click_1(object sender, EventArgs e)
          {

          }
     }
}
