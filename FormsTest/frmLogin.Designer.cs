namespace FormsTest
{
   partial class frmLogin
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.btSimple = new System.Windows.Forms.Button();
         this.btAdmin = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // btSimple
         // 
         this.btSimple.Location = new System.Drawing.Point(12, 12);
         this.btSimple.Name = "btSimple";
         this.btSimple.Size = new System.Drawing.Size(182, 23);
         this.btSimple.TabIndex = 0;
         this.btSimple.Text = "Simple User";
         this.btSimple.UseVisualStyleBackColor = true;
         this.btSimple.Click += new System.EventHandler(this.btSimple_Click);
         // 
         // btAdmin
         // 
         this.btAdmin.Location = new System.Drawing.Point(12, 41);
         this.btAdmin.Name = "btAdmin";
         this.btAdmin.Size = new System.Drawing.Size(182, 23);
         this.btAdmin.TabIndex = 1;
         this.btAdmin.Text = "Admin User";
         this.btAdmin.UseVisualStyleBackColor = true;
         this.btAdmin.Click += new System.EventHandler(this.btAdmin_Click);
         // 
         // frmLogin
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(206, 76);
         this.Controls.Add(this.btAdmin);
         this.Controls.Add(this.btSimple);
         this.Name = "frmLogin";
         this.Text = "Login";
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button btSimple;
      private System.Windows.Forms.Button btAdmin;
   }
}

