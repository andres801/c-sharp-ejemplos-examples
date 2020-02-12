namespace LectorDeTxt
{
     partial class Form1
     {
          /// <summary>
          /// Variable del diseñador necesaria.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          /// Limpiar los recursos que se estén usando.
          /// </summary>
          /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Código generado por el Diseñador de Windows Forms

          /// <summary>
          /// Método necesario para admitir el Diseñador. No se puede modificar
          /// el contenido de este método con el editor de código.
          /// </summary>
          private void InitializeComponent()
          {
               this.listView1 = new System.Windows.Forms.ListView();
               this.btn1 = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // listView1
               // 
               this.listView1.HideSelection = false;
               this.listView1.Location = new System.Drawing.Point(13, 13);
               this.listView1.Name = "listView1";
               this.listView1.Size = new System.Drawing.Size(662, 139);
               this.listView1.TabIndex = 0;
               this.listView1.UseCompatibleStateImageBehavior = false;
               this.listView1.View = System.Windows.Forms.View.Details;
               // 
               // btn1
               // 
               this.btn1.Location = new System.Drawing.Point(13, 158);
               this.btn1.Name = "btn1";
               this.btn1.Size = new System.Drawing.Size(75, 23);
               this.btn1.TabIndex = 2;
               this.btn1.Text = "Leer archivo";
               this.btn1.UseVisualStyleBackColor = true;
               this.btn1.Click += new System.EventHandler(this.Btn1_Click);
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(687, 265);
               this.Controls.Add(this.btn1);
               this.Controls.Add(this.listView1);
               this.Name = "Form1";
               this.Text = "Form1";
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.ListView listView1;
          private System.Windows.Forms.Button btn1;
     }
}

