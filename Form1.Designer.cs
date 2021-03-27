
namespace KineLab
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridView posView;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入配置文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出配置文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开路径ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读取机械臂配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.从ma文件导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出到ma文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.focalLengthDisplay = new System.Windows.Forms.Label();
            this.camXDisplay = new System.Windows.Forms.Label();
            this.camYDisplay = new System.Windows.Forms.Label();
            this.camZDisplay = new System.Windows.Forms.Label();
            this.rYDisplay = new System.Windows.Forms.Label();
            this.rollDisplay = new System.Windows.Forms.Label();
            this.rXDisplay = new System.Windows.Forms.Label();
            this.rZDisplay = new System.Windows.Forms.Label();
            this.dollyDisplay = new System.Windows.Forms.Label();
            this.ipInput = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.portInput = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Button();
            this.powerOn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.projectRate = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.recordRate = new System.Windows.Forms.TextBox();
            this.generatePath = new System.Windows.Forms.Button();
            this.reverse = new System.Windows.Forms.CheckBox();
            this.changeLens = new System.Windows.Forms.Button();
            this.coordSelect = new System.Windows.Forms.ComboBox();
            this.gamePad = new System.Windows.Forms.CheckBox();
            this.smoothness = new System.Windows.Forms.TrackBar();
            this.label14 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stausBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.J1P = new System.Windows.Forms.Button();
            this.J2P = new System.Windows.Forms.Button();
            this.J3P = new System.Windows.Forms.Button();
            this.J4P = new System.Windows.Forms.Button();
            this.J5P = new System.Windows.Forms.Button();
            this.J6P = new System.Windows.Forms.Button();
            this.J7P = new System.Windows.Forms.Button();
            this.J8P = new System.Windows.Forms.Button();
            this.J9P = new System.Windows.Forms.Button();
            this.J1N = new System.Windows.Forms.Button();
            this.J2N = new System.Windows.Forms.Button();
            this.J3N = new System.Windows.Forms.Button();
            this.J4N = new System.Windows.Forms.Button();
            this.J5N = new System.Windows.Forms.Button();
            this.J6N = new System.Windows.Forms.Button();
            this.J7N = new System.Windows.Forms.Button();
            this.J8N = new System.Windows.Forms.Button();
            this.J9N = new System.Windows.Forms.Button();
            this.jogSpeedBar = new System.Windows.Forms.TrackBar();
            this.jogSpeed = new System.Windows.Forms.Label();
            this.pathBar = new System.Windows.Forms.TrackBar();
            this.moveTo = new System.Windows.Forms.Button();
            this.maxFrame = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.fwdRun = new System.Windows.Forms.Button();
            this.bckRun = new System.Windows.Forms.Button();
            this.fwdStep = new System.Windows.Forms.Button();
            this.bckStep = new System.Windows.Forms.Button();
            this.addPos = new System.Windows.Forms.Button();
            this.delPos = new System.Windows.Forms.Button();
            this.upload = new System.Windows.Forms.Button();
            this.resetPath = new System.Windows.Forms.Button();
            this.rehearsalSpeedBar = new System.Windows.Forms.TrackBar();
            this.rehearsalSpeed = new System.Windows.Forms.Label();
            this.Pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CamX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CamY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CamZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            posView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(posView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smoothness)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jogSpeedBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rehearsalSpeedBar)).BeginInit();
            this.SuspendLayout();
            // 
            // posView
            // 
            posView.AllowUserToResizeRows = false;
            posView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            posView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            posView.ColumnHeadersHeight = 20;
            posView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            posView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pos,
            this.Frame,
            this.Time,
            this.Distance,
            this.CamX,
            this.CamY,
            this.CamZ,
            this.Ry,
            this.Rx,
            this.Rz,
            this.Line,
            this.Dash});
            posView.Location = new System.Drawing.Point(27, 50);
            posView.Margin = new System.Windows.Forms.Padding(2);
            posView.MultiSelect = false;
            posView.Name = "posView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            posView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            posView.RowHeadersWidth = 30;
            posView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            posView.RowTemplate.Height = 37;
            posView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            posView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            posView.Size = new System.Drawing.Size(652, 404);
            posView.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.cGToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(919, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入配置文件ToolStripMenuItem,
            this.导出配置文件ToolStripMenuItem,
            this.打开路径ToolStripMenuItem,
            this.保存任务ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 导入配置文件ToolStripMenuItem
            // 
            this.导入配置文件ToolStripMenuItem.Name = "导入配置文件ToolStripMenuItem";
            this.导入配置文件ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.导入配置文件ToolStripMenuItem.Text = "导入配置文件";
            // 
            // 导出配置文件ToolStripMenuItem
            // 
            this.导出配置文件ToolStripMenuItem.Name = "导出配置文件ToolStripMenuItem";
            this.导出配置文件ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.导出配置文件ToolStripMenuItem.Text = "导出配置文件";
            // 
            // 打开路径ToolStripMenuItem
            // 
            this.打开路径ToolStripMenuItem.Name = "打开路径ToolStripMenuItem";
            this.打开路径ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.打开路径ToolStripMenuItem.Text = "打开任务";
            this.打开路径ToolStripMenuItem.Click += new System.EventHandler(this.打开路径ToolStripMenuItem_Click);
            // 
            // 保存任务ToolStripMenuItem
            // 
            this.保存任务ToolStripMenuItem.Name = "保存任务ToolStripMenuItem";
            this.保存任务ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.保存任务ToolStripMenuItem.Text = "保存任务";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.读取机械臂配置ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 读取机械臂配置ToolStripMenuItem
            // 
            this.读取机械臂配置ToolStripMenuItem.Name = "读取机械臂配置ToolStripMenuItem";
            this.读取机械臂配置ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.读取机械臂配置ToolStripMenuItem.Text = "机械臂配置";
            // 
            // cGToolStripMenuItem
            // 
            this.cGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.从ma文件导入ToolStripMenuItem,
            this.导出到ma文件ToolStripMenuItem});
            this.cGToolStripMenuItem.Name = "cGToolStripMenuItem";
            this.cGToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.cGToolStripMenuItem.Text = "CG";
            // 
            // 从ma文件导入ToolStripMenuItem
            // 
            this.从ma文件导入ToolStripMenuItem.Name = "从ma文件导入ToolStripMenuItem";
            this.从ma文件导入ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.从ma文件导入ToolStripMenuItem.Text = "从ma文件导入";
            // 
            // 导出到ma文件ToolStripMenuItem
            // 
            this.导出到ma文件ToolStripMenuItem.Name = "导出到ma文件ToolStripMenuItem";
            this.导出到ma文件ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.导出到ma文件ToolStripMenuItem.Text = "导出到ma文件";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // focalLengthDisplay
            // 
            this.focalLengthDisplay.Location = new System.Drawing.Point(191, 33);
            this.focalLengthDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.focalLengthDisplay.Name = "focalLengthDisplay";
            this.focalLengthDisplay.Size = new System.Drawing.Size(58, 15);
            this.focalLengthDisplay.TabIndex = 2;
            this.focalLengthDisplay.Text = "0";
            this.focalLengthDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // camXDisplay
            // 
            this.camXDisplay.Location = new System.Drawing.Point(253, 33);
            this.camXDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.camXDisplay.Name = "camXDisplay";
            this.camXDisplay.Size = new System.Drawing.Size(68, 12);
            this.camXDisplay.TabIndex = 2;
            this.camXDisplay.Text = "0";
            this.camXDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // camYDisplay
            // 
            this.camYDisplay.Location = new System.Drawing.Point(325, 33);
            this.camYDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.camYDisplay.Name = "camYDisplay";
            this.camYDisplay.Size = new System.Drawing.Size(67, 12);
            this.camYDisplay.TabIndex = 2;
            this.camYDisplay.Text = "0";
            this.camYDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // camZDisplay
            // 
            this.camZDisplay.Location = new System.Drawing.Point(396, 34);
            this.camZDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.camZDisplay.Name = "camZDisplay";
            this.camZDisplay.Size = new System.Drawing.Size(69, 12);
            this.camZDisplay.TabIndex = 2;
            this.camZDisplay.Text = "0";
            this.camZDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.camZDisplay.Click += new System.EventHandler(this.camZDisplay_Click);
            // 
            // rYDisplay
            // 
            this.rYDisplay.Location = new System.Drawing.Point(469, 33);
            this.rYDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rYDisplay.Name = "rYDisplay";
            this.rYDisplay.Size = new System.Drawing.Size(30, 12);
            this.rYDisplay.TabIndex = 2;
            this.rYDisplay.Text = "0";
            this.rYDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rollDisplay
            // 
            this.rollDisplay.Location = new System.Drawing.Point(619, 34);
            this.rollDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rollDisplay.Name = "rollDisplay";
            this.rollDisplay.Size = new System.Drawing.Size(51, 12);
            this.rollDisplay.TabIndex = 2;
            this.rollDisplay.Text = "0";
            this.rollDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rXDisplay
            // 
            this.rXDisplay.Location = new System.Drawing.Point(503, 33);
            this.rXDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rXDisplay.Name = "rXDisplay";
            this.rXDisplay.Size = new System.Drawing.Size(30, 12);
            this.rXDisplay.TabIndex = 2;
            this.rXDisplay.Text = "0";
            this.rXDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rZDisplay
            // 
            this.rZDisplay.Location = new System.Drawing.Point(537, 33);
            this.rZDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rZDisplay.Name = "rZDisplay";
            this.rZDisplay.Size = new System.Drawing.Size(37, 12);
            this.rZDisplay.TabIndex = 2;
            this.rZDisplay.Text = "0";
            this.rZDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dollyDisplay
            // 
            this.dollyDisplay.Location = new System.Drawing.Point(578, 33);
            this.dollyDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dollyDisplay.Name = "dollyDisplay";
            this.dollyDisplay.Size = new System.Drawing.Size(37, 12);
            this.dollyDisplay.TabIndex = 2;
            this.dollyDisplay.Text = "0";
            this.dollyDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dollyDisplay.Click += new System.EventHandler(this.dollyDisplay_Click);
            // 
            // ipInput
            // 
            this.ipInput.Location = new System.Drawing.Point(725, 47);
            this.ipInput.Name = "ipInput";
            this.ipInput.Size = new System.Drawing.Size(97, 21);
            this.ipInput.TabIndex = 3;
            this.ipInput.Text = "192.168.100.1";
            this.ipInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(702, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "IP";
            // 
            // portInput
            // 
            this.portInput.Location = new System.Drawing.Point(863, 47);
            this.portInput.Name = "portInput";
            this.portInput.Size = new System.Drawing.Size(33, 21);
            this.portInput.TabIndex = 3;
            this.portInput.Text = "6000";
            this.portInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(828, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 4;
            this.label11.Text = "Port";
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(704, 77);
            this.connect.Margin = new System.Windows.Forms.Padding(6);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(192, 29);
            this.connect.TabIndex = 5;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            // 
            // powerOn
            // 
            this.powerOn.Location = new System.Drawing.Point(704, 321);
            this.powerOn.Margin = new System.Windows.Forms.Padding(6);
            this.powerOn.Name = "powerOn";
            this.powerOn.Size = new System.Drawing.Size(192, 29);
            this.powerOn.TabIndex = 5;
            this.powerOn.Text = "Power On";
            this.powerOn.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(723, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 12);
            this.label12.TabIndex = 6;
            this.label12.Text = "Project Rate";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // projectRate
            // 
            this.projectRate.FormattingEnabled = true;
            this.projectRate.Items.AddRange(new object[] {
            "23.976",
            "24",
            "25",
            "29.97",
            "30",
            "48",
            "50",
            "59.94",
            "60"});
            this.projectRate.Location = new System.Drawing.Point(820, 168);
            this.projectRate.Name = "projectRate";
            this.projectRate.Size = new System.Drawing.Size(67, 20);
            this.projectRate.TabIndex = 7;
            this.projectRate.Text = "25";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(723, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 12);
            this.label13.TabIndex = 6;
            this.label13.Text = "Record Rate";
            this.label13.Click += new System.EventHandler(this.label12_Click);
            // 
            // recordRate
            // 
            this.recordRate.Location = new System.Drawing.Point(820, 196);
            this.recordRate.Name = "recordRate";
            this.recordRate.Size = new System.Drawing.Size(67, 21);
            this.recordRate.TabIndex = 3;
            this.recordRate.Text = "50";
            this.recordRate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // generatePath
            // 
            this.generatePath.Location = new System.Drawing.Point(725, 251);
            this.generatePath.Margin = new System.Windows.Forms.Padding(6);
            this.generatePath.Name = "generatePath";
            this.generatePath.Size = new System.Drawing.Size(162, 23);
            this.generatePath.TabIndex = 8;
            this.generatePath.Text = "Generate Path";
            this.generatePath.UseVisualStyleBackColor = true;
            // 
            // reverse
            // 
            this.reverse.AutoSize = true;
            this.reverse.Location = new System.Drawing.Point(772, 226);
            this.reverse.Name = "reverse";
            this.reverse.Size = new System.Drawing.Size(66, 16);
            this.reverse.TabIndex = 9;
            this.reverse.Text = "Reverse";
            this.reverse.UseVisualStyleBackColor = true;
            // 
            // changeLens
            // 
            this.changeLens.Location = new System.Drawing.Point(725, 286);
            this.changeLens.Margin = new System.Windows.Forms.Padding(6);
            this.changeLens.Name = "changeLens";
            this.changeLens.Size = new System.Drawing.Size(162, 23);
            this.changeLens.TabIndex = 8;
            this.changeLens.Text = "Change Lens";
            this.changeLens.UseVisualStyleBackColor = true;
            this.changeLens.Click += new System.EventHandler(this.changeLens_Click);
            // 
            // coordSelect
            // 
            this.coordSelect.FormattingEnabled = true;
            this.coordSelect.Items.AddRange(new object[] {
            "TCS",
            "Joint",
            "WCS"});
            this.coordSelect.Location = new System.Drawing.Point(719, 362);
            this.coordSelect.Margin = new System.Windows.Forms.Padding(6);
            this.coordSelect.Name = "coordSelect";
            this.coordSelect.Size = new System.Drawing.Size(75, 20);
            this.coordSelect.TabIndex = 10;
            this.coordSelect.Text = "Joint";
            // 
            // gamePad
            // 
            this.gamePad.AutoSize = true;
            this.gamePad.Location = new System.Drawing.Point(821, 364);
            this.gamePad.Name = "gamePad";
            this.gamePad.Size = new System.Drawing.Size(66, 16);
            this.gamePad.TabIndex = 11;
            this.gamePad.Text = "GamePad";
            this.gamePad.UseVisualStyleBackColor = true;
            // 
            // smoothness
            // 
            this.smoothness.Location = new System.Drawing.Point(704, 123);
            this.smoothness.Name = "smoothness";
            this.smoothness.Size = new System.Drawing.Size(192, 45);
            this.smoothness.TabIndex = 12;
            this.smoothness.Value = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(770, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 4;
            this.label14.Text = "Smoothness";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.toolStripStatusLabel2,
            this.stausBar});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 609);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(919, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "Ready";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(200, 16);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(350, 17);
            this.toolStripStatusLabel2.Text = "Kinematic Lab Motion Control V0.1";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stausBar
            // 
            this.stausBar.AutoSize = false;
            this.stausBar.Name = "stausBar";
            this.stausBar.Size = new System.Drawing.Size(350, 17);
            this.stausBar.Text = "Ready";
            this.stausBar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // J1P
            // 
            this.J1P.Location = new System.Drawing.Point(704, 391);
            this.J1P.Margin = new System.Windows.Forms.Padding(0);
            this.J1P.Name = "J1P";
            this.J1P.Size = new System.Drawing.Size(50, 20);
            this.J1P.TabIndex = 14;
            this.J1P.Text = "J1/X+";
            this.J1P.UseVisualStyleBackColor = true;
            // 
            // J2P
            // 
            this.J2P.Location = new System.Drawing.Point(704, 411);
            this.J2P.Margin = new System.Windows.Forms.Padding(0);
            this.J2P.Name = "J2P";
            this.J2P.Size = new System.Drawing.Size(50, 20);
            this.J2P.TabIndex = 14;
            this.J2P.Text = "J2/Y+";
            this.J2P.UseVisualStyleBackColor = true;
            // 
            // J3P
            // 
            this.J3P.Location = new System.Drawing.Point(704, 431);
            this.J3P.Margin = new System.Windows.Forms.Padding(0);
            this.J3P.Name = "J3P";
            this.J3P.Size = new System.Drawing.Size(50, 20);
            this.J3P.TabIndex = 14;
            this.J3P.Text = "J3/Z+";
            this.J3P.UseVisualStyleBackColor = true;
            // 
            // J4P
            // 
            this.J4P.Location = new System.Drawing.Point(704, 451);
            this.J4P.Margin = new System.Windows.Forms.Padding(0);
            this.J4P.Name = "J4P";
            this.J4P.Size = new System.Drawing.Size(50, 20);
            this.J4P.TabIndex = 14;
            this.J4P.Text = "J4/Rx+";
            this.J4P.UseVisualStyleBackColor = true;
            // 
            // J5P
            // 
            this.J5P.Location = new System.Drawing.Point(704, 471);
            this.J5P.Margin = new System.Windows.Forms.Padding(0);
            this.J5P.Name = "J5P";
            this.J5P.Size = new System.Drawing.Size(50, 20);
            this.J5P.TabIndex = 14;
            this.J5P.Text = "J5/Ry+";
            this.J5P.UseVisualStyleBackColor = true;
            // 
            // J6P
            // 
            this.J6P.Location = new System.Drawing.Point(704, 491);
            this.J6P.Margin = new System.Windows.Forms.Padding(0);
            this.J6P.Name = "J6P";
            this.J6P.Size = new System.Drawing.Size(50, 20);
            this.J6P.TabIndex = 14;
            this.J6P.Text = "J6/Rz+";
            this.J6P.UseVisualStyleBackColor = true;
            // 
            // J7P
            // 
            this.J7P.Location = new System.Drawing.Point(704, 511);
            this.J7P.Margin = new System.Windows.Forms.Padding(0);
            this.J7P.Name = "J7P";
            this.J7P.Size = new System.Drawing.Size(50, 20);
            this.J7P.TabIndex = 14;
            this.J7P.Text = "J7+";
            this.J7P.UseVisualStyleBackColor = true;
            // 
            // J8P
            // 
            this.J8P.Location = new System.Drawing.Point(704, 531);
            this.J8P.Margin = new System.Windows.Forms.Padding(0);
            this.J8P.Name = "J8P";
            this.J8P.Size = new System.Drawing.Size(50, 20);
            this.J8P.TabIndex = 14;
            this.J8P.Text = "J8+";
            this.J8P.UseVisualStyleBackColor = true;
            // 
            // J9P
            // 
            this.J9P.Location = new System.Drawing.Point(704, 551);
            this.J9P.Margin = new System.Windows.Forms.Padding(0);
            this.J9P.Name = "J9P";
            this.J9P.Size = new System.Drawing.Size(50, 20);
            this.J9P.TabIndex = 14;
            this.J9P.Text = "J9+";
            this.J9P.UseVisualStyleBackColor = true;
            // 
            // J1N
            // 
            this.J1N.Location = new System.Drawing.Point(846, 391);
            this.J1N.Margin = new System.Windows.Forms.Padding(0);
            this.J1N.Name = "J1N";
            this.J1N.Size = new System.Drawing.Size(50, 20);
            this.J1N.TabIndex = 14;
            this.J1N.Text = "J1/X-";
            this.J1N.UseVisualStyleBackColor = true;
            // 
            // J2N
            // 
            this.J2N.Location = new System.Drawing.Point(846, 411);
            this.J2N.Margin = new System.Windows.Forms.Padding(0);
            this.J2N.Name = "J2N";
            this.J2N.Size = new System.Drawing.Size(50, 20);
            this.J2N.TabIndex = 14;
            this.J2N.Text = "J2/Y-";
            this.J2N.UseVisualStyleBackColor = true;
            // 
            // J3N
            // 
            this.J3N.Location = new System.Drawing.Point(846, 431);
            this.J3N.Margin = new System.Windows.Forms.Padding(0);
            this.J3N.Name = "J3N";
            this.J3N.Size = new System.Drawing.Size(50, 20);
            this.J3N.TabIndex = 14;
            this.J3N.Text = "J3/Z-";
            this.J3N.UseVisualStyleBackColor = true;
            // 
            // J4N
            // 
            this.J4N.Location = new System.Drawing.Point(846, 451);
            this.J4N.Margin = new System.Windows.Forms.Padding(0);
            this.J4N.Name = "J4N";
            this.J4N.Size = new System.Drawing.Size(50, 20);
            this.J4N.TabIndex = 14;
            this.J4N.Text = "J4/Rx-";
            this.J4N.UseVisualStyleBackColor = true;
            // 
            // J5N
            // 
            this.J5N.Location = new System.Drawing.Point(846, 471);
            this.J5N.Margin = new System.Windows.Forms.Padding(0);
            this.J5N.Name = "J5N";
            this.J5N.Size = new System.Drawing.Size(50, 20);
            this.J5N.TabIndex = 14;
            this.J5N.Text = "J5/Ry-";
            this.J5N.UseVisualStyleBackColor = true;
            // 
            // J6N
            // 
            this.J6N.Location = new System.Drawing.Point(846, 491);
            this.J6N.Margin = new System.Windows.Forms.Padding(0);
            this.J6N.Name = "J6N";
            this.J6N.Size = new System.Drawing.Size(50, 20);
            this.J6N.TabIndex = 14;
            this.J6N.Text = "J6/Rz-";
            this.J6N.UseVisualStyleBackColor = true;
            // 
            // J7N
            // 
            this.J7N.Location = new System.Drawing.Point(846, 511);
            this.J7N.Margin = new System.Windows.Forms.Padding(0);
            this.J7N.Name = "J7N";
            this.J7N.Size = new System.Drawing.Size(50, 20);
            this.J7N.TabIndex = 14;
            this.J7N.Text = "J7-";
            this.J7N.UseVisualStyleBackColor = true;
            // 
            // J8N
            // 
            this.J8N.Location = new System.Drawing.Point(846, 531);
            this.J8N.Margin = new System.Windows.Forms.Padding(0);
            this.J8N.Name = "J8N";
            this.J8N.Size = new System.Drawing.Size(50, 20);
            this.J8N.TabIndex = 14;
            this.J8N.Text = "J8-";
            this.J8N.UseVisualStyleBackColor = true;
            // 
            // J9N
            // 
            this.J9N.Location = new System.Drawing.Point(846, 551);
            this.J9N.Margin = new System.Windows.Forms.Padding(0);
            this.J9N.Name = "J9N";
            this.J9N.Size = new System.Drawing.Size(50, 20);
            this.J9N.TabIndex = 14;
            this.J9N.Text = "J9-";
            this.J9N.UseVisualStyleBackColor = true;
            // 
            // jogSpeedBar
            // 
            this.jogSpeedBar.Location = new System.Drawing.Point(777, 391);
            this.jogSpeedBar.Minimum = 1;
            this.jogSpeedBar.Name = "jogSpeedBar";
            this.jogSpeedBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.jogSpeedBar.Size = new System.Drawing.Size(45, 180);
            this.jogSpeedBar.TabIndex = 15;
            this.jogSpeedBar.Value = 3;
            // 
            // jogSpeed
            // 
            this.jogSpeed.Location = new System.Drawing.Point(717, 570);
            this.jogSpeed.Name = "jogSpeed";
            this.jogSpeed.Size = new System.Drawing.Size(179, 26);
            this.jogSpeed.TabIndex = 16;
            this.jogSpeed.Text = "JogSpeed:30%";
            this.jogSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pathBar
            // 
            this.pathBar.Location = new System.Drawing.Point(11, 551);
            this.pathBar.Name = "pathBar";
            this.pathBar.Size = new System.Drawing.Size(675, 45);
            this.pathBar.TabIndex = 17;
            // 
            // moveTo
            // 
            this.moveTo.Location = new System.Drawing.Point(271, 573);
            this.moveTo.Name = "moveTo";
            this.moveTo.Size = new System.Drawing.Size(147, 23);
            this.moveTo.TabIndex = 18;
            this.moveTo.Text = "MoveTo:";
            this.moveTo.UseVisualStyleBackColor = true;
            // 
            // maxFrame
            // 
            this.maxFrame.AutoSize = true;
            this.maxFrame.Location = new System.Drawing.Point(657, 584);
            this.maxFrame.Name = "maxFrame";
            this.maxFrame.Size = new System.Drawing.Size(29, 12);
            this.maxFrame.TabIndex = 19;
            this.maxFrame.Text = "8667";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 584);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(11, 12);
            this.label17.TabIndex = 19;
            this.label17.Text = "0";
            // 
            // fwdRun
            // 
            this.fwdRun.Location = new System.Drawing.Point(31, 471);
            this.fwdRun.Name = "fwdRun";
            this.fwdRun.Size = new System.Drawing.Size(75, 23);
            this.fwdRun.TabIndex = 20;
            this.fwdRun.Text = "FWD RUN";
            this.fwdRun.UseVisualStyleBackColor = true;
            // 
            // bckRun
            // 
            this.bckRun.Location = new System.Drawing.Point(31, 500);
            this.bckRun.Name = "bckRun";
            this.bckRun.Size = new System.Drawing.Size(75, 23);
            this.bckRun.TabIndex = 20;
            this.bckRun.Text = "BCK RUN";
            this.bckRun.UseVisualStyleBackColor = true;
            // 
            // fwdStep
            // 
            this.fwdStep.Location = new System.Drawing.Point(127, 471);
            this.fwdStep.Name = "fwdStep";
            this.fwdStep.Size = new System.Drawing.Size(75, 23);
            this.fwdStep.TabIndex = 20;
            this.fwdStep.Text = "FWD STEP";
            this.fwdStep.UseVisualStyleBackColor = true;
            // 
            // bckStep
            // 
            this.bckStep.Location = new System.Drawing.Point(127, 500);
            this.bckStep.Name = "bckStep";
            this.bckStep.Size = new System.Drawing.Size(75, 23);
            this.bckStep.TabIndex = 20;
            this.bckStep.Text = "BCK STEP";
            this.bckStep.UseVisualStyleBackColor = true;
            // 
            // addPos
            // 
            this.addPos.Location = new System.Drawing.Point(508, 471);
            this.addPos.Name = "addPos";
            this.addPos.Size = new System.Drawing.Size(75, 23);
            this.addPos.TabIndex = 20;
            this.addPos.Text = "ADD POS";
            this.addPos.UseVisualStyleBackColor = true;
            // 
            // delPos
            // 
            this.delPos.Location = new System.Drawing.Point(604, 471);
            this.delPos.Name = "delPos";
            this.delPos.Size = new System.Drawing.Size(75, 23);
            this.delPos.TabIndex = 20;
            this.delPos.Text = "DEL POS";
            this.delPos.UseVisualStyleBackColor = true;
            // 
            // upload
            // 
            this.upload.Location = new System.Drawing.Point(508, 500);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(75, 23);
            this.upload.TabIndex = 20;
            this.upload.Text = "Upload";
            this.upload.UseVisualStyleBackColor = true;
            // 
            // resetPath
            // 
            this.resetPath.Location = new System.Drawing.Point(604, 500);
            this.resetPath.Name = "resetPath";
            this.resetPath.Size = new System.Drawing.Size(75, 23);
            this.resetPath.TabIndex = 20;
            this.resetPath.Text = "Reset Path";
            this.resetPath.UseVisualStyleBackColor = true;
            // 
            // rehearsalSpeedBar
            // 
            this.rehearsalSpeedBar.Location = new System.Drawing.Point(228, 471);
            this.rehearsalSpeedBar.Minimum = 1;
            this.rehearsalSpeedBar.Name = "rehearsalSpeedBar";
            this.rehearsalSpeedBar.Size = new System.Drawing.Size(250, 45);
            this.rehearsalSpeedBar.TabIndex = 21;
            this.rehearsalSpeedBar.Value = 5;
            // 
            // rehearsalSpeed
            // 
            this.rehearsalSpeed.AutoSize = true;
            this.rehearsalSpeed.Location = new System.Drawing.Point(300, 504);
            this.rehearsalSpeed.Name = "rehearsalSpeed";
            this.rehearsalSpeed.Size = new System.Drawing.Size(119, 12);
            this.rehearsalSpeed.TabIndex = 22;
            this.rehearsalSpeed.Text = "Rehearsal Speed:50%";
            // 
            // Pos
            // 
            this.Pos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Pos.HeaderText = "Pos";
            this.Pos.MinimumWidth = 10;
            this.Pos.Name = "Pos";
            this.Pos.ReadOnly = true;
            this.Pos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Pos.ToolTipText = "当前路径点编号";
            this.Pos.Width = 29;
            // 
            // Frame
            // 
            this.Frame.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Frame.HeaderText = "Frames";
            this.Frame.MinimumWidth = 10;
            this.Frame.Name = "Frame";
            this.Frame.ReadOnly = true;
            this.Frame.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Frame.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Frame.ToolTipText = "从开始到当前路径点拍摄帧数";
            this.Frame.Width = 47;
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Time.HeaderText = "Interval";
            this.Time.MinimumWidth = 10;
            this.Time.Name = "Time";
            this.Time.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Time.ToolTipText = "与上一路径点之间所隔时间差";
            this.Time.Width = 59;
            // 
            // Distance
            // 
            this.Distance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Distance.HeaderText = "Distance";
            this.Distance.MinimumWidth = 10;
            this.Distance.Name = "Distance";
            this.Distance.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Distance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Distance.ToolTipText = "摄影机与被摄物距离";
            this.Distance.Width = 59;
            // 
            // CamX
            // 
            this.CamX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CamX.HeaderText = "   CamX   ";
            this.CamX.MinimumWidth = 10;
            this.CamX.Name = "CamX";
            this.CamX.ReadOnly = true;
            this.CamX.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CamX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CamX.ToolTipText = "摄影机X坐标";
            this.CamX.Width = 71;
            // 
            // CamY
            // 
            this.CamY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CamY.HeaderText = "   CamY   ";
            this.CamY.MinimumWidth = 10;
            this.CamY.Name = "CamY";
            this.CamY.ReadOnly = true;
            this.CamY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CamY.ToolTipText = "摄影机Y坐标";
            this.CamY.Width = 71;
            // 
            // CamZ
            // 
            this.CamZ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CamZ.HeaderText = "   CamZ   ";
            this.CamZ.MinimumWidth = 10;
            this.CamZ.Name = "CamZ";
            this.CamZ.ReadOnly = true;
            this.CamZ.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CamZ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CamZ.ToolTipText = "摄影机Z坐标";
            this.CamZ.Width = 71;
            // 
            // Ry
            // 
            this.Ry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Ry.HeaderText = "Tilt ";
            this.Ry.MinimumWidth = 10;
            this.Ry.Name = "Ry";
            this.Ry.ReadOnly = true;
            this.Ry.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ry.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Ry.ToolTipText = "摄影机俯仰角";
            this.Ry.Width = 37;
            // 
            // Rx
            // 
            this.Rx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Rx.HeaderText = "Roll";
            this.Rx.MinimumWidth = 10;
            this.Rx.Name = "Rx";
            this.Rx.ReadOnly = true;
            this.Rx.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Rx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Rx.ToolTipText = "摄影机横滚角";
            this.Rx.Width = 35;
            // 
            // Rz
            // 
            this.Rz.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Rz.HeaderText = " Pan ";
            this.Rz.MinimumWidth = 10;
            this.Rz.Name = "Rz";
            this.Rz.ReadOnly = true;
            this.Rz.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Rz.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Rz.ToolTipText = "摄影机平移角";
            this.Rz.Width = 37;
            // 
            // Line
            // 
            this.Line.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Line.HeaderText = "Dolly";
            this.Line.MinimumWidth = 10;
            this.Line.Name = "Line";
            this.Line.ReadOnly = true;
            this.Line.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Line.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Line.ToolTipText = "当前轨道位置";
            this.Line.Width = 41;
            // 
            // Dash
            // 
            this.Dash.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Dash.HeaderText = "2th Roll";
            this.Dash.MinimumWidth = 10;
            this.Dash.Name = "Dash";
            this.Dash.ReadOnly = true;
            this.Dash.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Dash.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Dash.ToolTipText = "摄影机框架旋转角度";
            this.Dash.Width = 59;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 631);
            this.Controls.Add(this.rehearsalSpeed);
            this.Controls.Add(this.rehearsalSpeedBar);
            this.Controls.Add(this.bckStep);
            this.Controls.Add(this.bckRun);
            this.Controls.Add(this.resetPath);
            this.Controls.Add(this.delPos);
            this.Controls.Add(this.fwdStep);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.addPos);
            this.Controls.Add(this.fwdRun);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.maxFrame);
            this.Controls.Add(this.moveTo);
            this.Controls.Add(this.pathBar);
            this.Controls.Add(this.jogSpeed);
            this.Controls.Add(this.jogSpeedBar);
            this.Controls.Add(this.J9N);
            this.Controls.Add(this.J9P);
            this.Controls.Add(this.J8N);
            this.Controls.Add(this.J8P);
            this.Controls.Add(this.J7N);
            this.Controls.Add(this.J7P);
            this.Controls.Add(this.J6N);
            this.Controls.Add(this.J6P);
            this.Controls.Add(this.J5N);
            this.Controls.Add(this.J5P);
            this.Controls.Add(this.J4N);
            this.Controls.Add(this.J4P);
            this.Controls.Add(this.J3N);
            this.Controls.Add(this.J3P);
            this.Controls.Add(this.J2N);
            this.Controls.Add(this.J2P);
            this.Controls.Add(this.J1N);
            this.Controls.Add(this.J1P);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.smoothness);
            this.Controls.Add(this.gamePad);
            this.Controls.Add(this.coordSelect);
            this.Controls.Add(this.reverse);
            this.Controls.Add(this.changeLens);
            this.Controls.Add(this.generatePath);
            this.Controls.Add(this.projectRate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.powerOn);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.recordRate);
            this.Controls.Add(this.portInput);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ipInput);
            this.Controls.Add(this.dollyDisplay);
            this.Controls.Add(this.rZDisplay);
            this.Controls.Add(this.rXDisplay);
            this.Controls.Add(this.rollDisplay);
            this.Controls.Add(this.rYDisplay);
            this.Controls.Add(this.camZDisplay);
            this.Controls.Add(this.camYDisplay);
            this.Controls.Add(this.camXDisplay);
            this.Controls.Add(this.focalLengthDisplay);
            this.Controls.Add(posView);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kinematic Lab Motion Control V0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(posView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smoothness)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jogSpeedBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rehearsalSpeedBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入配置文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出配置文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开路径ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存任务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读取机械臂配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 从ma文件导入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出到ma文件ToolStripMenuItem;
        private System.Windows.Forms.Label focalLengthDisplay;
        private System.Windows.Forms.Label camXDisplay;
        private System.Windows.Forms.Label camYDisplay;
        private System.Windows.Forms.Label camZDisplay;
        private System.Windows.Forms.Label rYDisplay;
        private System.Windows.Forms.Label rollDisplay;
        private System.Windows.Forms.Label rXDisplay;
        private System.Windows.Forms.Label rZDisplay;
        private System.Windows.Forms.Label dollyDisplay;
        private System.Windows.Forms.TextBox ipInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox portInput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button powerOn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox projectRate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox recordRate;
        private System.Windows.Forms.Button generatePath;
        private System.Windows.Forms.CheckBox reverse;
        private System.Windows.Forms.Button changeLens;
        private System.Windows.Forms.ComboBox coordSelect;
        private System.Windows.Forms.CheckBox gamePad;
        private System.Windows.Forms.TrackBar smoothness;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button J1P;
        private System.Windows.Forms.Button J2P;
        private System.Windows.Forms.Button J3P;
        private System.Windows.Forms.Button J4P;
        private System.Windows.Forms.Button J5P;
        private System.Windows.Forms.Button J6P;
        private System.Windows.Forms.Button J7P;
        private System.Windows.Forms.Button J8P;
        private System.Windows.Forms.Button J9P;
        private System.Windows.Forms.Button J1N;
        private System.Windows.Forms.Button J2N;
        private System.Windows.Forms.Button J3N;
        private System.Windows.Forms.Button J4N;
        private System.Windows.Forms.Button J5N;
        private System.Windows.Forms.Button J6N;
        private System.Windows.Forms.Button J7N;
        private System.Windows.Forms.Button J8N;
        private System.Windows.Forms.Button J9N;
        private System.Windows.Forms.TrackBar jogSpeedBar;
        private System.Windows.Forms.Label jogSpeed;
        private System.Windows.Forms.TrackBar pathBar;
        private System.Windows.Forms.Button moveTo;
        private System.Windows.Forms.Label maxFrame;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.Button fwdRun;
        private System.Windows.Forms.Button bckRun;
        private System.Windows.Forms.Button fwdStep;
        private System.Windows.Forms.Button bckStep;
        private System.Windows.Forms.Button addPos;
        private System.Windows.Forms.Button delPos;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.Button resetPath;
        private System.Windows.Forms.TrackBar rehearsalSpeedBar;
        private System.Windows.Forms.Label rehearsalSpeed;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel stausBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frame;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distance;
        private System.Windows.Forms.DataGridViewTextBoxColumn CamX;
        private System.Windows.Forms.DataGridViewTextBoxColumn CamY;
        private System.Windows.Forms.DataGridViewTextBoxColumn CamZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ry;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Line;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dash;
    }
}

