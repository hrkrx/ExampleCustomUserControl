namespace FormsTest
{
   partial class frmDataView
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
         this.ucView1 = new FormsTest.ucView();
         this.ucEdit1 = new FormsTest.ucEdit();
         this.SuspendLayout();
         // 
         // ucView1
         // 
         this.ucView1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.ucView1.Location = new System.Drawing.Point(0, 26);
         this.ucView1.Name = "ucView1";
         this.ucView1.Size = new System.Drawing.Size(284, 235);
         this.ucView1.TabIndex = 0;
         this.ucView1.UserLevelRequired = 0;
         // 
         // ucEdit1
         // 
         this.ucEdit1.Dock = System.Windows.Forms.DockStyle.Top;
         this.ucEdit1.Location = new System.Drawing.Point(0, 0);
         this.ucEdit1.Name = "ucEdit1";
         this.ucEdit1.Size = new System.Drawing.Size(284, 26);
         this.ucEdit1.TabIndex = 1;
         this.ucEdit1.UserLevelRequired = 100;
         // 
         // frmDataView
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(284, 261);
         this.Controls.Add(this.ucView1);
         this.Controls.Add(this.ucEdit1);
         this.Name = "frmDataView";
         this.Text = "frmDataView";
         this.ResumeLayout(false);

      }

      #endregion

      private ucView ucView1;
      private ucEdit ucEdit1;
   }
}