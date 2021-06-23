
namespace RMAP_tolmach
{
    partial class Form_main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_InitiatorLogicalAddress = new System.Windows.Forms.TextBox();
            this.textBox_TargetLogicalAddresses = new System.Windows.Forms.TextBox();
            this.label_TargetLogicalAddress = new System.Windows.Forms.Label();
            this.textBox_ProtocolIdentifier = new System.Windows.Forms.TextBox();
            this.label_ProtocolIdentifier = new System.Windows.Forms.Label();
            this.label_InitiatorLogicalAddress = new System.Windows.Forms.Label();
            this.textBox_Status = new System.Windows.Forms.TextBox();
            this.label_Status = new System.Windows.Forms.Label();
            this.label_Hex = new System.Windows.Forms.Label();
            this.textBox_packet = new System.Windows.Forms.TextBox();
            this.button_parsePacket = new System.Windows.Forms.Button();
            this.groupBox_endOfPacket = new System.Windows.Forms.GroupBox();
            this.radioButton_Eep = new System.Windows.Forms.RadioButton();
            this.radioButton_Eop = new System.Windows.Forms.RadioButton();
            this.textBox_DataLength = new System.Windows.Forms.TextBox();
            this.label_DataLength = new System.Windows.Forms.Label();
            this.button_daraCRC_calc = new System.Windows.Forms.Button();
            this.textBox_dataCRC = new System.Windows.Forms.TextBox();
            this.label_DataCrc = new System.Windows.Forms.Label();
            this.label_Data = new System.Windows.Forms.Label();
            this.textBox_Data = new System.Windows.Forms.TextBox();
            this.button_headerCRC_calc = new System.Windows.Forms.Button();
            this.textBox_headerCRC = new System.Windows.Forms.TextBox();
            this.label_HeaderCrc = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.label_Address = new System.Windows.Forms.Label();
            this.textBox_extendedAddress = new System.Windows.Forms.TextBox();
            this.label_ExtendedAddress = new System.Windows.Forms.Label();
            this.textBox_TransactionIdentifier = new System.Windows.Forms.TextBox();
            this.label_TransactionIdentifier = new System.Windows.Forms.Label();
            this.label_ReplayAddress = new System.Windows.Forms.Label();
            this.textBox_ReplayAddresses = new System.Windows.Forms.TextBox();
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.label_Key = new System.Windows.Forms.Label();
            this.Button_CreatePacket = new System.Windows.Forms.Button();
            this.textBox_TargetSpWAddresses = new System.Windows.Forms.TextBox();
            this.label_SpwAddress = new System.Windows.Forms.Label();
            this.groupBox_Instruction = new System.Windows.Forms.GroupBox();
            this.textBox_Instruction = new System.Windows.Forms.TextBox();
            this.groupBox_packetType = new System.Windows.Forms.GroupBox();
            this.radioButton_packetType_reply = new System.Windows.Forms.RadioButton();
            this.radioButton_packetType_command = new System.Windows.Forms.RadioButton();
            this.groupBox_commandCodes = new System.Windows.Forms.GroupBox();
            this.checkBox_commandCode_incAddress = new System.Windows.Forms.CheckBox();
            this.checkBox_commandCode_reply = new System.Windows.Forms.CheckBox();
            this.checkBox_commandCode_verify = new System.Windows.Forms.CheckBox();
            this.checkBox_commandCode_rw = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox_replyLength = new System.Windows.Forms.GroupBox();
            this.radioButton_replyAddrLength_12 = new System.Windows.Forms.RadioButton();
            this.radioButton_replyAddrLength_8 = new System.Windows.Forms.RadioButton();
            this.radioButton_replyAddrLength_4 = new System.Windows.Forms.RadioButton();
            this.radioButton_replyAddrLength_0 = new System.Windows.Forms.RadioButton();
            this.textBox_Console = new System.Windows.Forms.TextBox();
            this.consoleContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.copyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_endOfPacket.SuspendLayout();
            this.groupBox_Instruction.SuspendLayout();
            this.groupBox_packetType.SuspendLayout();
            this.groupBox_commandCodes.SuspendLayout();
            this.groupBox_replyLength.SuspendLayout();
            this.consoleContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 4);
            this.splitContainer1.MinimumSize = new System.Drawing.Size(700, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_Status);
            this.splitContainer1.Panel1.Controls.Add(this.label_Status);
            this.splitContainer1.Panel1.Controls.Add(this.label_Hex);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_packet);
            this.splitContainer1.Panel1.Controls.Add(this.button_parsePacket);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox_endOfPacket);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_DataLength);
            this.splitContainer1.Panel1.Controls.Add(this.label_DataLength);
            this.splitContainer1.Panel1.Controls.Add(this.button_daraCRC_calc);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_dataCRC);
            this.splitContainer1.Panel1.Controls.Add(this.label_DataCrc);
            this.splitContainer1.Panel1.Controls.Add(this.label_Data);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_Data);
            this.splitContainer1.Panel1.Controls.Add(this.button_headerCRC_calc);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_headerCRC);
            this.splitContainer1.Panel1.Controls.Add(this.label_HeaderCrc);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_address);
            this.splitContainer1.Panel1.Controls.Add(this.label_Address);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_extendedAddress);
            this.splitContainer1.Panel1.Controls.Add(this.label_ExtendedAddress);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_TransactionIdentifier);
            this.splitContainer1.Panel1.Controls.Add(this.label_TransactionIdentifier);
            this.splitContainer1.Panel1.Controls.Add(this.label_ReplayAddress);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_ReplayAddresses);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_Key);
            this.splitContainer1.Panel1.Controls.Add(this.label_Key);
            this.splitContainer1.Panel1.Controls.Add(this.Button_CreatePacket);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_TargetSpWAddresses);
            this.splitContainer1.Panel1.Controls.Add(this.label_SpwAddress);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox_Instruction);
            this.splitContainer1.Panel1MinSize = 300;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox_Console);
            this.splitContainer1.Panel2MinSize = 100;
            this.splitContainer1.Size = new System.Drawing.Size(727, 646);
            this.splitContainer1.SplitterDistance = 480;
            this.splitContainer1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.textBox_InitiatorLogicalAddress);
            this.groupBox1.Controls.Add(this.textBox_TargetLogicalAddresses);
            this.groupBox1.Controls.Add(this.label_TargetLogicalAddress);
            this.groupBox1.Controls.Add(this.textBox_ProtocolIdentifier);
            this.groupBox1.Controls.Add(this.label_ProtocolIdentifier);
            this.groupBox1.Controls.Add(this.label_InitiatorLogicalAddress);
            this.groupBox1.Location = new System.Drawing.Point(9, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 124);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ключевые поля";
            // 
            // textBox_InitiatorLogicalAddress
            // 
            this.textBox_InitiatorLogicalAddress.Location = new System.Drawing.Point(142, 59);
            this.textBox_InitiatorLogicalAddress.Name = "textBox_InitiatorLogicalAddress";
            this.textBox_InitiatorLogicalAddress.Size = new System.Drawing.Size(73, 23);
            this.textBox_InitiatorLogicalAddress.TabIndex = 20;
            this.textBox_InitiatorLogicalAddress.Text = "0x6B";
            // 
            // textBox_TargetLogicalAddresses
            // 
            this.textBox_TargetLogicalAddresses.Location = new System.Drawing.Point(142, 30);
            this.textBox_TargetLogicalAddresses.Name = "textBox_TargetLogicalAddresses";
            this.textBox_TargetLogicalAddresses.Size = new System.Drawing.Size(73, 23);
            this.textBox_TargetLogicalAddresses.TabIndex = 2;
            this.textBox_TargetLogicalAddresses.Text = "0xFE";
            // 
            // label_TargetLogicalAddress
            // 
            this.label_TargetLogicalAddress.AutoSize = true;
            this.label_TargetLogicalAddress.Location = new System.Drawing.Point(9, 33);
            this.label_TargetLogicalAddress.Name = "label_TargetLogicalAddress";
            this.label_TargetLogicalAddress.Size = new System.Drawing.Size(127, 15);
            this.label_TargetLogicalAddress.TabIndex = 4;
            this.label_TargetLogicalAddress.Text = "Target Logical Address";
            // 
            // textBox_ProtocolIdentifier
            // 
            this.textBox_ProtocolIdentifier.Location = new System.Drawing.Point(142, 88);
            this.textBox_ProtocolIdentifier.Name = "textBox_ProtocolIdentifier";
            this.textBox_ProtocolIdentifier.Size = new System.Drawing.Size(73, 23);
            this.textBox_ProtocolIdentifier.TabIndex = 8;
            this.textBox_ProtocolIdentifier.Text = "0x01";
            // 
            // label_ProtocolIdentifier
            // 
            this.label_ProtocolIdentifier.AutoSize = true;
            this.label_ProtocolIdentifier.Location = new System.Drawing.Point(34, 91);
            this.label_ProtocolIdentifier.Name = "label_ProtocolIdentifier";
            this.label_ProtocolIdentifier.Size = new System.Drawing.Size(102, 15);
            this.label_ProtocolIdentifier.TabIndex = 9;
            this.label_ProtocolIdentifier.Text = "Protocol Identifier";
            // 
            // label_InitiatorLogicalAddress
            // 
            this.label_InitiatorLogicalAddress.AutoSize = true;
            this.label_InitiatorLogicalAddress.Location = new System.Drawing.Point(2, 62);
            this.label_InitiatorLogicalAddress.Name = "label_InitiatorLogicalAddress";
            this.label_InitiatorLogicalAddress.Size = new System.Drawing.Size(134, 15);
            this.label_InitiatorLogicalAddress.TabIndex = 19;
            this.label_InitiatorLogicalAddress.Text = "Initiator Logical Address";
            // 
            // textBox_Status
            // 
            this.textBox_Status.Enabled = false;
            this.textBox_Status.Location = new System.Drawing.Point(96, 292);
            this.textBox_Status.Name = "textBox_Status";
            this.textBox_Status.Size = new System.Drawing.Size(78, 23);
            this.textBox_Status.TabIndex = 43;
            this.textBox_Status.Text = "0x00";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Enabled = false;
            this.label_Status.Location = new System.Drawing.Point(96, 274);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(39, 15);
            this.label_Status.TabIndex = 42;
            this.label_Status.Text = "Status";
            // 
            // label_Hex
            // 
            this.label_Hex.AutoSize = true;
            this.label_Hex.Location = new System.Drawing.Point(10, 10);
            this.label_Hex.Name = "label_Hex";
            this.label_Hex.Size = new System.Drawing.Size(29, 15);
            this.label_Hex.TabIndex = 41;
            this.label_Hex.Text = "HEX";
            // 
            // textBox_packet
            // 
            this.textBox_packet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_packet.Location = new System.Drawing.Point(45, 7);
            this.textBox_packet.Name = "textBox_packet";
            this.textBox_packet.Size = new System.Drawing.Size(670, 23);
            this.textBox_packet.TabIndex = 40;
            // 
            // button_parsePacket
            // 
            this.button_parsePacket.Image = ((System.Drawing.Image)(resources.GetObject("button_parsePacket.Image")));
            this.button_parsePacket.Location = new System.Drawing.Point(392, 48);
            this.button_parsePacket.Name = "button_parsePacket";
            this.button_parsePacket.Size = new System.Drawing.Size(109, 24);
            this.button_parsePacket.TabIndex = 39;
            this.button_parsePacket.UseVisualStyleBackColor = true;
            this.button_parsePacket.Click += new System.EventHandler(this.button_parsePacket_Click);
            // 
            // groupBox_endOfPacket
            // 
            this.groupBox_endOfPacket.Controls.Add(this.radioButton_Eep);
            this.groupBox_endOfPacket.Controls.Add(this.radioButton_Eop);
            this.groupBox_endOfPacket.Location = new System.Drawing.Point(572, 374);
            this.groupBox_endOfPacket.Name = "groupBox_endOfPacket";
            this.groupBox_endOfPacket.Size = new System.Drawing.Size(145, 52);
            this.groupBox_endOfPacket.TabIndex = 38;
            this.groupBox_endOfPacket.TabStop = false;
            this.groupBox_endOfPacket.Text = "Символ конца пакета";
            // 
            // radioButton_Eep
            // 
            this.radioButton_Eep.AutoSize = true;
            this.radioButton_Eep.Location = new System.Drawing.Point(77, 27);
            this.radioButton_Eep.Name = "radioButton_Eep";
            this.radioButton_Eep.Size = new System.Drawing.Size(44, 19);
            this.radioButton_Eep.TabIndex = 1;
            this.radioButton_Eep.Text = "EEP";
            this.radioButton_Eep.UseVisualStyleBackColor = true;
            // 
            // radioButton_Eop
            // 
            this.radioButton_Eop.AutoSize = true;
            this.radioButton_Eop.Checked = true;
            this.radioButton_Eop.Cursor = System.Windows.Forms.Cursors.Default;
            this.radioButton_Eop.Location = new System.Drawing.Point(17, 27);
            this.radioButton_Eop.Name = "radioButton_Eop";
            this.radioButton_Eop.Size = new System.Drawing.Size(47, 19);
            this.radioButton_Eop.TabIndex = 0;
            this.radioButton_Eop.TabStop = true;
            this.radioButton_Eop.Text = "EOP";
            this.radioButton_Eop.UseVisualStyleBackColor = true;
            // 
            // textBox_DataLength
            // 
            this.textBox_DataLength.Location = new System.Drawing.Point(10, 392);
            this.textBox_DataLength.Name = "textBox_DataLength";
            this.textBox_DataLength.Size = new System.Drawing.Size(120, 23);
            this.textBox_DataLength.TabIndex = 37;
            this.textBox_DataLength.Text = "0x000008";
            // 
            // label_DataLength
            // 
            this.label_DataLength.AutoSize = true;
            this.label_DataLength.Location = new System.Drawing.Point(10, 374);
            this.label_DataLength.Name = "label_DataLength";
            this.label_DataLength.Size = new System.Drawing.Size(122, 15);
            this.label_DataLength.TabIndex = 36;
            this.label_DataLength.Text = "Data Length (3 байта)";
            // 
            // button_daraCRC_calc
            // 
            this.button_daraCRC_calc.Location = new System.Drawing.Point(396, 397);
            this.button_daraCRC_calc.Name = "button_daraCRC_calc";
            this.button_daraCRC_calc.Size = new System.Drawing.Size(86, 23);
            this.button_daraCRC_calc.TabIndex = 34;
            this.button_daraCRC_calc.Text = "Рассчитать";
            this.button_daraCRC_calc.UseVisualStyleBackColor = true;
            this.button_daraCRC_calc.Click += new System.EventHandler(this.button_daraCRC_calc_Click);
            // 
            // textBox_dataCRC
            // 
            this.textBox_dataCRC.Location = new System.Drawing.Point(317, 397);
            this.textBox_dataCRC.Name = "textBox_dataCRC";
            this.textBox_dataCRC.Size = new System.Drawing.Size(73, 23);
            this.textBox_dataCRC.TabIndex = 33;
            this.textBox_dataCRC.Text = "0x00";
            // 
            // label_DataCrc
            // 
            this.label_DataCrc.AutoSize = true;
            this.label_DataCrc.Location = new System.Drawing.Point(254, 400);
            this.label_DataCrc.Name = "label_DataCrc";
            this.label_DataCrc.Size = new System.Drawing.Size(57, 15);
            this.label_DataCrc.TabIndex = 32;
            this.label_DataCrc.Text = "Data CRC";
            // 
            // label_Data
            // 
            this.label_Data.AutoSize = true;
            this.label_Data.Location = new System.Drawing.Point(10, 423);
            this.label_Data.Name = "label_Data";
            this.label_Data.Size = new System.Drawing.Size(99, 15);
            this.label_Data.TabIndex = 31;
            this.label_Data.Text = "Data (по 4 байта)";
            // 
            // textBox_Data
            // 
            this.textBox_Data.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Data.Location = new System.Drawing.Point(9, 441);
            this.textBox_Data.Name = "textBox_Data";
            this.textBox_Data.Size = new System.Drawing.Size(706, 23);
            this.textBox_Data.TabIndex = 30;
            this.textBox_Data.Text = "0x01020304 0x01020304";
            // 
            // button_headerCRC_calc
            // 
            this.button_headerCRC_calc.Location = new System.Drawing.Point(396, 371);
            this.button_headerCRC_calc.Name = "button_headerCRC_calc";
            this.button_headerCRC_calc.Size = new System.Drawing.Size(86, 23);
            this.button_headerCRC_calc.TabIndex = 29;
            this.button_headerCRC_calc.Text = "Рассчитать";
            this.button_headerCRC_calc.UseVisualStyleBackColor = true;
            this.button_headerCRC_calc.Click += new System.EventHandler(this.button_headerCRC_calc_Click);
            // 
            // textBox_headerCRC
            // 
            this.textBox_headerCRC.Location = new System.Drawing.Point(317, 371);
            this.textBox_headerCRC.Name = "textBox_headerCRC";
            this.textBox_headerCRC.Size = new System.Drawing.Size(73, 23);
            this.textBox_headerCRC.TabIndex = 28;
            this.textBox_headerCRC.Text = "0x00";
            // 
            // label_HeaderCrc
            // 
            this.label_HeaderCrc.AutoSize = true;
            this.label_HeaderCrc.Location = new System.Drawing.Point(240, 374);
            this.label_HeaderCrc.Name = "label_HeaderCrc";
            this.label_HeaderCrc.Size = new System.Drawing.Size(71, 15);
            this.label_HeaderCrc.TabIndex = 27;
            this.label_HeaderCrc.Text = "Header CRC";
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(352, 292);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(105, 23);
            this.textBox_address.TabIndex = 26;
            this.textBox_address.Text = "0x00002100";
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Location = new System.Drawing.Point(358, 274);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(100, 15);
            this.label_Address.TabIndex = 25;
            this.label_Address.Text = "Address (4 байта)";
            // 
            // textBox_extendedAddress
            // 
            this.textBox_extendedAddress.Location = new System.Drawing.Point(251, 292);
            this.textBox_extendedAddress.Name = "textBox_extendedAddress";
            this.textBox_extendedAddress.Size = new System.Drawing.Size(100, 23);
            this.textBox_extendedAddress.TabIndex = 24;
            this.textBox_extendedAddress.Text = "0x00";
            this.textBox_extendedAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_ExtendedAddress
            // 
            this.label_ExtendedAddress.AutoSize = true;
            this.label_ExtendedAddress.Location = new System.Drawing.Point(251, 274);
            this.label_ExtendedAddress.Name = "label_ExtendedAddress";
            this.label_ExtendedAddress.Size = new System.Drawing.Size(100, 15);
            this.label_ExtendedAddress.TabIndex = 23;
            this.label_ExtendedAddress.Text = "Extended Address";
            // 
            // textBox_TransactionIdentifier
            // 
            this.textBox_TransactionIdentifier.Location = new System.Drawing.Point(547, 292);
            this.textBox_TransactionIdentifier.Name = "textBox_TransactionIdentifier";
            this.textBox_TransactionIdentifier.Size = new System.Drawing.Size(170, 23);
            this.textBox_TransactionIdentifier.TabIndex = 22;
            this.textBox_TransactionIdentifier.Text = "0x3925";
            // 
            // label_TransactionIdentifier
            // 
            this.label_TransactionIdentifier.AutoSize = true;
            this.label_TransactionIdentifier.Location = new System.Drawing.Point(547, 274);
            this.label_TransactionIdentifier.Name = "label_TransactionIdentifier";
            this.label_TransactionIdentifier.Size = new System.Drawing.Size(170, 15);
            this.label_TransactionIdentifier.TabIndex = 21;
            this.label_TransactionIdentifier.Text = "Transaction Identifier (2 байта)";
            // 
            // label_ReplayAddress
            // 
            this.label_ReplayAddress.AutoSize = true;
            this.label_ReplayAddress.Location = new System.Drawing.Point(10, 318);
            this.label_ReplayAddress.Name = "label_ReplayAddress";
            this.label_ReplayAddress.Size = new System.Drawing.Size(98, 15);
            this.label_ReplayAddress.TabIndex = 18;
            this.label_ReplayAddress.Text = "Replay Addresses";
            // 
            // textBox_ReplayAddresses
            // 
            this.textBox_ReplayAddresses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ReplayAddresses.Location = new System.Drawing.Point(10, 336);
            this.textBox_ReplayAddresses.Name = "textBox_ReplayAddresses";
            this.textBox_ReplayAddresses.Size = new System.Drawing.Size(705, 23);
            this.textBox_ReplayAddresses.TabIndex = 17;
            this.textBox_ReplayAddresses.Text = "0x08 0x1C 0x04 0x0d";
            // 
            // textBox_Key
            // 
            this.textBox_Key.Location = new System.Drawing.Point(9, 292);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.Size = new System.Drawing.Size(81, 23);
            this.textBox_Key.TabIndex = 16;
            this.textBox_Key.Text = "0x02";
            // 
            // label_Key
            // 
            this.label_Key.AutoSize = true;
            this.label_Key.Location = new System.Drawing.Point(9, 274);
            this.label_Key.Name = "label_Key";
            this.label_Key.Size = new System.Drawing.Size(26, 15);
            this.label_Key.TabIndex = 15;
            this.label_Key.Text = "Key";
            // 
            // Button_CreatePacket
            // 
            this.Button_CreatePacket.Image = ((System.Drawing.Image)(resources.GetObject("Button_CreatePacket.Image")));
            this.Button_CreatePacket.Location = new System.Drawing.Point(277, 48);
            this.Button_CreatePacket.Name = "Button_CreatePacket";
            this.Button_CreatePacket.Size = new System.Drawing.Size(109, 24);
            this.Button_CreatePacket.TabIndex = 5;
            this.Button_CreatePacket.UseVisualStyleBackColor = true;
            this.Button_CreatePacket.Click += new System.EventHandler(this.button_packetGenerate_Click);
            // 
            // textBox_TargetSpWAddresses
            // 
            this.textBox_TargetSpWAddresses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_TargetSpWAddresses.Location = new System.Drawing.Point(9, 90);
            this.textBox_TargetSpWAddresses.Name = "textBox_TargetSpWAddresses";
            this.textBox_TargetSpWAddresses.Size = new System.Drawing.Size(706, 23);
            this.textBox_TargetSpWAddresses.TabIndex = 0;
            this.textBox_TargetSpWAddresses.Text = "0x00 0x00";
            // 
            // label_SpwAddress
            // 
            this.label_SpwAddress.AutoSize = true;
            this.label_SpwAddress.Location = new System.Drawing.Point(10, 72);
            this.label_SpwAddress.Name = "label_SpwAddress";
            this.label_SpwAddress.Size = new System.Drawing.Size(87, 15);
            this.label_SpwAddress.TabIndex = 3;
            this.label_SpwAddress.Text = "SpW Addresses";
            // 
            // groupBox_Instruction
            // 
            this.groupBox_Instruction.Controls.Add(this.textBox_Instruction);
            this.groupBox_Instruction.Controls.Add(this.groupBox_packetType);
            this.groupBox_Instruction.Controls.Add(this.groupBox_commandCodes);
            this.groupBox_Instruction.Controls.Add(this.groupBox_replyLength);
            this.groupBox_Instruction.Location = new System.Drawing.Point(268, 125);
            this.groupBox_Instruction.Name = "groupBox_Instruction";
            this.groupBox_Instruction.Size = new System.Drawing.Size(447, 124);
            this.groupBox_Instruction.TabIndex = 44;
            this.groupBox_Instruction.TabStop = false;
            this.groupBox_Instruction.Text = "Instruction";
            // 
            // textBox_Instruction
            // 
            this.textBox_Instruction.Location = new System.Drawing.Point(5, 15);
            this.textBox_Instruction.Name = "textBox_Instruction";
            this.textBox_Instruction.Size = new System.Drawing.Size(73, 23);
            this.textBox_Instruction.TabIndex = 11;
            this.textBox_Instruction.Text = "0x4d";
            this.textBox_Instruction.TextChanged += new System.EventHandler(this.TextBoxInstruction_Chenged);
            // 
            // groupBox_packetType
            // 
            this.groupBox_packetType.Controls.Add(this.radioButton_packetType_reply);
            this.groupBox_packetType.Controls.Add(this.radioButton_packetType_command);
            this.groupBox_packetType.Location = new System.Drawing.Point(5, 46);
            this.groupBox_packetType.Name = "groupBox_packetType";
            this.groupBox_packetType.Size = new System.Drawing.Size(84, 73);
            this.groupBox_packetType.TabIndex = 12;
            this.groupBox_packetType.TabStop = false;
            this.groupBox_packetType.Text = "Тип пакета";
            // 
            // radioButton_packetType_reply
            // 
            this.radioButton_packetType_reply.AutoSize = true;
            this.radioButton_packetType_reply.Location = new System.Drawing.Point(7, 49);
            this.radioButton_packetType_reply.Name = "radioButton_packetType_reply";
            this.radioButton_packetType_reply.Size = new System.Drawing.Size(56, 19);
            this.radioButton_packetType_reply.TabIndex = 1;
            this.radioButton_packetType_reply.Text = "Ответ";
            this.radioButton_packetType_reply.UseVisualStyleBackColor = true;
            this.radioButton_packetType_reply.CheckedChanged += new System.EventHandler(this.InstructionControls_Chenged);
            // 
            // radioButton_packetType_command
            // 
            this.radioButton_packetType_command.AutoSize = true;
            this.radioButton_packetType_command.Checked = true;
            this.radioButton_packetType_command.Location = new System.Drawing.Point(7, 23);
            this.radioButton_packetType_command.Name = "radioButton_packetType_command";
            this.radioButton_packetType_command.Size = new System.Drawing.Size(73, 19);
            this.radioButton_packetType_command.TabIndex = 0;
            this.radioButton_packetType_command.TabStop = true;
            this.radioButton_packetType_command.Text = "Команда";
            this.radioButton_packetType_command.UseVisualStyleBackColor = true;
            this.radioButton_packetType_command.CheckedChanged += new System.EventHandler(this.InstructionControls_Chenged);
            // 
            // groupBox_commandCodes
            // 
            this.groupBox_commandCodes.Controls.Add(this.checkBox_commandCode_incAddress);
            this.groupBox_commandCodes.Controls.Add(this.checkBox_commandCode_reply);
            this.groupBox_commandCodes.Controls.Add(this.checkBox_commandCode_verify);
            this.groupBox_commandCodes.Controls.Add(this.checkBox_commandCode_rw);
            this.groupBox_commandCodes.Controls.Add(this.label8);
            this.groupBox_commandCodes.Controls.Add(this.label5);
            this.groupBox_commandCodes.Controls.Add(this.label6);
            this.groupBox_commandCodes.Controls.Add(this.label7);
            this.groupBox_commandCodes.Location = new System.Drawing.Point(95, 10);
            this.groupBox_commandCodes.Name = "groupBox_commandCodes";
            this.groupBox_commandCodes.Size = new System.Drawing.Size(215, 109);
            this.groupBox_commandCodes.TabIndex = 13;
            this.groupBox_commandCodes.TabStop = false;
            this.groupBox_commandCodes.Text = "Код команды";
            // 
            // checkBox_commandCode_incAddress
            // 
            this.checkBox_commandCode_incAddress.AutoSize = true;
            this.checkBox_commandCode_incAddress.Checked = true;
            this.checkBox_commandCode_incAddress.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_commandCode_incAddress.Location = new System.Drawing.Point(175, 84);
            this.checkBox_commandCode_incAddress.Name = "checkBox_commandCode_incAddress";
            this.checkBox_commandCode_incAddress.Size = new System.Drawing.Size(15, 14);
            this.checkBox_commandCode_incAddress.TabIndex = 7;
            this.checkBox_commandCode_incAddress.UseVisualStyleBackColor = true;
            this.checkBox_commandCode_incAddress.CheckedChanged += new System.EventHandler(this.InstructionControls_Chenged);
            // 
            // checkBox_commandCode_reply
            // 
            this.checkBox_commandCode_reply.AutoSize = true;
            this.checkBox_commandCode_reply.Checked = true;
            this.checkBox_commandCode_reply.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_commandCode_reply.Location = new System.Drawing.Point(125, 84);
            this.checkBox_commandCode_reply.Name = "checkBox_commandCode_reply";
            this.checkBox_commandCode_reply.Size = new System.Drawing.Size(15, 14);
            this.checkBox_commandCode_reply.TabIndex = 6;
            this.checkBox_commandCode_reply.UseVisualStyleBackColor = true;
            this.checkBox_commandCode_reply.CheckedChanged += new System.EventHandler(this.InstructionControls_Chenged);
            // 
            // checkBox_commandCode_verify
            // 
            this.checkBox_commandCode_verify.AutoSize = true;
            this.checkBox_commandCode_verify.Location = new System.Drawing.Point(75, 84);
            this.checkBox_commandCode_verify.Name = "checkBox_commandCode_verify";
            this.checkBox_commandCode_verify.Size = new System.Drawing.Size(15, 14);
            this.checkBox_commandCode_verify.TabIndex = 5;
            this.checkBox_commandCode_verify.UseVisualStyleBackColor = true;
            this.checkBox_commandCode_verify.CheckedChanged += new System.EventHandler(this.InstructionControls_Chenged);
            // 
            // checkBox_commandCode_rw
            // 
            this.checkBox_commandCode_rw.AutoSize = true;
            this.checkBox_commandCode_rw.Checked = true;
            this.checkBox_commandCode_rw.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_commandCode_rw.Location = new System.Drawing.Point(25, 84);
            this.checkBox_commandCode_rw.Name = "checkBox_commandCode_rw";
            this.checkBox_commandCode_rw.Size = new System.Drawing.Size(15, 14);
            this.checkBox_commandCode_rw.TabIndex = 4;
            this.checkBox_commandCode_rw.UseVisualStyleBackColor = true;
            this.checkBox_commandCode_rw.CheckedChanged += new System.EventHandler(this.InstructionControls_Chenged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(151, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 30);
            this.label8.TabIndex = 3;
            this.label8.Text = "Increment\r\n  address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Write/\r\n Read";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 45);
            this.label6.TabIndex = 1;
            this.label6.Text = "Verify data\r\n    before \r\n     write";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Reply";
            // 
            // groupBox_replyLength
            // 
            this.groupBox_replyLength.Controls.Add(this.radioButton_replyAddrLength_12);
            this.groupBox_replyLength.Controls.Add(this.radioButton_replyAddrLength_8);
            this.groupBox_replyLength.Controls.Add(this.radioButton_replyAddrLength_4);
            this.groupBox_replyLength.Controls.Add(this.radioButton_replyAddrLength_0);
            this.groupBox_replyLength.Location = new System.Drawing.Point(313, 10);
            this.groupBox_replyLength.Name = "groupBox_replyLength";
            this.groupBox_replyLength.Size = new System.Drawing.Size(130, 109);
            this.groupBox_replyLength.TabIndex = 14;
            this.groupBox_replyLength.TabStop = false;
            this.groupBox_replyLength.Text = "Длина reply-адреса";
            // 
            // radioButton_replyAddrLength_12
            // 
            this.radioButton_replyAddrLength_12.AutoSize = true;
            this.radioButton_replyAddrLength_12.Location = new System.Drawing.Point(25, 81);
            this.radioButton_replyAddrLength_12.Name = "radioButton_replyAddrLength_12";
            this.radioButton_replyAddrLength_12.Size = new System.Drawing.Size(65, 19);
            this.radioButton_replyAddrLength_12.TabIndex = 3;
            this.radioButton_replyAddrLength_12.Text = "12 байт";
            this.radioButton_replyAddrLength_12.UseVisualStyleBackColor = true;
            this.radioButton_replyAddrLength_12.CheckedChanged += new System.EventHandler(this.InstructionControls_Chenged);
            // 
            // radioButton_replyAddrLength_8
            // 
            this.radioButton_replyAddrLength_8.AutoSize = true;
            this.radioButton_replyAddrLength_8.Location = new System.Drawing.Point(25, 61);
            this.radioButton_replyAddrLength_8.Name = "radioButton_replyAddrLength_8";
            this.radioButton_replyAddrLength_8.Size = new System.Drawing.Size(59, 19);
            this.radioButton_replyAddrLength_8.TabIndex = 2;
            this.radioButton_replyAddrLength_8.Text = "8 байт";
            this.radioButton_replyAddrLength_8.UseVisualStyleBackColor = true;
            this.radioButton_replyAddrLength_8.CheckedChanged += new System.EventHandler(this.InstructionControls_Chenged);
            // 
            // radioButton_replyAddrLength_4
            // 
            this.radioButton_replyAddrLength_4.AutoSize = true;
            this.radioButton_replyAddrLength_4.Checked = true;
            this.radioButton_replyAddrLength_4.Location = new System.Drawing.Point(25, 41);
            this.radioButton_replyAddrLength_4.Name = "radioButton_replyAddrLength_4";
            this.radioButton_replyAddrLength_4.Size = new System.Drawing.Size(65, 19);
            this.radioButton_replyAddrLength_4.TabIndex = 1;
            this.radioButton_replyAddrLength_4.TabStop = true;
            this.radioButton_replyAddrLength_4.Text = "4 байта";
            this.radioButton_replyAddrLength_4.UseVisualStyleBackColor = true;
            this.radioButton_replyAddrLength_4.CheckedChanged += new System.EventHandler(this.InstructionControls_Chenged);
            // 
            // radioButton_replyAddrLength_0
            // 
            this.radioButton_replyAddrLength_0.AutoSize = true;
            this.radioButton_replyAddrLength_0.Location = new System.Drawing.Point(25, 21);
            this.radioButton_replyAddrLength_0.Name = "radioButton_replyAddrLength_0";
            this.radioButton_replyAddrLength_0.Size = new System.Drawing.Size(59, 19);
            this.radioButton_replyAddrLength_0.TabIndex = 0;
            this.radioButton_replyAddrLength_0.Text = "0 байт";
            this.radioButton_replyAddrLength_0.UseVisualStyleBackColor = true;
            this.radioButton_replyAddrLength_0.CheckedChanged += new System.EventHandler(this.InstructionControls_Chenged);
            // 
            // textBox_Console
            // 
            this.textBox_Console.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Console.ContextMenuStrip = this.consoleContextMenu;
            this.textBox_Console.Location = new System.Drawing.Point(7, 7);
            this.textBox_Console.MinimumSize = new System.Drawing.Size(100, 100);
            this.textBox_Console.Multiline = true;
            this.textBox_Console.Name = "textBox_Console";
            this.textBox_Console.ReadOnly = true;
            this.textBox_Console.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Console.Size = new System.Drawing.Size(713, 150);
            this.textBox_Console.TabIndex = 7;
            // 
            // consoleContextMenu
            // 
            this.consoleContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMenuItem});
            this.consoleContextMenu.Name = "clearConsole";
            this.consoleContextMenu.Size = new System.Drawing.Size(195, 26);
            // 
            // statusMenuItem
            // 
            this.statusMenuItem.Name = "statusMenuItem";
            this.statusMenuItem.Size = new System.Drawing.Size(194, 22);
            this.statusMenuItem.Text = "Вывести статус полей";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(300, 202);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 15);
            this.label13.TabIndex = 21;
            this.label13.Text = "Initiator Logical Address";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(440, 199);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(73, 23);
            this.textBox2.TabIndex = 22;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(109, 196);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(618, 23);
            this.textBox3.TabIndex = 30;
            this.textBox3.Text = "0x00 0x00";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(5, 199);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(98, 15);
            this.label18.TabIndex = 31;
            this.label18.Text = "Replay Addresses";
            // 
            // copyMenuItem
            // 
            this.copyMenuItem.Name = "copyMenuItem";
            this.copyMenuItem.Size = new System.Drawing.Size(32, 19);
            this.copyMenuItem.Text = "Копировать";
            // 
            // clearMenuItem
            // 
            this.clearMenuItem.Name = "clearMenuItem";
            this.clearMenuItem.Size = new System.Drawing.Size(32, 19);
            this.clearMenuItem.Text = "Очистить";
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 662);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(750, 700);
            this.Name = "Form_main";
            this.Text = "RMAP tolmach";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_endOfPacket.ResumeLayout(false);
            this.groupBox_endOfPacket.PerformLayout();
            this.groupBox_Instruction.ResumeLayout(false);
            this.groupBox_Instruction.PerformLayout();
            this.groupBox_packetType.ResumeLayout(false);
            this.groupBox_packetType.PerformLayout();
            this.groupBox_commandCodes.ResumeLayout(false);
            this.groupBox_commandCodes.PerformLayout();
            this.groupBox_replyLength.ResumeLayout(false);
            this.groupBox_replyLength.PerformLayout();
            this.consoleContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBox_Console;
        private System.Windows.Forms.ContextMenuStrip consoleContextMenu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ToolStripMenuItem copyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusMenuItem;
        private System.Windows.Forms.TextBox textBox_Status;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Label label_Hex;
        private System.Windows.Forms.TextBox textBox_packet;
        private System.Windows.Forms.Button button_parsePacket;
        private System.Windows.Forms.GroupBox groupBox_endOfPacket;
        private System.Windows.Forms.RadioButton radioButton_Eep;
        private System.Windows.Forms.RadioButton radioButton_Eop;
        private System.Windows.Forms.TextBox textBox_DataLength;
        private System.Windows.Forms.Label label_DataLength;
        private System.Windows.Forms.Button button_daraCRC_calc;
        private System.Windows.Forms.TextBox textBox_dataCRC;
        private System.Windows.Forms.Label label_DataCrc;
        private System.Windows.Forms.Label label_Data;
        private System.Windows.Forms.TextBox textBox_Data;
        private System.Windows.Forms.Button button_headerCRC_calc;
        private System.Windows.Forms.TextBox textBox_headerCRC;
        private System.Windows.Forms.Label label_HeaderCrc;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.TextBox textBox_extendedAddress;
        private System.Windows.Forms.Label label_ExtendedAddress;
        private System.Windows.Forms.TextBox textBox_TransactionIdentifier;
        private System.Windows.Forms.Label label_TransactionIdentifier;
        private System.Windows.Forms.TextBox textBox_InitiatorLogicalAddress;
        private System.Windows.Forms.Label label_InitiatorLogicalAddress;
        private System.Windows.Forms.Label label_ReplayAddress;
        private System.Windows.Forms.TextBox textBox_ReplayAddresses;
        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.Label label_Key;
        private System.Windows.Forms.GroupBox groupBox_replyLength;
        private System.Windows.Forms.RadioButton radioButton_replyAddrLength_12;
        private System.Windows.Forms.RadioButton radioButton_replyAddrLength_8;
        private System.Windows.Forms.RadioButton radioButton_replyAddrLength_4;
        private System.Windows.Forms.RadioButton radioButton_replyAddrLength_0;
        private System.Windows.Forms.GroupBox groupBox_commandCodes;
        private System.Windows.Forms.CheckBox checkBox_commandCode_incAddress;
        private System.Windows.Forms.CheckBox checkBox_commandCode_reply;
        private System.Windows.Forms.CheckBox checkBox_commandCode_verify;
        private System.Windows.Forms.CheckBox checkBox_commandCode_rw;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox_packetType;
        private System.Windows.Forms.RadioButton radioButton_packetType_reply;
        private System.Windows.Forms.RadioButton radioButton_packetType_command;
        private System.Windows.Forms.TextBox textBox_Instruction;
        private System.Windows.Forms.Label label_ProtocolIdentifier;
        private System.Windows.Forms.TextBox textBox_ProtocolIdentifier;
        private System.Windows.Forms.Button Button_CreatePacket;
        private System.Windows.Forms.Label label_TargetLogicalAddress;
        private System.Windows.Forms.TextBox textBox_TargetSpWAddresses;
        private System.Windows.Forms.Label label_SpwAddress;
        private System.Windows.Forms.TextBox textBox_TargetLogicalAddresses;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox_Instruction;
    }
}

