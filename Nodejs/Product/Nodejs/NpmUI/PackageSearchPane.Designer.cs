﻿/* ****************************************************************************
 *
 * Copyright (c) Microsoft Corporation. 
 *
 * This source code is subject to terms and conditions of the Apache License, Version 2.0. A 
 * copy of the license can be found in the License.html file at the root of this distribution. If 
 * you cannot locate the Apache License, Version 2.0, please send an email to 
 * vspython@microsoft.com. By using this source code in any fashion, you are agreeing to be bound 
 * by the terms of the Apache License, Version 2.0.
 *
 * You must not remove this notice, or any other, from this software.
 *
 * ***************************************************************************/

namespace Microsoft.NodejsTools.NpmUI
{
    partial class PackageSearchPane
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

            if (disposing && null != _busy)
            {
                _busy.Dispose();
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
            this._panelFind = new System.Windows.Forms.Panel();
            this._txtFind = new System.Windows.Forms.TextBox();
            this._labelFind = new System.Windows.Forms.Label();
            this._listResults = new System.Windows.Forms.ListView();
            this._panelRefresh = new System.Windows.Forms.Panel();
            this._labelLastUpdated = new System.Windows.Forms.Label();
            this._labelLastUpdateTime = new System.Windows.Forms.Label();
            this._buttonRefresh = new System.Windows.Forms.Button();
            this._panelFind.SuspendLayout();
            this._panelRefresh.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panelFind
            // 
            this._panelFind.Controls.Add(this._txtFind);
            this._panelFind.Controls.Add(this._labelFind);
            this._panelFind.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelFind.Location = new System.Drawing.Point(0, 0);
            this._panelFind.Name = "_panelFind";
            this._panelFind.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this._panelFind.Size = new System.Drawing.Size(636, 24);
            this._panelFind.TabIndex = 0;
            // 
            // _txtFind
            // 
            this._txtFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtFind.Location = new System.Drawing.Point(35, 0);
            this._txtFind.Name = "_txtFind";
            this._txtFind.Size = new System.Drawing.Size(601, 20);
            this._txtFind.TabIndex = 1;
            this._txtFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this._txtFind_KeyUp);
            // 
            // _labelFind
            // 
            this._labelFind.Dock = System.Windows.Forms.DockStyle.Left;
            this._labelFind.Location = new System.Drawing.Point(0, 0);
            this._labelFind.Name = "_labelFind";
            this._labelFind.Size = new System.Drawing.Size(35, 20);
            this._labelFind.TabIndex = 0;
            this._labelFind.Text = "Find:";
            this._labelFind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _listResults
            // 
            this._listResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this._listResults.FullRowSelect = true;
            this._listResults.Location = new System.Drawing.Point(0, 24);
            this._listResults.MultiSelect = false;
            this._listResults.Name = "_listResults";
            this._listResults.OwnerDraw = true;
            this._listResults.ShowGroups = false;
            this._listResults.Size = new System.Drawing.Size(636, 406);
            this._listResults.TabIndex = 1;
            this._listResults.UseCompatibleStateImageBehavior = false;
            this._listResults.View = System.Windows.Forms.View.Details;
            this._listResults.VirtualMode = true;
            this._listResults.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this._listResults_DrawItem);
            this._listResults.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this._listResults_RetrieveVirtualItem);
            this._listResults.SelectedIndexChanged += new System.EventHandler(this._listResults_SelectedIndexChanged);
            // 
            // _panelRefresh
            // 
            this._panelRefresh.Controls.Add(this._buttonRefresh);
            this._panelRefresh.Controls.Add(this._labelLastUpdateTime);
            this._panelRefresh.Controls.Add(this._labelLastUpdated);
            this._panelRefresh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._panelRefresh.Location = new System.Drawing.Point(0, 430);
            this._panelRefresh.Name = "_panelRefresh";
            this._panelRefresh.Size = new System.Drawing.Size(636, 27);
            this._panelRefresh.TabIndex = 2;
            // 
            // _labelLastUpdated
            // 
            this._labelLastUpdated.AutoSize = true;
            this._labelLastUpdated.Location = new System.Drawing.Point(4, 9);
            this._labelLastUpdated.Name = "_labelLastUpdated";
            this._labelLastUpdated.Size = new System.Drawing.Size(107, 13);
            this._labelLastUpdated.TabIndex = 0;
            this._labelLastUpdated.Text = "Catalog last updated:";
            // 
            // _labelLastUpdateTime
            // 
            this._labelLastUpdateTime.AutoSize = true;
            this._labelLastUpdateTime.Location = new System.Drawing.Point(109, 9);
            this._labelLastUpdateTime.Name = "_labelLastUpdateTime";
            this._labelLastUpdateTime.Size = new System.Drawing.Size(95, 13);
            this._labelLastUpdateTime.TabIndex = 1;
            this._labelLastUpdateTime.Text = "Today at 10:00AM";
            // 
            // _buttonRefresh
            // 
            this._buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonRefresh.Location = new System.Drawing.Point(512, 4);
            this._buttonRefresh.Name = "_buttonRefresh";
            this._buttonRefresh.Size = new System.Drawing.Size(121, 23);
            this._buttonRefresh.TabIndex = 2;
            this._buttonRefresh.Text = "&Refresh Catalog";
            this._buttonRefresh.UseVisualStyleBackColor = true;
            this._buttonRefresh.Click += new System.EventHandler(this._buttonRefresh_Click);
            // 
            // PackageSearchPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._listResults);
            this.Controls.Add(this._panelRefresh);
            this.Controls.Add(this._panelFind);
            this.Name = "PackageSearchPane";
            this.Size = new System.Drawing.Size(636, 457);
            this._panelFind.ResumeLayout(false);
            this._panelFind.PerformLayout();
            this._panelRefresh.ResumeLayout(false);
            this._panelRefresh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panelFind;
        private System.Windows.Forms.TextBox _txtFind;
        private System.Windows.Forms.Label _labelFind;
        private System.Windows.Forms.ListView _listResults;
        private System.Windows.Forms.Panel _panelRefresh;
        private System.Windows.Forms.Button _buttonRefresh;
        private System.Windows.Forms.Label _labelLastUpdateTime;
        private System.Windows.Forms.Label _labelLastUpdated;
    }
}
