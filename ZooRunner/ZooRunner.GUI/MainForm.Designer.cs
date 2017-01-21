﻿using System.Collections.Generic;

namespace ZooRunner.GUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._scale = new ZooRunner.GUI.Scale();
            this._informations = new ZooRunner.GUI.Informations();
            this._zooViewPortControl = new ZooRunner.ZooViewPortControl();
            this._controlPanel = new ZooRunner.GUI.ControlPanel();
            this.SuspendLayout();
            // 
            // _scale
            // 
            this._scale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._scale.BackColor = System.Drawing.SystemColors.Info;
            this._scale.Enabled = false;
            this._scale.Location = new System.Drawing.Point(635, 11);
            this._scale.Margin = new System.Windows.Forms.Padding(2);
            this._scale.Name = "_scale";
            this._scale.Padding = new System.Windows.Forms.Padding(3);
            this._scale.Size = new System.Drawing.Size(90, 620);
            this._scale.TabIndex = 7;
            // 
            // _informations
            // 
            this._informations.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._informations.Location = new System.Drawing.Point(636, 634);
            this._informations.Name = "_informations";
            this._informations.Size = new System.Drawing.Size(90, 85);
            this._informations.TabIndex = 6;
            // 
            // _zooViewPortControl
            // 
            this._zooViewPortControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._zooViewPortControl.AnimalsShapes = null;
            this._zooViewPortControl.BackColor = System.Drawing.SystemColors.Control;
            this._zooViewPortControl.BoxCount = 3;
            this._zooViewPortControl.Enabled = false;
            this._zooViewPortControl.Location = new System.Drawing.Point(11, 11);
            this._zooViewPortControl.Margin = new System.Windows.Forms.Padding(2);
            this._zooViewPortControl.Name = "_zooViewPortControl";
            this._zooViewPortControl.ShowGridLines = false;
            this._zooViewPortControl.Size = new System.Drawing.Size(620, 620);
            this._zooViewPortControl.TabIndex = 5;
            this._zooViewPortControl.Text = "zooViewPortControl";
            this._zooViewPortControl.MouseLeaveControl += new System.EventHandler(this.OnMouseLeaveControl);
            this._zooViewPortControl.AreaChanged += new System.EventHandler<string>(this.OnAreaChanged);
            this._zooViewPortControl.ViewPortWidthChanged += new System.EventHandler<int>(this.OnViewPortWidthChanged);
            this._zooViewPortControl.MapWidthChanged += new System.EventHandler<int>(this.OnMapWidthChanged);
            // 
            // _controlPanel
            // 
            this._controlPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._controlPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this._controlPanel.Location = new System.Drawing.Point(11, 635);
            this._controlPanel.Margin = new System.Windows.Forms.Padding(2);
            this._controlPanel.Name = "_controlPanel";
            this._controlPanel.Size = new System.Drawing.Size(620, 85);
            this._controlPanel.TabIndex = 4;
            this._controlPanel.UserGivesDll += new System.EventHandler<ZooRunner.ZooAdapter>(this.OnUserGivesDll);
            this._controlPanel.TimerTick += new System.EventHandler<System.Collections.Generic.List<ZooRunner.AnimalAdapter>>(this.OnTimerTick);
            this._controlPanel.BoxCountChange += new System.EventHandler<int>(this.OnBoxCountChange);
            this._controlPanel.ShowGridLines += new System.EventHandler<bool>(this.OnShowGridLines);
            this._controlPanel.AnimalsRederingChange += new System.EventHandler<ZooRunner.GUI.AnimalsRedering>(this.OnAnimalsRederingChange);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(736, 731);
            this.Controls.Add(this._scale);
            this.Controls.Add(this._informations);
            this.Controls.Add(this._zooViewPortControl);
            this.Controls.Add(this._controlPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(752, 770);
            this.Name = "MainForm";
            this.Text = "ZooRunner";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion
        private ControlPanel _controlPanel;
        private ZooViewPortControl _zooViewPortControl;
        private Informations _informations;
        private Scale _scale;
    }
}

