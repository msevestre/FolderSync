namespace FolderSync.Views
{
   partial class Shell
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
         _screenBinder.Dispose();
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
         this.panelLogView = new DevExpress.XtraEditors.PanelControl();
         this.targetFolderButton = new DevExpress.XtraEditors.ButtonEdit();
         this.sourceFolderButton = new DevExpress.XtraEditors.ButtonEdit();
         this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
         this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
         this.layoutItemSourceFolder = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutItemTargetFolder = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlBase)).BeginInit();
         this.layoutControlBase.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupBase)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutItemOK)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutItemCancel)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemBase)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutItemExtra)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
         this.layoutControl.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.panelLogView)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.targetFolderButton.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.sourceFolderButton.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutItemSourceFolder)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutItemTargetFolder)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
         this.SuspendLayout();
         // 
         // btnCancel
         // 
         this.btnCancel.Location = new System.Drawing.Point(697, 12);
         this.btnCancel.Size = new System.Drawing.Size(147, 22);
         // 
         // btnOk
         // 
         this.btnOk.Location = new System.Drawing.Point(521, 12);
         this.btnOk.Size = new System.Drawing.Size(172, 22);
         // 
         // layoutControlBase
         // 
         this.layoutControlBase.Location = new System.Drawing.Point(0, 454);
         this.layoutControlBase.Size = new System.Drawing.Size(856, 46);
         this.layoutControlBase.Controls.SetChildIndex(this.btnCancel, 0);
         this.layoutControlBase.Controls.SetChildIndex(this.btnOk, 0);
         this.layoutControlBase.Controls.SetChildIndex(this.btnExtra, 0);
         // 
         // btnExtra
         // 
         this.btnExtra.Size = new System.Drawing.Size(251, 22);
         // 
         // layoutControlGroupBase
         // 
         this.layoutControlGroupBase.Size = new System.Drawing.Size(856, 46);
         // 
         // layoutItemOK
         // 
         this.layoutItemOK.Location = new System.Drawing.Point(509, 0);
         this.layoutItemOK.Size = new System.Drawing.Size(176, 26);
         // 
         // layoutItemCancel
         // 
         this.layoutItemCancel.Location = new System.Drawing.Point(685, 0);
         this.layoutItemCancel.Size = new System.Drawing.Size(151, 26);
         // 
         // emptySpaceItemBase
         // 
         this.emptySpaceItemBase.Location = new System.Drawing.Point(255, 0);
         this.emptySpaceItemBase.Size = new System.Drawing.Size(254, 26);
         // 
         // layoutItemExtra
         // 
         this.layoutItemExtra.Size = new System.Drawing.Size(255, 26);
         // 
         // layoutControl
         // 
         this.layoutControl.Controls.Add(this.panelLogView);
         this.layoutControl.Controls.Add(this.targetFolderButton);
         this.layoutControl.Controls.Add(this.sourceFolderButton);
         this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
         this.layoutControl.Location = new System.Drawing.Point(0, 0);
         this.layoutControl.Name = "layoutControl";
         this.layoutControl.Root = this.layoutControlGroup1;
         this.layoutControl.Size = new System.Drawing.Size(856, 454);
         this.layoutControl.TabIndex = 38;
         this.layoutControl.Text = "layoutControl1";
         // 
         // panelLogView
         // 
         this.panelLogView.Location = new System.Drawing.Point(24, 72);
         this.panelLogView.Name = "panelLogView";
         this.panelLogView.Size = new System.Drawing.Size(808, 358);
         this.panelLogView.TabIndex = 6;
         // 
         // targetFolderButton
         // 
         this.targetFolderButton.Location = new System.Drawing.Point(142, 48);
         this.targetFolderButton.Name = "targetFolderButton";
         this.targetFolderButton.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
         this.targetFolderButton.Size = new System.Drawing.Size(690, 20);
         this.targetFolderButton.StyleController = this.layoutControl;
         this.targetFolderButton.TabIndex = 5;
         // 
         // sourceFolderButton
         // 
         this.sourceFolderButton.Location = new System.Drawing.Point(142, 24);
         this.sourceFolderButton.Name = "sourceFolderButton";
         this.sourceFolderButton.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
         this.sourceFolderButton.Size = new System.Drawing.Size(690, 20);
         this.sourceFolderButton.StyleController = this.layoutControl;
         this.sourceFolderButton.TabIndex = 4;
         // 
         // layoutControlGroup1
         // 
         this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
         this.layoutControlGroup1.GroupBordersVisible = false;
         this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
         this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
         this.layoutControlGroup1.Name = "layoutControlGroup1";
         this.layoutControlGroup1.Size = new System.Drawing.Size(856, 454);
         this.layoutControlGroup1.TextVisible = false;
         // 
         // layoutControlGroup2
         // 
         this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutItemSourceFolder,
            this.layoutItemTargetFolder,
            this.layoutControlItem1});
         this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
         this.layoutControlGroup2.Name = "layoutControlGroup2";
         this.layoutControlGroup2.Size = new System.Drawing.Size(836, 434);
         this.layoutControlGroup2.TextVisible = false;
         // 
         // layoutItemSourceFolder
         // 
         this.layoutItemSourceFolder.Control = this.sourceFolderButton;
         this.layoutItemSourceFolder.Location = new System.Drawing.Point(0, 0);
         this.layoutItemSourceFolder.Name = "layoutItemSourceFolder";
         this.layoutItemSourceFolder.Size = new System.Drawing.Size(812, 24);
         this.layoutItemSourceFolder.TextSize = new System.Drawing.Size(115, 13);
         // 
         // layoutItemTargetFolder
         // 
         this.layoutItemTargetFolder.Control = this.targetFolderButton;
         this.layoutItemTargetFolder.Location = new System.Drawing.Point(0, 24);
         this.layoutItemTargetFolder.Name = "layoutItemTargetFolder";
         this.layoutItemTargetFolder.Size = new System.Drawing.Size(812, 24);
         this.layoutItemTargetFolder.TextSize = new System.Drawing.Size(115, 13);
         // 
         // layoutControlItem1
         // 
         this.layoutControlItem1.Control = this.panelLogView;
         this.layoutControlItem1.Location = new System.Drawing.Point(0, 48);
         this.layoutControlItem1.Name = "layoutControlItem1";
         this.layoutControlItem1.Size = new System.Drawing.Size(812, 362);
         this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
         this.layoutControlItem1.TextVisible = false;
         // 
         // Shell
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Caption = "Shell";
         this.ClientSize = new System.Drawing.Size(856, 500);
         this.Controls.Add(this.layoutControl);
         this.Name = "Shell";
         this.Text = "Shell";
         this.Controls.SetChildIndex(this.layoutControlBase, 0);
         this.Controls.SetChildIndex(this.layoutControl, 0);
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlBase)).EndInit();
         this.layoutControlBase.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupBase)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutItemOK)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutItemCancel)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemBase)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutItemExtra)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
         this.layoutControl.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.panelLogView)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.targetFolderButton.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.sourceFolderButton.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutItemSourceFolder)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutItemTargetFolder)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private DevExpress.XtraLayout.LayoutControl layoutControl;
      private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
      private DevExpress.XtraEditors.ButtonEdit targetFolderButton;
      private DevExpress.XtraEditors.ButtonEdit sourceFolderButton;
      private DevExpress.XtraLayout.LayoutControlItem layoutItemSourceFolder;
      private DevExpress.XtraLayout.LayoutControlItem layoutItemTargetFolder;
      private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
      private DevExpress.XtraEditors.PanelControl panelLogView;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
   }
}

