namespace FormsTest
{
   partial class ucEdit
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

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.tbData = new System.Windows.Forms.TextBox();
         this.btAdd = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // tbData
         // 
         this.tbData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.tbData.Location = new System.Drawing.Point(3, 3);
         this.tbData.Name = "tbData";
         this.tbData.Size = new System.Drawing.Size(292, 20);
         this.tbData.TabIndex = 0;
         // 
         // btAdd
         // 
         this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btAdd.Location = new System.Drawing.Point(301, 3);
         this.btAdd.Name = "btAdd";
         this.btAdd.Size = new System.Drawing.Size(97, 20);
         this.btAdd.TabIndex = 1;
         this.btAdd.Text = "Add";
         this.btAdd.UseVisualStyleBackColor = true;
         // 
         // ucEdit
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.btAdd);
         this.Controls.Add(this.tbData);
         this.Name = "ucEdit";
         this.Size = new System.Drawing.Size(401, 26);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox tbData;
      private System.Windows.Forms.Button btAdd;
   }
}
