
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
            this.tabControl_selectCommand = new System.Windows.Forms.TabControl();
            this.tabPage_write = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox_packet = new System.Windows.Forms.TextBox();
            this.button_parsePacket = new System.Windows.Forms.Button();
            this.groupBox_endOfPacket = new System.Windows.Forms.GroupBox();
            this.radioButton_Eep = new System.Windows.Forms.RadioButton();
            this.radioButton_Eop = new System.Windows.Forms.RadioButton();
            this.textBox_DataLength = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.button_daraCRC_calc = new System.Windows.Forms.Button();
            this.textBox_dataCRC = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_Data = new System.Windows.Forms.TextBox();
            this.button_headerCRC_calc = new System.Windows.Forms.Button();
            this.textBox_headerCRC = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_extendedAddress = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_TransactionIdentifier = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_InitiatorLogicalAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_ReplayAddresses = new System.Windows.Forms.TextBox();
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox_replyLength = new System.Windows.Forms.GroupBox();
            this.radioButton_replyAddrLength_12 = new System.Windows.Forms.RadioButton();
            this.radioButton_replyAddrLength_8 = new System.Windows.Forms.RadioButton();
            this.radioButton_replyAddrLength_4 = new System.Windows.Forms.RadioButton();
            this.radioButton_replyAddrLength_0 = new System.Windows.Forms.RadioButton();
            this.groupBox_commandCodes = new System.Windows.Forms.GroupBox();
            this.checkBox_commandCode_incAddress = new System.Windows.Forms.CheckBox();
            this.checkBox_commandCode_reply = new System.Windows.Forms.CheckBox();
            this.checkBox_commandCode_verify = new System.Windows.Forms.CheckBox();
            this.checkBox_commandCode_rw = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox_packetType = new System.Windows.Forms.GroupBox();
            this.radioButton_packetType_reply = new System.Windows.Forms.RadioButton();
            this.radioButton_packetType_command = new System.Windows.Forms.RadioButton();
            this.textBox_Instruction = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ProtocolIdentifier = new System.Windows.Forms.TextBox();
            this.Button_CreatePacket = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_TargetSpWAddresses = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_TargetLogicalAddresses = new System.Windows.Forms.TextBox();
            this.tabPage_reply = new System.Windows.Forms.TabPage();
            this.textBox_Console = new System.Windows.Forms.TextBox();
            this.consoleContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            this.tabControl_selectCommand.SuspendLayout();
            this.tabPage_write.SuspendLayout();
            this.groupBox_endOfPacket.SuspendLayout();
            this.groupBox_replyLength.SuspendLayout();
            this.groupBox_commandCodes.SuspendLayout();
            this.groupBox_packetType.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 4);
            this.splitContainer1.MinimumSize = new System.Drawing.Size(800, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.tabControl_selectCommand);
            this.splitContainer1.Panel1MinSize = 300;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox_Console);
            this.splitContainer1.Panel2MinSize = 100;
            this.splitContainer1.Size = new System.Drawing.Size(819, 652);
            this.splitContainer1.SplitterDistance = 514;
            this.splitContainer1.TabIndex = 7;
            // 
            // tabControl_selectCommand
            // 
            this.tabControl_selectCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_selectCommand.Controls.Add(this.tabPage_write);
            this.tabControl_selectCommand.Controls.Add(this.tabPage_reply);
            this.tabControl_selectCommand.Location = new System.Drawing.Point(3, 3);
            this.tabControl_selectCommand.MinimumSize = new System.Drawing.Size(750, 100);
            this.tabControl_selectCommand.Multiline = true;
            this.tabControl_selectCommand.Name = "tabControl_selectCommand";
            this.tabControl_selectCommand.SelectedIndex = 0;
            this.tabControl_selectCommand.Size = new System.Drawing.Size(813, 508);
            this.tabControl_selectCommand.TabIndex = 6;
            // 
            // tabPage_write
            // 
            this.tabPage_write.AutoScroll = true;
            this.tabPage_write.Controls.Add(this.label21);
            this.tabPage_write.Controls.Add(this.textBox_packet);
            this.tabPage_write.Controls.Add(this.button_parsePacket);
            this.tabPage_write.Controls.Add(this.groupBox_endOfPacket);
            this.tabPage_write.Controls.Add(this.textBox_DataLength);
            this.tabPage_write.Controls.Add(this.label20);
            this.tabPage_write.Controls.Add(this.button_daraCRC_calc);
            this.tabPage_write.Controls.Add(this.textBox_dataCRC);
            this.tabPage_write.Controls.Add(this.label19);
            this.tabPage_write.Controls.Add(this.label17);
            this.tabPage_write.Controls.Add(this.textBox_Data);
            this.tabPage_write.Controls.Add(this.button_headerCRC_calc);
            this.tabPage_write.Controls.Add(this.textBox_headerCRC);
            this.tabPage_write.Controls.Add(this.label16);
            this.tabPage_write.Controls.Add(this.textBox_address);
            this.tabPage_write.Controls.Add(this.label15);
            this.tabPage_write.Controls.Add(this.textBox_extendedAddress);
            this.tabPage_write.Controls.Add(this.label14);
            this.tabPage_write.Controls.Add(this.textBox_TransactionIdentifier);
            this.tabPage_write.Controls.Add(this.label12);
            this.tabPage_write.Controls.Add(this.textBox_InitiatorLogicalAddress);
            this.tabPage_write.Controls.Add(this.label11);
            this.tabPage_write.Controls.Add(this.label10);
            this.tabPage_write.Controls.Add(this.textBox_ReplayAddresses);
            this.tabPage_write.Controls.Add(this.textBox_Key);
            this.tabPage_write.Controls.Add(this.label9);
            this.tabPage_write.Controls.Add(this.groupBox_replyLength);
            this.tabPage_write.Controls.Add(this.groupBox_commandCodes);
            this.tabPage_write.Controls.Add(this.groupBox_packetType);
            this.tabPage_write.Controls.Add(this.textBox_Instruction);
            this.tabPage_write.Controls.Add(this.label4);
            this.tabPage_write.Controls.Add(this.label3);
            this.tabPage_write.Controls.Add(this.textBox_ProtocolIdentifier);
            this.tabPage_write.Controls.Add(this.Button_CreatePacket);
            this.tabPage_write.Controls.Add(this.label2);
            this.tabPage_write.Controls.Add(this.textBox_TargetSpWAddresses);
            this.tabPage_write.Controls.Add(this.label1);
            this.tabPage_write.Controls.Add(this.textBox_TargetLogicalAddresses);
            this.tabPage_write.Location = new System.Drawing.Point(4, 24);
            this.tabPage_write.Name = "tabPage_write";
            this.tabPage_write.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_write.Size = new System.Drawing.Size(805, 480);
            this.tabPage_write.TabIndex = 0;
            this.tabPage_write.Text = "Запрос";
            this.tabPage_write.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(83, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(90, 15);
            this.label21.TabIndex = 41;
            this.label21.Text = "Текущий пакет";
            // 
            // textBox_packet
            // 
            this.textBox_packet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_packet.Location = new System.Drawing.Point(179, 13);
            this.textBox_packet.Name = "textBox_packet";
            this.textBox_packet.Size = new System.Drawing.Size(589, 23);
            this.textBox_packet.TabIndex = 40;
            // 
            // button_parsePacket
            // 
            this.button_parsePacket.Image = ((System.Drawing.Image)(resources.GetObject("button_parsePacket.Image")));
            this.button_parsePacket.Location = new System.Drawing.Point(435, 54);
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
            this.groupBox_endOfPacket.Location = new System.Drawing.Point(442, 417);
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
            this.radioButton_Eep.TabStop = true;
            this.radioButton_Eep.Text = "EEP";
            this.radioButton_Eep.UseVisualStyleBackColor = true;
            // 
            // radioButton_Eop
            // 
            this.radioButton_Eop.AutoSize = true;
            this.radioButton_Eop.Cursor = System.Windows.Forms.Cursors.No;
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
            this.textBox_DataLength.Location = new System.Drawing.Point(179, 359);
            this.textBox_DataLength.Name = "textBox_DataLength";
            this.textBox_DataLength.Size = new System.Drawing.Size(73, 23);
            this.textBox_DataLength.TabIndex = 37;
            this.textBox_DataLength.Text = "0x000040";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(52, 362);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(122, 15);
            this.label20.TabIndex = 36;
            this.label20.Text = "Data Length (3 байта)";
            // 
            // button_daraCRC_calc
            // 
            this.button_daraCRC_calc.Location = new System.Drawing.Point(258, 446);
            this.button_daraCRC_calc.Name = "button_daraCRC_calc";
            this.button_daraCRC_calc.Size = new System.Drawing.Size(86, 23);
            this.button_daraCRC_calc.TabIndex = 34;
            this.button_daraCRC_calc.Text = "Рассчитать";
            this.button_daraCRC_calc.UseVisualStyleBackColor = true;
            this.button_daraCRC_calc.Click += new System.EventHandler(this.button_daraCRC_calc_Click);
            // 
            // textBox_dataCRC
            // 
            this.textBox_dataCRC.Location = new System.Drawing.Point(179, 446);
            this.textBox_dataCRC.Name = "textBox_dataCRC";
            this.textBox_dataCRC.Size = new System.Drawing.Size(73, 23);
            this.textBox_dataCRC.TabIndex = 33;
            this.textBox_dataCRC.Text = "0x00";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(116, 449);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 15);
            this.label19.TabIndex = 32;
            this.label19.Text = "Data CRC";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(75, 391);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 15);
            this.label17.TabIndex = 31;
            this.label17.Text = "Data (по 4 байта)";
            // 
            // textBox_Data
            // 
            this.textBox_Data.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Data.Location = new System.Drawing.Point(179, 388);
            this.textBox_Data.Name = "textBox_Data";
            this.textBox_Data.Size = new System.Drawing.Size(589, 23);
            this.textBox_Data.TabIndex = 30;
            this.textBox_Data.Text = "0x00000000 0x00000000";
            // 
            // button_headerCRC_calc
            // 
            this.button_headerCRC_calc.Location = new System.Drawing.Point(258, 417);
            this.button_headerCRC_calc.Name = "button_headerCRC_calc";
            this.button_headerCRC_calc.Size = new System.Drawing.Size(86, 23);
            this.button_headerCRC_calc.TabIndex = 29;
            this.button_headerCRC_calc.Text = "Рассчитать";
            this.button_headerCRC_calc.UseVisualStyleBackColor = true;
            this.button_headerCRC_calc.Click += new System.EventHandler(this.button_headerCRC_calc_Click);
            // 
            // textBox_headerCRC
            // 
            this.textBox_headerCRC.Location = new System.Drawing.Point(179, 417);
            this.textBox_headerCRC.Name = "textBox_headerCRC";
            this.textBox_headerCRC.Size = new System.Drawing.Size(73, 23);
            this.textBox_headerCRC.TabIndex = 28;
            this.textBox_headerCRC.Text = "0x00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(102, 420);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 15);
            this.label16.TabIndex = 27;
            this.label16.Text = "Header CRC";
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(514, 330);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(73, 23);
            this.textBox_address.TabIndex = 26;
            this.textBox_address.Text = "0x00002100";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(408, 333);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 15);
            this.label15.TabIndex = 25;
            this.label15.Text = "Address (4 байта)";
            // 
            // textBox_extendedAddress
            // 
            this.textBox_extendedAddress.Location = new System.Drawing.Point(513, 301);
            this.textBox_extendedAddress.Name = "textBox_extendedAddress";
            this.textBox_extendedAddress.Size = new System.Drawing.Size(73, 23);
            this.textBox_extendedAddress.TabIndex = 24;
            this.textBox_extendedAddress.Text = "0x00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(407, 304);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 15);
            this.label14.TabIndex = 23;
            this.label14.Text = "Extended Address";
            // 
            // textBox_TransactionIdentifier
            // 
            this.textBox_TransactionIdentifier.Location = new System.Drawing.Point(179, 330);
            this.textBox_TransactionIdentifier.Name = "textBox_TransactionIdentifier";
            this.textBox_TransactionIdentifier.Size = new System.Drawing.Size(73, 23);
            this.textBox_TransactionIdentifier.TabIndex = 22;
            this.textBox_TransactionIdentifier.Text = "0x3925";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 333);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 15);
            this.label12.TabIndex = 21;
            this.label12.Text = "Transaction Identifier (2 байта)";
            // 
            // textBox_InitiatorLogicalAddress
            // 
            this.textBox_InitiatorLogicalAddress.Location = new System.Drawing.Point(179, 301);
            this.textBox_InitiatorLogicalAddress.Name = "textBox_InitiatorLogicalAddress";
            this.textBox_InitiatorLogicalAddress.Size = new System.Drawing.Size(73, 23);
            this.textBox_InitiatorLogicalAddress.TabIndex = 20;
            this.textBox_InitiatorLogicalAddress.Text = "0x4B";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 304);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Initiator Logical Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(75, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Replay Addresses";
            // 
            // textBox_ReplayAddresses
            // 
            this.textBox_ReplayAddresses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ReplayAddresses.Location = new System.Drawing.Point(179, 272);
            this.textBox_ReplayAddresses.Name = "textBox_ReplayAddresses";
            this.textBox_ReplayAddresses.Size = new System.Drawing.Size(589, 23);
            this.textBox_ReplayAddresses.TabIndex = 17;
            this.textBox_ReplayAddresses.Text = "0x08 0x1C 0x04 0x0d";
            // 
            // textBox_Key
            // 
            this.textBox_Key.Location = new System.Drawing.Point(179, 231);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.Size = new System.Drawing.Size(73, 23);
            this.textBox_Key.TabIndex = 16;
            this.textBox_Key.Text = "0x02";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(147, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Key";
            // 
            // groupBox_replyLength
            // 
            this.groupBox_replyLength.Controls.Add(this.radioButton_replyAddrLength_12);
            this.groupBox_replyLength.Controls.Add(this.radioButton_replyAddrLength_8);
            this.groupBox_replyLength.Controls.Add(this.radioButton_replyAddrLength_4);
            this.groupBox_replyLength.Controls.Add(this.radioButton_replyAddrLength_0);
            this.groupBox_replyLength.Location = new System.Drawing.Point(627, 166);
            this.groupBox_replyLength.Name = "groupBox_replyLength";
            this.groupBox_replyLength.Size = new System.Drawing.Size(141, 88);
            this.groupBox_replyLength.TabIndex = 14;
            this.groupBox_replyLength.TabStop = false;
            this.groupBox_replyLength.Text = "Длина reply-адреса";
            // 
            // radioButton_replyAddrLength_12
            // 
            this.radioButton_replyAddrLength_12.AutoSize = true;
            this.radioButton_replyAddrLength_12.Location = new System.Drawing.Point(17, 64);
            this.radioButton_replyAddrLength_12.Name = "radioButton_replyAddrLength_12";
            this.radioButton_replyAddrLength_12.Size = new System.Drawing.Size(65, 19);
            this.radioButton_replyAddrLength_12.TabIndex = 3;
            this.radioButton_replyAddrLength_12.Text = "12 байт";
            this.radioButton_replyAddrLength_12.UseVisualStyleBackColor = true;
            this.radioButton_replyAddrLength_12.CheckedChanged += new System.EventHandler(this.InstructionTextBoxUpdate);
            // 
            // radioButton_replyAddrLength_8
            // 
            this.radioButton_replyAddrLength_8.AutoSize = true;
            this.radioButton_replyAddrLength_8.Location = new System.Drawing.Point(17, 48);
            this.radioButton_replyAddrLength_8.Name = "radioButton_replyAddrLength_8";
            this.radioButton_replyAddrLength_8.Size = new System.Drawing.Size(59, 19);
            this.radioButton_replyAddrLength_8.TabIndex = 2;
            this.radioButton_replyAddrLength_8.Text = "8 байт";
            this.radioButton_replyAddrLength_8.UseVisualStyleBackColor = true;
            this.radioButton_replyAddrLength_8.CheckedChanged += new System.EventHandler(this.InstructionTextBoxUpdate);
            // 
            // radioButton_replyAddrLength_4
            // 
            this.radioButton_replyAddrLength_4.AutoSize = true;
            this.radioButton_replyAddrLength_4.Checked = true;
            this.radioButton_replyAddrLength_4.Location = new System.Drawing.Point(17, 32);
            this.radioButton_replyAddrLength_4.Name = "radioButton_replyAddrLength_4";
            this.radioButton_replyAddrLength_4.Size = new System.Drawing.Size(65, 19);
            this.radioButton_replyAddrLength_4.TabIndex = 1;
            this.radioButton_replyAddrLength_4.TabStop = true;
            this.radioButton_replyAddrLength_4.Text = "4 байта";
            this.radioButton_replyAddrLength_4.UseVisualStyleBackColor = true;
            this.radioButton_replyAddrLength_4.CheckedChanged += new System.EventHandler(this.InstructionTextBoxUpdate);
            // 
            // radioButton_replyAddrLength_0
            // 
            this.radioButton_replyAddrLength_0.AutoSize = true;
            this.radioButton_replyAddrLength_0.Location = new System.Drawing.Point(17, 16);
            this.radioButton_replyAddrLength_0.Name = "radioButton_replyAddrLength_0";
            this.radioButton_replyAddrLength_0.Size = new System.Drawing.Size(59, 19);
            this.radioButton_replyAddrLength_0.TabIndex = 0;
            this.radioButton_replyAddrLength_0.Text = "0 байт";
            this.radioButton_replyAddrLength_0.UseVisualStyleBackColor = true;
            this.radioButton_replyAddrLength_0.CheckedChanged += new System.EventHandler(this.InstructionTextBoxUpdate);
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
            this.groupBox_commandCodes.Location = new System.Drawing.Point(371, 166);
            this.groupBox_commandCodes.Name = "groupBox_commandCodes";
            this.groupBox_commandCodes.Size = new System.Drawing.Size(250, 88);
            this.groupBox_commandCodes.TabIndex = 13;
            this.groupBox_commandCodes.TabStop = false;
            this.groupBox_commandCodes.Text = "Код команды";
            // 
            // checkBox_commandCode_incAddress
            // 
            this.checkBox_commandCode_incAddress.AutoSize = true;
            this.checkBox_commandCode_incAddress.Checked = true;
            this.checkBox_commandCode_incAddress.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_commandCode_incAddress.Location = new System.Drawing.Point(201, 69);
            this.checkBox_commandCode_incAddress.Name = "checkBox_commandCode_incAddress";
            this.checkBox_commandCode_incAddress.Size = new System.Drawing.Size(15, 14);
            this.checkBox_commandCode_incAddress.TabIndex = 7;
            this.checkBox_commandCode_incAddress.UseVisualStyleBackColor = true;
            this.checkBox_commandCode_incAddress.CheckedChanged += new System.EventHandler(this.InstructionTextBoxUpdate);
            // 
            // checkBox_commandCode_reply
            // 
            this.checkBox_commandCode_reply.AutoSize = true;
            this.checkBox_commandCode_reply.Checked = true;
            this.checkBox_commandCode_reply.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_commandCode_reply.Location = new System.Drawing.Point(146, 69);
            this.checkBox_commandCode_reply.Name = "checkBox_commandCode_reply";
            this.checkBox_commandCode_reply.Size = new System.Drawing.Size(15, 14);
            this.checkBox_commandCode_reply.TabIndex = 6;
            this.checkBox_commandCode_reply.UseVisualStyleBackColor = true;
            this.checkBox_commandCode_reply.CheckedChanged += new System.EventHandler(this.InstructionTextBoxUpdate);
            // 
            // checkBox_commandCode_verify
            // 
            this.checkBox_commandCode_verify.AutoSize = true;
            this.checkBox_commandCode_verify.Location = new System.Drawing.Point(91, 69);
            this.checkBox_commandCode_verify.Name = "checkBox_commandCode_verify";
            this.checkBox_commandCode_verify.Size = new System.Drawing.Size(15, 14);
            this.checkBox_commandCode_verify.TabIndex = 5;
            this.checkBox_commandCode_verify.UseVisualStyleBackColor = true;
            this.checkBox_commandCode_verify.CheckedChanged += new System.EventHandler(this.InstructionTextBoxUpdate);
            // 
            // checkBox_commandCode_rw
            // 
            this.checkBox_commandCode_rw.AutoSize = true;
            this.checkBox_commandCode_rw.Location = new System.Drawing.Point(36, 69);
            this.checkBox_commandCode_rw.Name = "checkBox_commandCode_rw";
            this.checkBox_commandCode_rw.Size = new System.Drawing.Size(15, 14);
            this.checkBox_commandCode_rw.TabIndex = 4;
            this.checkBox_commandCode_rw.UseVisualStyleBackColor = true;
            this.checkBox_commandCode_rw.CheckedChanged += new System.EventHandler(this.InstructionTextBoxUpdate);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 30);
            this.label8.TabIndex = 3;
            this.label8.Text = "Increment\r\n  address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Write/\r\n Read";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 45);
            this.label6.TabIndex = 1;
            this.label6.Text = "Verify data\r\n    before \r\n     write";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(133, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Reply";
            // 
            // groupBox_packetType
            // 
            this.groupBox_packetType.Controls.Add(this.radioButton_packetType_reply);
            this.groupBox_packetType.Controls.Add(this.radioButton_packetType_command);
            this.groupBox_packetType.Location = new System.Drawing.Point(281, 166);
            this.groupBox_packetType.Name = "groupBox_packetType";
            this.groupBox_packetType.Size = new System.Drawing.Size(84, 88);
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
            this.radioButton_packetType_reply.CheckedChanged += new System.EventHandler(this.InstructionTextBoxUpdate);
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
            this.radioButton_packetType_command.CheckedChanged += new System.EventHandler(this.InstructionTextBoxUpdate);
            // 
            // textBox_Instruction
            // 
            this.textBox_Instruction.Location = new System.Drawing.Point(179, 202);
            this.textBox_Instruction.Name = "textBox_Instruction";
            this.textBox_Instruction.Size = new System.Drawing.Size(73, 23);
            this.textBox_Instruction.TabIndex = 11;
            this.textBox_Instruction.Text = "0x4d";
            this.textBox_Instruction.TextChanged += new System.EventHandler(this.InstructionControlsUpdate);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Instruction";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Protocol Identifier";
            // 
            // textBox_ProtocolIdentifier
            // 
            this.textBox_ProtocolIdentifier.Location = new System.Drawing.Point(179, 173);
            this.textBox_ProtocolIdentifier.Name = "textBox_ProtocolIdentifier";
            this.textBox_ProtocolIdentifier.Size = new System.Drawing.Size(73, 23);
            this.textBox_ProtocolIdentifier.TabIndex = 8;
            this.textBox_ProtocolIdentifier.Text = "0x01";
            // 
            // Button_CreatePacket
            // 
            this.Button_CreatePacket.Image = ((System.Drawing.Image)(resources.GetObject("Button_CreatePacket.Image")));
            this.Button_CreatePacket.Location = new System.Drawing.Point(179, 54);
            this.Button_CreatePacket.Name = "Button_CreatePacket";
            this.Button_CreatePacket.Size = new System.Drawing.Size(109, 24);
            this.Button_CreatePacket.TabIndex = 5;
            this.Button_CreatePacket.UseVisualStyleBackColor = true;
            this.Button_CreatePacket.Click += new System.EventHandler(this.button_packetGenerate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Target Logical Address";
            // 
            // textBox_TargetSpWAddresses
            // 
            this.textBox_TargetSpWAddresses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_TargetSpWAddresses.Location = new System.Drawing.Point(179, 96);
            this.textBox_TargetSpWAddresses.Name = "textBox_TargetSpWAddresses";
            this.textBox_TargetSpWAddresses.Size = new System.Drawing.Size(589, 23);
            this.textBox_TargetSpWAddresses.TabIndex = 0;
            this.textBox_TargetSpWAddresses.Text = "0x00 0x00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Target SpW Addresses";
            // 
            // textBox_TargetLogicalAddresses
            // 
            this.textBox_TargetLogicalAddresses.Location = new System.Drawing.Point(179, 125);
            this.textBox_TargetLogicalAddresses.Name = "textBox_TargetLogicalAddresses";
            this.textBox_TargetLogicalAddresses.Size = new System.Drawing.Size(73, 23);
            this.textBox_TargetLogicalAddresses.TabIndex = 2;
            this.textBox_TargetLogicalAddresses.Text = "0xFE";
            // 
            // tabPage_reply
            // 
            this.tabPage_reply.Location = new System.Drawing.Point(4, 24);
            this.tabPage_reply.Name = "tabPage_reply";
            this.tabPage_reply.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_reply.Size = new System.Drawing.Size(805, 480);
            this.tabPage_reply.TabIndex = 1;
            this.tabPage_reply.Text = "Ответ";
            this.tabPage_reply.UseVisualStyleBackColor = true;
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
            this.textBox_Console.Size = new System.Drawing.Size(805, 122);
            this.textBox_Console.TabIndex = 7;
            // 
            // consoleContextMenu
            // 
            this.consoleContextMenu.Name = "clearConsole";
            this.consoleContextMenu.Size = new System.Drawing.Size(61, 4);
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
            this.clearMenuItem.Click += clearMenuItem_Click;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 659);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(850, 600);
            this.Name = "Form_main";
            this.Text = "RMAP tolmach";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl_selectCommand.ResumeLayout(false);
            this.tabPage_write.ResumeLayout(false);
            this.tabPage_write.PerformLayout();
            this.groupBox_endOfPacket.ResumeLayout(false);
            this.groupBox_endOfPacket.PerformLayout();
            this.groupBox_replyLength.ResumeLayout(false);
            this.groupBox_replyLength.PerformLayout();
            this.groupBox_commandCodes.ResumeLayout(false);
            this.groupBox_commandCodes.PerformLayout();
            this.groupBox_packetType.ResumeLayout(false);
            this.groupBox_packetType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl_selectCommand;
        private System.Windows.Forms.TabPage tabPage_write;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_TargetSpWAddresses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_TargetLogicalAddresses;
        private System.Windows.Forms.TabPage tabPage_reply;
        private System.Windows.Forms.TextBox textBox_Console;
        private System.Windows.Forms.ContextMenuStrip consoleContextMenu;
        private System.Windows.Forms.Button Button_CreatePacket;
        private System.Windows.Forms.TextBox textBox_ProtocolIdentifier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Instruction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox_packetType;
        private System.Windows.Forms.RadioButton radioButton_packetType_reply;
        private System.Windows.Forms.RadioButton radioButton_packetType_command;
        private System.Windows.Forms.GroupBox groupBox_commandCodes;
        private System.Windows.Forms.CheckBox checkBox_commandCode_incAddress;
        private System.Windows.Forms.CheckBox checkBox_commandCode_reply;
        private System.Windows.Forms.CheckBox checkBox_commandCode_verify;
        private System.Windows.Forms.CheckBox checkBox_commandCode_rw;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox_replyLength;
        private System.Windows.Forms.RadioButton radioButton_replyAddrLength_12;
        private System.Windows.Forms.RadioButton radioButton_replyAddrLength_8;
        private System.Windows.Forms.RadioButton radioButton_replyAddrLength_4;
        private System.Windows.Forms.RadioButton radioButton_replyAddrLength_0;
        private System.Windows.Forms.TextBox textBox_headerCRC;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_extendedAddress;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_TransactionIdentifier;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_InitiatorLogicalAddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_ReplayAddresses;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button_daraCRC_calc;
        private System.Windows.Forms.TextBox textBox_dataCRC;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox_Data;
        private System.Windows.Forms.Button button_headerCRC_calc;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox_DataLength;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox_endOfPacket;
        private System.Windows.Forms.RadioButton radioButton_Eep;
        private System.Windows.Forms.RadioButton radioButton_Eop;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox_packet;
        private System.Windows.Forms.Button button_parsePacket;
        private System.Windows.Forms.ToolStripMenuItem copyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearMenuItem;
    }
}

