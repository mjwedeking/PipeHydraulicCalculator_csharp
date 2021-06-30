using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using HydraulicCalc.Converters;
using HydraulicCalc.Common;
using System.Runtime.InteropServices;

namespace HydraulicCalc
{	
	/// <summary>
	/// Main form for Hydraulic Calculator.
	/// </summary>
	public class frmHydCalc : System.Windows.Forms.Form
	{
		/// <summary>
		/// current version of software
		/// </summary>
		public string _version = Application.ProductVersion;
		/// <summary>
		/// today
		/// </summary>
		public string _today = "June 23, 2021";

		private System.Windows.Forms.Label lblFlow;
		private System.Windows.Forms.TextBox txtFlow;
		private System.Windows.Forms.ComboBox cboFlowUnit;
		private System.Windows.Forms.ComboBox cboDepthUnit;
		private System.Windows.Forms.TextBox txtDepth;
		private System.Windows.Forms.Label lblDepth;
		private System.Windows.Forms.ComboBox cboDiameterUnit;
		private System.Windows.Forms.TextBox txtDiameter;
		private System.Windows.Forms.Label lblDiameter;
		private System.Windows.Forms.ComboBox cboSlopeUnit;
		private System.Windows.Forms.TextBox txtSlope;
		private System.Windows.Forms.Label lblSlope;
		private System.Windows.Forms.TextBox txtNValue;
		private System.Windows.Forms.Label lblNValue;
		private System.Windows.Forms.ComboBox cboVelocityUnit;
		private System.Windows.Forms.TextBox txtVelocity;
		private System.Windows.Forms.Label lblVelocity;
		private System.Windows.Forms.Button cmdCalculate;
		private System.Windows.Forms.GroupBox grpCalculate;
		private System.Windows.Forms.RadioButton rdoFlow;
		private System.Windows.Forms.RadioButton rdoDepth;
		private System.Windows.Forms.RadioButton rdoQVA;
		private System.Windows.Forms.RadioButton rdoVQA;
		private System.Windows.Forms.StatusBar statusBar;
		private System.Windows.Forms.MenuItem mnuFile;
		private System.Windows.Forms.MenuItem mnuHelp;
		private System.Windows.Forms.MenuItem itmExit;
		private System.Windows.Forms.MainMenu mnuMain;
		private System.Windows.Forms.MenuItem itmAbout;
		private System.Windows.Forms.MenuItem itmSave;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.ToolTip toolTip;
        private ComboBox cboWettedAreaUnit;
        private TextBox txtWettedArea;
        private TextBox txtVelocityHead;
        private TextBox txtHydraulicRadius;
        private TextBox txtCriticalDepth;
        private TextBox txtWettedPerimiter;
        private Label lblWettedArea;
        private Label lblVelocityHead;
        private ComboBox cboWettedPerimiterUnit;
        private Label lblHydraulicRadius;
        private ComboBox cboCriticalDepthUnit;
        private Label lblCriticalDepth;
        private Label lblWettedPerimiter;
        private TextBox txtPipeCapacity;
        private ComboBox cboPipeCapacityUnit;
        private Label lblPipeCapacity;
        private ComboBox cboVelocityHeadUnit;
        private ComboBox cbodDUnits;
        private TextBox txtdD;
        private Label lbldD;
        private ComboBox cboHydraulicRadiusUnit;
        private ComboBox cboQCapUnit;
        private TextBox txtQCap;
        private Label lblQCap;
        private TextBox txtTheta;
        private Label lblTheta;
        private ComboBox cboNValue;
        private ToolStripMenuItem dDToolStripMenuItem25;
        private ToolStripMenuItem dDToolStripMenuItem50;
        private ToolStripMenuItem dDToolStripMenuItem70;
        private ToolStripMenuItem dDToolStripMenuItem75;
        private ToolStripMenuItem dDToolStripMenuItem92;
        private ToolStripMenuItem dDToolStripMenuItem100;
        internal ContextMenuStrip contextMenudD;
        private System.ComponentModel.IContainer components;

		public frmHydCalc()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			rdoFlow.Checked = true;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHydCalc));
            this.lblFlow = new System.Windows.Forms.Label();
            this.txtFlow = new System.Windows.Forms.TextBox();
            this.cboFlowUnit = new System.Windows.Forms.ComboBox();
            this.cboDepthUnit = new System.Windows.Forms.ComboBox();
            this.txtDepth = new System.Windows.Forms.TextBox();
            this.lblDepth = new System.Windows.Forms.Label();
            this.cboDiameterUnit = new System.Windows.Forms.ComboBox();
            this.txtDiameter = new System.Windows.Forms.TextBox();
            this.lblDiameter = new System.Windows.Forms.Label();
            this.cboSlopeUnit = new System.Windows.Forms.ComboBox();
            this.txtSlope = new System.Windows.Forms.TextBox();
            this.lblSlope = new System.Windows.Forms.Label();
            this.txtNValue = new System.Windows.Forms.TextBox();
            this.lblNValue = new System.Windows.Forms.Label();
            this.cboVelocityUnit = new System.Windows.Forms.ComboBox();
            this.txtVelocity = new System.Windows.Forms.TextBox();
            this.lblVelocity = new System.Windows.Forms.Label();
            this.cmdCalculate = new System.Windows.Forms.Button();
            this.grpCalculate = new System.Windows.Forms.GroupBox();
            this.rdoVQA = new System.Windows.Forms.RadioButton();
            this.rdoDepth = new System.Windows.Forms.RadioButton();
            this.rdoFlow = new System.Windows.Forms.RadioButton();
            this.rdoQVA = new System.Windows.Forms.RadioButton();
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.mnuMain = new System.Windows.Forms.MainMenu(this.components);
            this.mnuFile = new System.Windows.Forms.MenuItem();
            this.itmSave = new System.Windows.Forms.MenuItem();
            this.itmExit = new System.Windows.Forms.MenuItem();
            this.mnuHelp = new System.Windows.Forms.MenuItem();
            this.itmAbout = new System.Windows.Forms.MenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cboWettedAreaUnit = new System.Windows.Forms.ComboBox();
            this.txtWettedArea = new System.Windows.Forms.TextBox();
            this.txtVelocityHead = new System.Windows.Forms.TextBox();
            this.txtHydraulicRadius = new System.Windows.Forms.TextBox();
            this.txtCriticalDepth = new System.Windows.Forms.TextBox();
            this.txtWettedPerimiter = new System.Windows.Forms.TextBox();
            this.cboWettedPerimiterUnit = new System.Windows.Forms.ComboBox();
            this.cboCriticalDepthUnit = new System.Windows.Forms.ComboBox();
            this.txtPipeCapacity = new System.Windows.Forms.TextBox();
            this.cboPipeCapacityUnit = new System.Windows.Forms.ComboBox();
            this.cboVelocityHeadUnit = new System.Windows.Forms.ComboBox();
            this.cbodDUnits = new System.Windows.Forms.ComboBox();
            this.txtdD = new System.Windows.Forms.TextBox();
            this.cboHydraulicRadiusUnit = new System.Windows.Forms.ComboBox();
            this.cboQCapUnit = new System.Windows.Forms.ComboBox();
            this.txtQCap = new System.Windows.Forms.TextBox();
            this.txtTheta = new System.Windows.Forms.TextBox();
            this.cboNValue = new System.Windows.Forms.ComboBox();
            this.lblWettedArea = new System.Windows.Forms.Label();
            this.lblVelocityHead = new System.Windows.Forms.Label();
            this.lblHydraulicRadius = new System.Windows.Forms.Label();
            this.lblCriticalDepth = new System.Windows.Forms.Label();
            this.lblWettedPerimiter = new System.Windows.Forms.Label();
            this.lblPipeCapacity = new System.Windows.Forms.Label();
            this.lbldD = new System.Windows.Forms.Label();
            this.lblQCap = new System.Windows.Forms.Label();
            this.lblTheta = new System.Windows.Forms.Label();
            this.dDToolStripMenuItem25 = new System.Windows.Forms.ToolStripMenuItem();
            this.dDToolStripMenuItem50 = new System.Windows.Forms.ToolStripMenuItem();
            this.dDToolStripMenuItem70 = new System.Windows.Forms.ToolStripMenuItem();
            this.dDToolStripMenuItem75 = new System.Windows.Forms.ToolStripMenuItem();
            this.dDToolStripMenuItem92 = new System.Windows.Forms.ToolStripMenuItem();
            this.dDToolStripMenuItem100 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenudD = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grpCalculate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            this.contextMenudD.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFlow
            // 
            this.lblFlow.Location = new System.Drawing.Point(15, 60);
            this.lblFlow.Name = "lblFlow";
            this.lblFlow.Size = new System.Drawing.Size(40, 20);
            this.lblFlow.TabIndex = 0;
            this.lblFlow.Text = "Flow :";
            // 
            // txtFlow
            // 
            this.txtFlow.Enabled = false;
            this.txtFlow.Location = new System.Drawing.Point(65, 60);
            this.txtFlow.MaxLength = 10;
            this.txtFlow.Name = "txtFlow";
            this.txtFlow.Size = new System.Drawing.Size(65, 20);
            this.txtFlow.TabIndex = 1;
            this.txtFlow.Text = "0.0";
            this.toolTip.SetToolTip(this.txtFlow, "Flow");
            this.txtFlow.TextChanged += new System.EventHandler(this.txtFlow_TextChanged);
            // 
            // cboFlowUnit
            // 
            this.cboFlowUnit.Items.AddRange(new object[] {
            "mgd",
            "gpm",
            "gpd",
            "cfs",
            "cms",
            "lps"});
            this.cboFlowUnit.Location = new System.Drawing.Point(139, 60);
            this.cboFlowUnit.Name = "cboFlowUnit";
            this.cboFlowUnit.Size = new System.Drawing.Size(45, 21);
            this.cboFlowUnit.TabIndex = 2;
            this.cboFlowUnit.Text = "mgd";
            this.toolTip.SetToolTip(this.cboFlowUnit, "Units for Flow");
            this.cboFlowUnit.SelectedValueChanged += new System.EventHandler(this.cboFlowUnit_SelectedValueChanged);
            // 
            // cboDepthUnit
            // 
            this.cboDepthUnit.Items.AddRange(new object[] {
            "inch",
            "ft",
            "m",
            "cm",
            "mm"});
            this.cboDepthUnit.Location = new System.Drawing.Point(139, 90);
            this.cboDepthUnit.Name = "cboDepthUnit";
            this.cboDepthUnit.Size = new System.Drawing.Size(45, 21);
            this.cboDepthUnit.TabIndex = 5;
            this.cboDepthUnit.Text = "inch";
            this.toolTip.SetToolTip(this.cboDepthUnit, "Units for Depth");
            this.cboDepthUnit.SelectedValueChanged += new System.EventHandler(this.cboDepthUnit_SelectedValueChanged);
            // 
            // txtDepth
            // 
            this.txtDepth.Location = new System.Drawing.Point(65, 90);
            this.txtDepth.MaxLength = 10;
            this.txtDepth.Name = "txtDepth";
            this.txtDepth.Size = new System.Drawing.Size(65, 20);
            this.txtDepth.TabIndex = 4;
            this.toolTip.SetToolTip(this.txtDepth, "Depth");
            this.txtDepth.TextChanged += new System.EventHandler(this.txtDepth_TextChanged);
            this.txtDepth.DoubleClick += new System.EventHandler(this.txtDepth_DoubleClick);
            // 
            // lblDepth
            // 
            this.lblDepth.Location = new System.Drawing.Point(15, 90);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Size = new System.Drawing.Size(46, 20);
            this.lblDepth.TabIndex = 3;
            this.lblDepth.Text = "Depth :";
            this.lblDepth.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblDepth_MouseClick);
            // 
            // cboDiameterUnit
            // 
            this.cboDiameterUnit.Items.AddRange(new object[] {
            "inch",
            "ft",
            "m",
            "cm",
            "mm"});
            this.cboDiameterUnit.Location = new System.Drawing.Point(139, 150);
            this.cboDiameterUnit.Name = "cboDiameterUnit";
            this.cboDiameterUnit.Size = new System.Drawing.Size(45, 21);
            this.cboDiameterUnit.TabIndex = 11;
            this.cboDiameterUnit.Text = "inch";
            this.toolTip.SetToolTip(this.cboDiameterUnit, "Units for Diameter");
            this.cboDiameterUnit.SelectedValueChanged += new System.EventHandler(this.cboDiameterUnit_SelectedValueChanged);
            // 
            // txtDiameter
            // 
            this.txtDiameter.Location = new System.Drawing.Point(65, 150);
            this.txtDiameter.MaxLength = 10;
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.Size = new System.Drawing.Size(65, 20);
            this.txtDiameter.TabIndex = 10;
            this.toolTip.SetToolTip(this.txtDiameter, "Pipe Diameter");
            this.txtDiameter.TextChanged += new System.EventHandler(this.txtDiameter_TextChanged);
            // 
            // lblDiameter
            // 
            this.lblDiameter.Location = new System.Drawing.Point(15, 150);
            this.lblDiameter.Name = "lblDiameter";
            this.lblDiameter.Size = new System.Drawing.Size(57, 20);
            this.lblDiameter.TabIndex = 9;
            this.lblDiameter.Text = "Diameter :";
            // 
            // cboSlopeUnit
            // 
            this.cboSlopeUnit.Items.AddRange(new object[] {
            "ft/ft",
            "%",
            "m/m"});
            this.cboSlopeUnit.Location = new System.Drawing.Point(139, 180);
            this.cboSlopeUnit.Name = "cboSlopeUnit";
            this.cboSlopeUnit.Size = new System.Drawing.Size(45, 21);
            this.cboSlopeUnit.TabIndex = 14;
            this.cboSlopeUnit.Text = "ft/ft";
            this.toolTip.SetToolTip(this.cboSlopeUnit, "Units for Slope");
            this.cboSlopeUnit.SelectedValueChanged += new System.EventHandler(this.cboSlopeUnit_SelectedValueChanged);
            // 
            // txtSlope
            // 
            this.txtSlope.Location = new System.Drawing.Point(65, 180);
            this.txtSlope.MaxLength = 10;
            this.txtSlope.Name = "txtSlope";
            this.txtSlope.Size = new System.Drawing.Size(65, 20);
            this.txtSlope.TabIndex = 13;
            this.toolTip.SetToolTip(this.txtSlope, "Slope");
            this.txtSlope.TextChanged += new System.EventHandler(this.txtSlope_TextChanged);
            // 
            // lblSlope
            // 
            this.lblSlope.Location = new System.Drawing.Point(15, 180);
            this.lblSlope.Name = "lblSlope";
            this.lblSlope.Size = new System.Drawing.Size(40, 23);
            this.lblSlope.TabIndex = 12;
            this.lblSlope.Text = "Slope :";
            // 
            // txtNValue
            // 
            this.txtNValue.Location = new System.Drawing.Point(65, 210);
            this.txtNValue.MaxLength = 6;
            this.txtNValue.Name = "txtNValue";
            this.txtNValue.Size = new System.Drawing.Size(65, 20);
            this.txtNValue.TabIndex = 16;
            this.txtNValue.Text = "0.013";
            this.toolTip.SetToolTip(this.txtNValue, "Manning\'s N-Value");
            this.txtNValue.TextChanged += new System.EventHandler(this.txtNValue_TextChanged);
            // 
            // lblNValue
            // 
            this.lblNValue.Location = new System.Drawing.Point(15, 210);
            this.lblNValue.Name = "lblNValue";
            this.lblNValue.Size = new System.Drawing.Size(57, 20);
            this.lblNValue.TabIndex = 15;
            this.lblNValue.Text = "N Value :";
            // 
            // cboVelocityUnit
            // 
            this.cboVelocityUnit.Items.AddRange(new object[] {
            "fps",
            "mps"});
            this.cboVelocityUnit.Location = new System.Drawing.Point(139, 120);
            this.cboVelocityUnit.Name = "cboVelocityUnit";
            this.cboVelocityUnit.Size = new System.Drawing.Size(45, 21);
            this.cboVelocityUnit.TabIndex = 8;
            this.cboVelocityUnit.Text = "fps";
            this.toolTip.SetToolTip(this.cboVelocityUnit, "Units for Velocity");
            this.cboVelocityUnit.SelectedValueChanged += new System.EventHandler(this.cboVelocityUnit_SelectedValueChanged);
            // 
            // txtVelocity
            // 
            this.txtVelocity.Enabled = false;
            this.txtVelocity.Location = new System.Drawing.Point(65, 120);
            this.txtVelocity.MaxLength = 10;
            this.txtVelocity.Name = "txtVelocity";
            this.txtVelocity.Size = new System.Drawing.Size(65, 20);
            this.txtVelocity.TabIndex = 7;
            this.txtVelocity.Text = "0.0";
            this.toolTip.SetToolTip(this.txtVelocity, "Velocity");
            this.txtVelocity.TextChanged += new System.EventHandler(this.txtVelocity_TextChanged);
            // 
            // lblVelocity
            // 
            this.lblVelocity.Location = new System.Drawing.Point(15, 120);
            this.lblVelocity.Name = "lblVelocity";
            this.lblVelocity.Size = new System.Drawing.Size(56, 20);
            this.lblVelocity.TabIndex = 6;
            this.lblVelocity.Text = "Velocity :";
            // 
            // cmdCalculate
            // 
            this.cmdCalculate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdCalculate.Location = new System.Drawing.Point(90, 403);
            this.cmdCalculate.Name = "cmdCalculate";
            this.cmdCalculate.Size = new System.Drawing.Size(75, 23);
            this.cmdCalculate.TabIndex = 17;
            this.cmdCalculate.Text = "Calculate";
            this.toolTip.SetToolTip(this.cmdCalculate, "Calculate Required Values");
            this.cmdCalculate.Click += new System.EventHandler(this.cmdCalculate_Click);
            // 
            // grpCalculate
            // 
            this.grpCalculate.Controls.Add(this.rdoVQA);
            this.grpCalculate.Controls.Add(this.rdoDepth);
            this.grpCalculate.Controls.Add(this.rdoFlow);
            this.grpCalculate.Controls.Add(this.rdoQVA);
            this.grpCalculate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpCalculate.Location = new System.Drawing.Point(5, 1);
            this.grpCalculate.Name = "grpCalculate";
            this.grpCalculate.Size = new System.Drawing.Size(414, 50);
            this.grpCalculate.TabIndex = 0;
            this.grpCalculate.TabStop = false;
            this.grpCalculate.Text = "Calculate";
            // 
            // rdoVQA
            // 
            this.rdoVQA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdoVQA.Location = new System.Drawing.Point(222, 19);
            this.rdoVQA.Name = "rdoVQA";
            this.rdoVQA.Size = new System.Drawing.Size(53, 24);
            this.rdoVQA.TabIndex = 3;
            this.rdoVQA.TabStop = true;
            this.rdoVQA.Text = "V=Q/A";
            this.toolTip.SetToolTip(this.rdoVQA, "Velocity = Flow / Area");
            this.rdoVQA.CheckedChanged += new System.EventHandler(this.rdoVQA_CheckedChanged);
            // 
            // rdoDepth
            // 
            this.rdoDepth.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdoDepth.Location = new System.Drawing.Point(310, 19);
            this.rdoDepth.Name = "rdoDepth";
            this.rdoDepth.Size = new System.Drawing.Size(52, 24);
            this.rdoDepth.TabIndex = 2;
            this.rdoDepth.Text = "Depth";
            this.toolTip.SetToolTip(this.rdoDepth, "Use Manning\'s Eq to Calculate Depth");
            this.rdoDepth.CheckedChanged += new System.EventHandler(this.rdoDepth_CheckedChanged);
            // 
            // rdoFlow
            // 
            this.rdoFlow.Checked = true;
            this.rdoFlow.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdoFlow.Location = new System.Drawing.Point(52, 19);
            this.rdoFlow.Name = "rdoFlow";
            this.rdoFlow.Size = new System.Drawing.Size(46, 24);
            this.rdoFlow.TabIndex = 0;
            this.rdoFlow.TabStop = true;
            this.rdoFlow.Text = "Flow";
            this.toolTip.SetToolTip(this.rdoFlow, "Use Manning\'s Eq to Calculate Flow");
            this.rdoFlow.CheckedChanged += new System.EventHandler(this.rdoFlow_CheckedChanged);
            // 
            // rdoQVA
            // 
            this.rdoQVA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdoQVA.Location = new System.Drawing.Point(133, 19);
            this.rdoQVA.Name = "rdoQVA";
            this.rdoQVA.Size = new System.Drawing.Size(54, 24);
            this.rdoQVA.TabIndex = 1;
            this.rdoQVA.TabStop = true;
            this.rdoQVA.Text = "Q=V*A";
            this.toolTip.SetToolTip(this.rdoQVA, "Flow = Velocity x Area");
            this.rdoQVA.CheckedChanged += new System.EventHandler(this.rdoQVA_CheckedChanged);
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 269);
            this.statusBar.Name = "statusBar";
            this.statusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1});
            this.statusBar.Size = new System.Drawing.Size(432, 24);
            this.statusBar.SizingGrip = false;
            this.statusBar.TabIndex = 18;
            this.statusBar.Text = "Calc: Flow & Vel - Given: Depth, Diam, Slope, & N";
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Style = System.Windows.Forms.StatusBarPanelStyle.OwnerDraw;
            this.statusBarPanel1.Text = "statusBarPanel1";
            // 
            // mnuMain
            // 
            this.mnuMain.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFile,
            this.mnuHelp});
            // 
            // mnuFile
            // 
            this.mnuFile.Index = 0;
            this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.itmSave,
            this.itmExit});
            this.mnuFile.Text = "&File";
            // 
            // itmSave
            // 
            this.itmSave.Index = 0;
            this.itmSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.itmSave.Text = "&Save";
            this.itmSave.Click += new System.EventHandler(this.itmSave_Click);
            // 
            // itmExit
            // 
            this.itmExit.Index = 1;
            this.itmExit.Text = "E&xit";
            this.itmExit.Click += new System.EventHandler(this.itmExit_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Index = 1;
            this.mnuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.itmAbout});
            this.mnuHelp.Text = "&Help";
            // 
            // itmAbout
            // 
            this.itmAbout.Index = 0;
            this.itmAbout.Text = "About Hydraulic Calculator...";
            this.itmAbout.Click += new System.EventHandler(this.itmAbout_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "csv";
            this.saveFileDialog.FileName = "ManningCalc.csv";
            this.saveFileDialog.Filter = "CSV Text File (*.csv)|*.csv";
            this.saveFileDialog.Title = "Save data to CSV";
            // 
            // cboWettedAreaUnit
            // 
            this.cboWettedAreaUnit.Items.AddRange(new object[] {
            "in2",
            "ft2",
            "m2"});
            this.cboWettedAreaUnit.Location = new System.Drawing.Point(376, 89);
            this.cboWettedAreaUnit.Name = "cboWettedAreaUnit";
            this.cboWettedAreaUnit.Size = new System.Drawing.Size(45, 21);
            this.cboWettedAreaUnit.TabIndex = 27;
            this.cboWettedAreaUnit.Text = "ft2";
            this.toolTip.SetToolTip(this.cboWettedAreaUnit, "Units for Velocity");
            this.cboWettedAreaUnit.SelectedValueChanged += new System.EventHandler(this.cboWettedAreaUnit_SelectedValueChanged);
            // 
            // txtWettedArea
            // 
            this.txtWettedArea.Location = new System.Drawing.Point(301, 89);
            this.txtWettedArea.MaxLength = 10;
            this.txtWettedArea.Name = "txtWettedArea";
            this.txtWettedArea.ReadOnly = true;
            this.txtWettedArea.Size = new System.Drawing.Size(65, 20);
            this.txtWettedArea.TabIndex = 26;
            this.txtWettedArea.Text = "0.0";
            this.toolTip.SetToolTip(this.txtWettedArea, "Velocity");
            // 
            // txtVelocityHead
            // 
            this.txtVelocityHead.Location = new System.Drawing.Point(301, 147);
            this.txtVelocityHead.MaxLength = 10;
            this.txtVelocityHead.Name = "txtVelocityHead";
            this.txtVelocityHead.ReadOnly = true;
            this.txtVelocityHead.Size = new System.Drawing.Size(65, 20);
            this.txtVelocityHead.TabIndex = 32;
            this.txtVelocityHead.Text = "0.0";
            this.toolTip.SetToolTip(this.txtVelocityHead, "Slope");
            // 
            // txtHydraulicRadius
            // 
            this.txtHydraulicRadius.Location = new System.Drawing.Point(301, 119);
            this.txtHydraulicRadius.MaxLength = 10;
            this.txtHydraulicRadius.Name = "txtHydraulicRadius";
            this.txtHydraulicRadius.ReadOnly = true;
            this.txtHydraulicRadius.Size = new System.Drawing.Size(65, 20);
            this.txtHydraulicRadius.TabIndex = 29;
            this.txtHydraulicRadius.Text = "0.0";
            this.toolTip.SetToolTip(this.txtHydraulicRadius, "Pipe Diameter");
            // 
            // txtCriticalDepth
            // 
            this.txtCriticalDepth.Location = new System.Drawing.Point(300, 361);
            this.txtCriticalDepth.MaxLength = 10;
            this.txtCriticalDepth.Name = "txtCriticalDepth";
            this.txtCriticalDepth.ReadOnly = true;
            this.txtCriticalDepth.Size = new System.Drawing.Size(65, 20);
            this.txtCriticalDepth.TabIndex = 23;
            this.txtCriticalDepth.Text = "0.0";
            this.toolTip.SetToolTip(this.txtCriticalDepth, "Depth");
            // 
            // txtWettedPerimiter
            // 
            this.txtWettedPerimiter.Location = new System.Drawing.Point(301, 60);
            this.txtWettedPerimiter.MaxLength = 10;
            this.txtWettedPerimiter.Name = "txtWettedPerimiter";
            this.txtWettedPerimiter.ReadOnly = true;
            this.txtWettedPerimiter.Size = new System.Drawing.Size(65, 20);
            this.txtWettedPerimiter.TabIndex = 20;
            this.txtWettedPerimiter.Text = "0.0";
            this.toolTip.SetToolTip(this.txtWettedPerimiter, "Flow");
            // 
            // cboWettedPerimiterUnit
            // 
            this.cboWettedPerimiterUnit.Items.AddRange(new object[] {
            "inch",
            "ft",
            "m",
            "cm",
            "mm"});
            this.cboWettedPerimiterUnit.Location = new System.Drawing.Point(376, 60);
            this.cboWettedPerimiterUnit.Name = "cboWettedPerimiterUnit";
            this.cboWettedPerimiterUnit.Size = new System.Drawing.Size(45, 21);
            this.cboWettedPerimiterUnit.TabIndex = 30;
            this.cboWettedPerimiterUnit.Text = "ft";
            this.toolTip.SetToolTip(this.cboWettedPerimiterUnit, "Units for Diameter");
            this.cboWettedPerimiterUnit.SelectedValueChanged += new System.EventHandler(this.cboWettedPerimiterUnit_SelectedValueChanged);
            // 
            // cboCriticalDepthUnit
            // 
            this.cboCriticalDepthUnit.Items.AddRange(new object[] {
            "inch",
            "ft",
            "m",
            "cm",
            "mm"});
            this.cboCriticalDepthUnit.Location = new System.Drawing.Point(375, 361);
            this.cboCriticalDepthUnit.Name = "cboCriticalDepthUnit";
            this.cboCriticalDepthUnit.Size = new System.Drawing.Size(45, 21);
            this.cboCriticalDepthUnit.TabIndex = 24;
            this.cboCriticalDepthUnit.Text = "inch";
            this.toolTip.SetToolTip(this.cboCriticalDepthUnit, "Units for Depth");
            this.cboCriticalDepthUnit.SelectedValueChanged += new System.EventHandler(this.cboCriticalDepthUnit_SelectedValueChanged);
            // 
            // txtPipeCapacity
            // 
            this.txtPipeCapacity.Location = new System.Drawing.Point(300, 177);
            this.txtPipeCapacity.MaxLength = 10;
            this.txtPipeCapacity.Name = "txtPipeCapacity";
            this.txtPipeCapacity.ReadOnly = true;
            this.txtPipeCapacity.Size = new System.Drawing.Size(65, 20);
            this.txtPipeCapacity.TabIndex = 35;
            this.txtPipeCapacity.Text = "0.0";
            this.toolTip.SetToolTip(this.txtPipeCapacity, "Flow");
            // 
            // cboPipeCapacityUnit
            // 
            this.cboPipeCapacityUnit.Items.AddRange(new object[] {
            "mgd",
            "gpm",
            "gpd",
            "cfs",
            "cms",
            "lps"});
            this.cboPipeCapacityUnit.Location = new System.Drawing.Point(375, 177);
            this.cboPipeCapacityUnit.Name = "cboPipeCapacityUnit";
            this.cboPipeCapacityUnit.Size = new System.Drawing.Size(45, 21);
            this.cboPipeCapacityUnit.TabIndex = 36;
            this.cboPipeCapacityUnit.Text = "mgd";
            this.toolTip.SetToolTip(this.cboPipeCapacityUnit, "Units for Flow");
            this.cboPipeCapacityUnit.SelectedValueChanged += new System.EventHandler(this.cboPipeCapacityUnit_SelectedValueChanged);
            // 
            // cboVelocityHeadUnit
            // 
            this.cboVelocityHeadUnit.Items.AddRange(new object[] {
            "inch",
            "ft",
            "m",
            "cm",
            "mm"});
            this.cboVelocityHeadUnit.Location = new System.Drawing.Point(375, 147);
            this.cboVelocityHeadUnit.Name = "cboVelocityHeadUnit";
            this.cboVelocityHeadUnit.Size = new System.Drawing.Size(45, 21);
            this.cboVelocityHeadUnit.TabIndex = 37;
            this.cboVelocityHeadUnit.Text = "inch";
            this.toolTip.SetToolTip(this.cboVelocityHeadUnit, "Units for Depth");
            this.cboVelocityHeadUnit.SelectedValueChanged += new System.EventHandler(this.cboVelocityHeadUnit_SelectedValueChanged);
            // 
            // cbodDUnits
            // 
            this.cbodDUnits.Items.AddRange(new object[] {
            "%"});
            this.cbodDUnits.Location = new System.Drawing.Point(375, 209);
            this.cbodDUnits.Name = "cbodDUnits";
            this.cbodDUnits.Size = new System.Drawing.Size(45, 21);
            this.cbodDUnits.TabIndex = 40;
            this.cbodDUnits.Text = "%";
            this.toolTip.SetToolTip(this.cbodDUnits, "Units for Depth");
            // 
            // txtdD
            // 
            this.txtdD.Location = new System.Drawing.Point(301, 209);
            this.txtdD.MaxLength = 10;
            this.txtdD.Name = "txtdD";
            this.txtdD.ReadOnly = true;
            this.txtdD.Size = new System.Drawing.Size(65, 20);
            this.txtdD.TabIndex = 39;
            this.txtdD.Text = "0.0";
            this.toolTip.SetToolTip(this.txtdD, "Slope");
            // 
            // cboHydraulicRadiusUnit
            // 
            this.cboHydraulicRadiusUnit.Items.AddRange(new object[] {
            "inch",
            "ft",
            "m",
            "cm",
            "mm"});
            this.cboHydraulicRadiusUnit.Location = new System.Drawing.Point(375, 119);
            this.cboHydraulicRadiusUnit.Name = "cboHydraulicRadiusUnit";
            this.cboHydraulicRadiusUnit.Size = new System.Drawing.Size(45, 21);
            this.cboHydraulicRadiusUnit.TabIndex = 41;
            this.cboHydraulicRadiusUnit.Text = "ft";
            this.toolTip.SetToolTip(this.cboHydraulicRadiusUnit, "Units for Diameter");
            this.cboHydraulicRadiusUnit.SelectedValueChanged += new System.EventHandler(this.cboHydraulicRadiusUnit_SelectedValueChanged);
            // 
            // cboQCapUnit
            // 
            this.cboQCapUnit.Items.AddRange(new object[] {
            "%"});
            this.cboQCapUnit.Location = new System.Drawing.Point(375, 238);
            this.cboQCapUnit.Name = "cboQCapUnit";
            this.cboQCapUnit.Size = new System.Drawing.Size(45, 21);
            this.cboQCapUnit.TabIndex = 44;
            this.cboQCapUnit.Text = "%";
            this.toolTip.SetToolTip(this.cboQCapUnit, "Units for Depth");
            // 
            // txtQCap
            // 
            this.txtQCap.Location = new System.Drawing.Point(301, 238);
            this.txtQCap.MaxLength = 10;
            this.txtQCap.Name = "txtQCap";
            this.txtQCap.ReadOnly = true;
            this.txtQCap.Size = new System.Drawing.Size(65, 20);
            this.txtQCap.TabIndex = 43;
            this.txtQCap.Text = "0.0";
            this.toolTip.SetToolTip(this.txtQCap, "Slope");
            // 
            // txtTheta
            // 
            this.txtTheta.Location = new System.Drawing.Point(300, 324);
            this.txtTheta.MaxLength = 10;
            this.txtTheta.Name = "txtTheta";
            this.txtTheta.ReadOnly = true;
            this.txtTheta.Size = new System.Drawing.Size(65, 20);
            this.txtTheta.TabIndex = 46;
            this.txtTheta.Text = "0.0";
            this.toolTip.SetToolTip(this.txtTheta, "Slope");
            // 
            // cboNValue
            // 
            this.cboNValue.Items.AddRange(new object[] {
            "PVC",
            "Conc",
            "VC"});
            this.cboNValue.Location = new System.Drawing.Point(139, 210);
            this.cboNValue.Name = "cboNValue";
            this.cboNValue.Size = new System.Drawing.Size(45, 21);
            this.cboNValue.TabIndex = 48;
            this.cboNValue.Text = "Conc";
            this.toolTip.SetToolTip(this.cboNValue, "Units for Slope");
            this.cboNValue.SelectedValueChanged += new System.EventHandler(this.cboNValue_SelectedValueChanged);
            // 
            // lblWettedArea
            // 
            this.lblWettedArea.Location = new System.Drawing.Point(199, 89);
            this.lblWettedArea.Name = "lblWettedArea";
            this.lblWettedArea.Size = new System.Drawing.Size(97, 20);
            this.lblWettedArea.TabIndex = 25;
            this.lblWettedArea.Text = "Flow Area :";
            // 
            // lblVelocityHead
            // 
            this.lblVelocityHead.Location = new System.Drawing.Point(199, 147);
            this.lblVelocityHead.Name = "lblVelocityHead";
            this.lblVelocityHead.Size = new System.Drawing.Size(97, 20);
            this.lblVelocityHead.TabIndex = 31;
            this.lblVelocityHead.Text = "Velocity Head :";
            // 
            // lblHydraulicRadius
            // 
            this.lblHydraulicRadius.Location = new System.Drawing.Point(199, 119);
            this.lblHydraulicRadius.Name = "lblHydraulicRadius";
            this.lblHydraulicRadius.Size = new System.Drawing.Size(97, 20);
            this.lblHydraulicRadius.TabIndex = 28;
            this.lblHydraulicRadius.Text = "Hydraulic Radius :";
            // 
            // lblCriticalDepth
            // 
            this.lblCriticalDepth.Location = new System.Drawing.Point(199, 361);
            this.lblCriticalDepth.Name = "lblCriticalDepth";
            this.lblCriticalDepth.Size = new System.Drawing.Size(97, 20);
            this.lblCriticalDepth.TabIndex = 22;
            this.lblCriticalDepth.Text = "Critical Depth :";
            // 
            // lblWettedPerimiter
            // 
            this.lblWettedPerimiter.Location = new System.Drawing.Point(199, 60);
            this.lblWettedPerimiter.Name = "lblWettedPerimiter";
            this.lblWettedPerimiter.Size = new System.Drawing.Size(103, 20);
            this.lblWettedPerimiter.TabIndex = 19;
            this.lblWettedPerimiter.Text = "Wetted Perimeter :";
            // 
            // lblPipeCapacity
            // 
            this.lblPipeCapacity.Location = new System.Drawing.Point(198, 177);
            this.lblPipeCapacity.Name = "lblPipeCapacity";
            this.lblPipeCapacity.Size = new System.Drawing.Size(97, 20);
            this.lblPipeCapacity.TabIndex = 34;
            this.lblPipeCapacity.Text = "Pipe Capacity :";
            // 
            // lbldD
            // 
            this.lbldD.Location = new System.Drawing.Point(199, 209);
            this.lbldD.Name = "lbldD";
            this.lbldD.Size = new System.Drawing.Size(97, 20);
            this.lbldD.TabIndex = 38;
            this.lbldD.Text = "d/D :";
            // 
            // lblQCap
            // 
            this.lblQCap.Location = new System.Drawing.Point(199, 238);
            this.lblQCap.Name = "lblQCap";
            this.lblQCap.Size = new System.Drawing.Size(97, 20);
            this.lblQCap.TabIndex = 42;
            this.lblQCap.Text = "Q/Cap :";
            // 
            // lblTheta
            // 
            this.lblTheta.Location = new System.Drawing.Point(199, 324);
            this.lblTheta.Name = "lblTheta";
            this.lblTheta.Size = new System.Drawing.Size(97, 20);
            this.lblTheta.TabIndex = 45;
            this.lblTheta.Text = "Theta :";
            // 
            // dDToolStripMenuItem25
            // 
            this.dDToolStripMenuItem25.Name = "dDToolStripMenuItem25";
            this.dDToolStripMenuItem25.Size = new System.Drawing.Size(100, 22);
            this.dDToolStripMenuItem25.Text = "25% d/D";
            this.dDToolStripMenuItem25.Click += new System.EventHandler(this.dDToolStripMenuItem25_Click);
            // 
            // dDToolStripMenuItem50
            // 
            this.dDToolStripMenuItem50.Name = "dDToolStripMenuItem50";
            this.dDToolStripMenuItem50.Size = new System.Drawing.Size(100, 22);
            this.dDToolStripMenuItem50.Text = "50% d/D";
            this.dDToolStripMenuItem50.Click += new System.EventHandler(this.dDToolStripMenuItem50_Click);
            // 
            // dDToolStripMenuItem70
            // 
            this.dDToolStripMenuItem70.Name = "dDToolStripMenuItem70";
            this.dDToolStripMenuItem70.Size = new System.Drawing.Size(100, 22);
            this.dDToolStripMenuItem70.Text = "70% d/D";
            this.dDToolStripMenuItem70.Click += new System.EventHandler(this.dDToolStripMenuItem70_Click);
            // 
            // dDToolStripMenuItem75
            // 
            this.dDToolStripMenuItem75.Name = "dDToolStripMenuItem75";
            this.dDToolStripMenuItem75.Size = new System.Drawing.Size(100, 22);
            this.dDToolStripMenuItem75.Text = "75% d/D";
            this.dDToolStripMenuItem75.Click += new System.EventHandler(this.dDToolStripMenuItem75_Click);
            // 
            // dDToolStripMenuItem92
            // 
            this.dDToolStripMenuItem92.Name = "dDToolStripMenuItem92";
            this.dDToolStripMenuItem92.Size = new System.Drawing.Size(100, 22);
            this.dDToolStripMenuItem92.Text = "92% d/D";
            this.dDToolStripMenuItem92.Click += new System.EventHandler(this.dDToolStripMenuItem92_Click);
            // 
            // dDToolStripMenuItem100
            // 
            this.dDToolStripMenuItem100.Name = "dDToolStripMenuItem100";
            this.dDToolStripMenuItem100.Size = new System.Drawing.Size(100, 22);
            this.dDToolStripMenuItem100.Text = "100% d/D";
            this.dDToolStripMenuItem100.Click += new System.EventHandler(this.dDToolStripMenuItem100_Click);
            // 
            // contextMenudD
            // 
            this.contextMenudD.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.contextMenudD.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dDToolStripMenuItem25,
            this.dDToolStripMenuItem50,
            this.dDToolStripMenuItem70,
            this.dDToolStripMenuItem75,
            this.dDToolStripMenuItem92,
            this.dDToolStripMenuItem100});
            this.contextMenudD.Name = "contextMenudD";
            this.contextMenudD.ShowImageMargin = false;
            this.contextMenudD.Size = new System.Drawing.Size(101, 136);
            // 
            // frmHydCalc
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.AllowDrop = true;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(432, 293);
            this.Controls.Add(this.cboNValue);
            this.Controls.Add(this.txtTheta);
            this.Controls.Add(this.lblTheta);
            this.Controls.Add(this.cboQCapUnit);
            this.Controls.Add(this.txtQCap);
            this.Controls.Add(this.lblQCap);
            this.Controls.Add(this.cboHydraulicRadiusUnit);
            this.Controls.Add(this.cbodDUnits);
            this.Controls.Add(this.txtdD);
            this.Controls.Add(this.lbldD);
            this.Controls.Add(this.cboVelocityHeadUnit);
            this.Controls.Add(this.txtPipeCapacity);
            this.Controls.Add(this.cboPipeCapacityUnit);
            this.Controls.Add(this.lblPipeCapacity);
            this.Controls.Add(this.cboWettedAreaUnit);
            this.Controls.Add(this.txtWettedArea);
            this.Controls.Add(this.txtVelocityHead);
            this.Controls.Add(this.txtHydraulicRadius);
            this.Controls.Add(this.txtCriticalDepth);
            this.Controls.Add(this.txtWettedPerimiter);
            this.Controls.Add(this.lblWettedArea);
            this.Controls.Add(this.lblVelocityHead);
            this.Controls.Add(this.cboWettedPerimiterUnit);
            this.Controls.Add(this.lblHydraulicRadius);
            this.Controls.Add(this.cboCriticalDepthUnit);
            this.Controls.Add(this.lblCriticalDepth);
            this.Controls.Add(this.lblWettedPerimiter);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.grpCalculate);
            this.Controls.Add(this.cmdCalculate);
            this.Controls.Add(this.cboVelocityUnit);
            this.Controls.Add(this.txtVelocity);
            this.Controls.Add(this.txtNValue);
            this.Controls.Add(this.txtSlope);
            this.Controls.Add(this.txtDiameter);
            this.Controls.Add(this.txtDepth);
            this.Controls.Add(this.txtFlow);
            this.Controls.Add(this.lblVelocity);
            this.Controls.Add(this.lblNValue);
            this.Controls.Add(this.cboSlopeUnit);
            this.Controls.Add(this.lblSlope);
            this.Controls.Add(this.cboDiameterUnit);
            this.Controls.Add(this.lblDiameter);
            this.Controls.Add(this.cboDepthUnit);
            this.Controls.Add(this.lblDepth);
            this.Controls.Add(this.cboFlowUnit);
            this.Controls.Add(this.lblFlow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmHydCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hydraulic Calculator";
            this.Load += new System.EventHandler(this.frmHydCalc_Load);
            this.DoubleClick += new System.EventHandler(this.frmHydCalc_DoubleClick);
            this.grpCalculate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            this.contextMenudD.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.EnableVisualStyles();
			Application.DoEvents();
			Application.Run(new frmHydCalc());
		}

		///<summary>
		///Uses Mannings equation to calculate required field
		///</summary>
		///<remarks>
		///Depending on radio buttons and inputed 
		///information will calculate required fields
		///in the requested units.
		///</remarks>
		private void cmdCalculate_Click(object sender, System.EventArgs e)
		{
            Calculate();
        }
        public void Calculate()
        {
			Pipe newPipe = new Pipe();
			HydConversion conversion = new HydConversion();

			try
			{
				this.Cursor = Cursors.WaitCursor;

				//Save values from form
				newPipe.Flow = double.Parse(txtFlow.Text);
				newPipe.Depth = double.Parse(txtDepth.Text);
				newPipe.Diameter = double.Parse(txtDiameter.Text);
				newPipe.Velocity = double.Parse(txtVelocity.Text);
				newPipe.Slope = double.Parse(txtSlope.Text);
				newPipe.Nvalue = double.Parse(txtNValue.Text);

				//Convert units to cfs, feet, fps, and ft/ft as needed
				newPipe.Flow = newPipe.Flow * conversion.GetFactor(cboFlowUnit.Text, "cfs");
				newPipe.Depth = newPipe.Depth * conversion.GetFactor(cboDepthUnit.Text, "ft");
				newPipe.Diameter = newPipe.Diameter * conversion.GetFactor(cboDiameterUnit.Text, "ft");
				newPipe.Velocity = newPipe.Velocity * conversion.GetFactor(cboVelocityUnit.Text, "fps");

				if (cboSlopeUnit.Text == "%")
					newPipe.Slope = newPipe.Slope / 100;

				//Determine which fuction to run and convert units as needed
				statusBar.Text = "Calculating...";
				if (rdoFlow.Checked)           //Calculate Flow
				{
					newPipe.QManning();

                    //Convert Units & Update form
                    txtFlow.Text = (newPipe.Flow * conversion.GetFactor("cfs", cboFlowUnit.Text)).ToString("#,##0.0000");
					txtVelocity.Text = (newPipe.Velocity * conversion.GetFactor("fps", cboVelocityUnit.Text)).ToString("#,##0.0000");

                    txtPipeCapacity.Text = (newPipe.Capacity * conversion.GetFactor("cfs", cboPipeCapacityUnit.Text)).ToString("#,##0.0000");

                }
				else if (rdoQVA.Checked)
				{
					newPipe.QVA();

                    //Convert Units & Update form
                    txtFlow.Text = (newPipe.Flow * conversion.GetFactor("cfs", cboFlowUnit.Text)).ToString("#,##0.0000");
                    
                    txtPipeCapacity.Text = "NA";
                }
				else if (rdoDepth.Checked)       //Calculate Depth
				{
					statusBar.Text = "Calculating... This could take awhile.";

					newPipe.DManning();
                    
                    //Convert Units & Update form
                    txtDepth.Text = (newPipe.Depth * conversion.GetFactor("ft", cboDepthUnit.Text)).ToString("#,##0.0000");
                    txtVelocity.Text = (newPipe.Velocity * conversion.GetFactor("fps", cboVelocityUnit.Text)).ToString("#,##0.0000");

                    txtPipeCapacity.Text = (newPipe.Capacity * conversion.GetFactor("cfs", cboPipeCapacityUnit.Text)).ToString("#,##0.0000");
                }
                else if (rdoVQA.Checked)          //Calculate velocity
				{
					newPipe.VQA();

                    //Convert Units & Update form
                    txtVelocity.Text = (newPipe.Velocity * conversion.GetFactor("fps", cboVelocityUnit.Text)).ToString("#,##0.0000");

                    txtPipeCapacity.Text = "NA";
                }
				this.Cursor = Cursors.Default;
				statusBar.Text = "Completed!";
			}
			catch
			{
				statusBar.Text = " - * -  ERROR  - * -";
				this.Cursor = Cursors.Default;
			}
            txtWettedArea.Text = (newPipe.WArea * conversion.GetFactor("ft2", cboWettedAreaUnit.Text)).ToString("#,##0.0000");
            txtWettedPerimiter.Text = (newPipe.WPerim * conversion.GetFactor("ft", cboWettedPerimiterUnit.Text)).ToString("#,##0.0000");
            txtHydraulicRadius.Text = (newPipe.HydraulicRadius * conversion.GetFactor("ft", cboHydraulicRadiusUnit.Text)).ToString("#,##0.0000");
            txtdD.Text = newPipe.dD.ToString("#,##0.00");
            txtVelocityHead.Text = (newPipe.VelocityHead * conversion.GetFactor("ft", cboVelocityHeadUnit.Text)).ToString("#,##0.0000");
            txtQCap.Text = newPipe.QCap.ToString("#,##0.00");
            txtTheta.Text = newPipe.Theta.ToString("#,##0.0000");
            txtCriticalDepth.Text = (newPipe.CriticalDepth * conversion.GetFactor("ft", cboCriticalDepthUnit.Text)).ToString("#,##0.0000");

            newPipe = null;
            conversion = null;
		}

        /// <summary>
        /// Remind user to recalculate if changing units.
        /// </summary>
        /// <remarks>
        /// If value was recently calculated updates status bar to remind 
        /// user to recalculate results.
        /// </remarks> 
        private void cboFlowUnit_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.statusBar.Text == "Completed!")
                this.statusBar.Text = "Please Recalculate";
            Calculate();
        }

        /// <summary>
        /// Remind user to recalculate if changing units.
        /// </summary>
        /// <remarks>
        /// If value was recently calculated updates status bar to remind 
        /// user to recalculate results.
        /// </remarks> 
        private void cboDepthUnit_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.statusBar.Text == "Completed!")
                this.statusBar.Text = "Please Recalculate";
            Calculate();
        }

        /// <summary>
        /// Remind user to recalculate if changing units.
        /// </summary>
        /// <remarks>
        /// If value was recently calculated updates status bar to remind 
        /// user to recalculate results.
        /// </remarks> 
        private void cboVelocityUnit_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.statusBar.Text == "Completed!")
                this.statusBar.Text = "Please Recalculate";
            Calculate();
        }

        /// <summary>
        /// Remind user to recalculate if changing units.
        /// </summary>
        /// <remarks>
        /// If value was recently calculated updates status bar to remind 
        /// user to recalculate results.
        /// </remarks> 
        private void cboDiameterUnit_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.statusBar.Text == "Completed!")
                this.statusBar.Text = "Please Recalculate";
            Calculate();
        }

        /// <summary>
        /// Remind user to recalculate if changing units.
        /// </summary>
        /// <remarks>
        /// If value was recently calculated updates status bar to remind 
        /// user to recalculate results.
        /// </remarks> 
        private void cboSlopeUnit_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.statusBar.Text == "Completed!")
                this.statusBar.Text = "Please Recalculate";
            Calculate();
        }

		/// <summary>
		/// Grey out Depth field and clear up Flow field
		/// </summary>
		/// <remarks>
		/// Allows user to input data into Flow field and
		/// Keeps the user from inputing data into the Depth
		/// or Velocity fields, which will be calculated.
		/// </remarks> 
		private void rdoDepth_CheckedChanged(object sender, System.EventArgs e)
		{
			if (rdoDepth.Checked)
			{
				txtDepth.Enabled = false;
				txtDepth.Text = "0.0";
				txtVelocity.Enabled = false;
				txtVelocity.Text = "0.0";
				txtFlow.Enabled = true;
				txtSlope.Enabled = true;
				txtNValue.Enabled = true;
				statusBar.Text = "Calc: Depth & Vel - Given: Flow, Diam, Slope, & N";
                Calculate();
			}
		}

		/// <summary>
		/// Grey out Flow field and clear up Depth field
		/// </summary>
		/// <remarks>
		/// Allows user to input data into Depth field and
		/// Keeps the user from inputing data into the Flow
		/// or Velocity fields, which will be calculated.
		/// </remarks>
		private void rdoFlow_CheckedChanged(object sender, System.EventArgs e)
		{		
			if (rdoFlow.Checked)
			{
				txtFlow.Enabled = false;
				txtFlow.Text = "0.0";
				txtVelocity.Enabled = false;
				txtVelocity.Text = "0.0";
				txtDepth.Enabled = true;
				txtSlope.Enabled = true;
				txtNValue.Enabled = true;
				statusBar.Text = "Calc: Flow & Vel - Given: Depth, Diam, Slope, & N";
                Calculate();
			}
		}

        /// <summary>
		/// Grey out Flow field and clear up Depth field
		/// </summary>
		/// <remarks>
		/// Allows user to input data into Velocity field and Depth field and
		/// Keeps the user from inputing data into the Flow,
		/// Slopw, NValue, or Velocity fields, which will be calculated.
		/// </remarks>
		private void rdoQVA_CheckedChanged(object sender, System.EventArgs e)
		{
			if (rdoQVA.Checked)
			{
				txtFlow.Enabled = false;
				txtFlow.Text = "0.0";
				txtSlope.Enabled = false;
				txtSlope.Text = "0.0";
				txtNValue.Enabled = false;
				txtNValue.Text = "0.013";
				txtVelocity.Enabled = true;
				txtDepth.Enabled = true;
				statusBar.Text = "Calc: Flow - Given: Depth, Vel, & Diam";
                Calculate();
			}
		}

        /// <summary>
		/// Grey out Velocity field and clear up Depth and Flow field
		/// </summary>
		/// <remarks>
		/// Allows user to input data into Flow and Depth field and
		/// Keeps the user from inputing data into the Velocity,
		/// Slopw, or NValue fields, which will be calculated.
		/// </remarks>
        private void rdoVQA_CheckedChanged(object sender, System.EventArgs e)
		{
			if(rdoVQA.Checked)
			{
				txtFlow.Enabled = true;
				txtSlope.Enabled = false;
				txtSlope.Text = "0.0";
				txtNValue.Enabled = false;
				txtNValue.Text = "0.013";
				txtVelocity.Enabled = false;
				txtVelocity.Text = "0.0";
				txtDepth.Enabled = true;
				statusBar.Text = "Calc: Vel - Given: Flow, Depth, & Diam";
                Calculate();
			}
		}

        /// <summary>
		/// Adds Main Menu to form.
		/// </summary>
		/// <remarks>
		/// Allows user to save data to csv file or see the about box.
		/// </remarks>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void frmHydCalc_DoubleClick(object sender, System.EventArgs e)
		{
			if (this.Menu == null)
			{
				this.Menu = this.mnuMain;
				this.Height = this.Height + 20;
				}
			else
			{
				this.Menu = null;
				this.Height = this.Height - 20;
			}
		}
		
		#region Menu Code
		/// <summary>
		/// Exit form and code
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void itmExit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		/// <summary>
		/// About message box
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void itmAbout_Click(object sender, System.EventArgs e)
		{
			string SoftwareVersion = _version;
			string SoftwareDate = _today;

			MessageBox.Show(" Hydraulic Calculator  v" + SoftwareVersion + 
				"\n\n Created by: Matthew J. Wedeking\n\n           " + SoftwareDate,	
				"About", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		/// <summary>
		/// Save message box
		/// </summary>
		/// <remarks>
		/// Saves data in form to a CSV file
		/// </remarks>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void itmSave_Click(object sender, System.EventArgs e)
		{
			string outputFile;

			// Display the openFile dialog.
			DialogResult result = saveFileDialog.ShowDialog();

			// OK button was pressed.
			if(result == DialogResult.OK) 
			{
				outputFile = saveFileDialog.FileName;
				StreamWriter output = new StreamWriter(outputFile);
				output.Write(GetHeader());
				output.Write("\r\n");
				output.Write(GetData());
				output.Close();

				statusBar.Text = "Saved";
			}

				// Cancel button was pressed.
			else if(result == DialogResult.Cancel) 
			{
				statusBar.Text = "";
				return;
			}
		}

		/// <summary>
		/// Creates Header row for CSV export.
		/// </summary>
		/// <returns></returns>
		private string GetHeader()
		{
			string header;

			header = "Flow " + cboFlowUnit.Text + ", ";
			header = header + "Depth " + cboDepthUnit.Text + ", ";
			header = header + "Velocity " + cboVelocityUnit.Text + ", ";
			header = header + "Diameter " + cboDiameterUnit.Text + ", ";
			header = header + "Slope " + cboSlopeUnit.Text + ", ";
			header = header + "NValue";

			return header;
		}

		/// <summary>
		/// Creates Data row for CSV export.
		/// </summary>
		/// <returns></returns>
		private string GetData()
		{
			string data;
			data = txtFlow.Text + ", ";
			data = data + txtDepth.Text + ", ";
			data = data + txtVelocity.Text + ", ";
			data = data + txtDiameter.Text + ", ";
			data = data + txtSlope.Text + ", ";
			data = data + txtNValue.Text;

			return data;
		}
		#endregion

        private void txtFlow_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtDepth_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtVelocity_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtDiameter_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtSlope_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtNValue_TextChanged(object sender, EventArgs e)
        {
            if (txtNValue.Text != null)
            {
                switch (double.Parse(txtNValue.Text).ToString("0.###"))
                {
                    case "0.014":
                        cboNValue.Text = "VC";
                        break;
                    case "0.011":
                        cboNValue.Text = "PVC";
                        break;
                    case "0.013":
                        cboNValue.Text = "Conc";
                        break;
                    default:
                        cboNValue.Text = "";
                        break;
                }
            }
            Calculate();
        }

        private void frmHydCalc_Load(object sender, EventArgs e)
        {

        }

        private void cboWettedPerimiterUnit_SelectedValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void cboWettedAreaUnit_SelectedValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void cboPipeCapacityUnit_SelectedValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void cboCriticalDepthUnit_SelectedValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void cboVelocityHeadUnit_SelectedValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void cboHydraulicRadiusUnit_SelectedValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtDepth_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(txtDiameter.Text) >= 0)
                {
                    this.ContextMenuStrip = this.contextMenudD;
                    contextMenudD.Show();
                }
            }
            catch { }
        }

        private void dDToolStripMenuItem25_Click(object sender, EventArgs e)
        {
            txtDepth.Text = (double.Parse(txtDiameter.Text) * 0.25).ToString("#,##0.####");
            cboDepthUnit.Text = cboDiameterUnit.Text;
        }

        private void dDToolStripMenuItem50_Click(object sender, EventArgs e)
        {
            txtDepth.Text = (double.Parse(txtDiameter.Text) * 0.5).ToString("#,##0.####");
            cboDepthUnit.Text = cboDiameterUnit.Text;
        }

        private void dDToolStripMenuItem70_Click(object sender, EventArgs e)
        {
            txtDepth.Text = (double.Parse(txtDiameter.Text) * 0.7).ToString("#,##0.####");
            cboDepthUnit.Text = cboDiameterUnit.Text;
        }

        private void dDToolStripMenuItem75_Click(object sender, EventArgs e)
        {
            txtDepth.Text = (double.Parse(txtDiameter.Text) * 0.75).ToString("#,##0.####");
            cboDepthUnit.Text = cboDiameterUnit.Text;
        }

        private void dDToolStripMenuItem92_Click(object sender, EventArgs e)
        {
            txtDepth.Text = (double.Parse(txtDiameter.Text) * 0.92).ToString("#,##0.####");
            cboDepthUnit.Text = cboDiameterUnit.Text;
        }

        private void dDToolStripMenuItem100_Click(object sender, EventArgs e)
        {
            txtDepth.Text = txtDiameter.Text;
            cboDepthUnit.Text = cboDiameterUnit.Text;
        }

        private void cboNValue_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboNValue.Text != null)
            {
                switch (cboNValue.Text)
                {
                    case "VC":
                        txtNValue.Text = "0.014";
                        break;
                    case "PVC":
                        txtNValue.Text = "0.011";
                        break;
                    case "Conc":
                        txtNValue.Text = "0.013";
                        break;
                    default:
                        break;
                }
            }
        }

        private void lblDepth_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (double.Parse(txtDiameter.Text) >= 0)
                {
                    //this.ContextMenuStrip = this.contextMenudD;
                    contextMenudD.Show();
                }
            }
            catch { }
        }
    }

}