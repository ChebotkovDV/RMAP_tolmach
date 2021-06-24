using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMAP_tolmach
{
    public partial class Form_main : Form
    {
        
        private RmapPacket CurrentPacket { get; set; }

        public Form_main()
        {
            InitializeComponent();

            this.consoleContextMenu.Items.AddRange(new[] { clearMenuItem, copyMenuItem });
            this.copyMenuItem.Click += CopyMenuItem_Click;
            this.clearMenuItem.Click += ClearMenuItem_Click;
            this.statusMenuItem.Click += StatusMenuItem_Click;

            CurrentPacket = new RmapPacket();
            UpdateAllFields();
        }

        private void ClearMenuItem_Click(object sender, EventArgs e)
        {
            textBox_Console.Clear();
        }
        private void StatusMenuItem_Click(object sender, EventArgs e)
        {
            Report(CurrentPacket.FieldsStatus);
        }
        private void CopyMenuItem_Click(object sender, EventArgs e)
        {
            // если выделен текст в текстовом поле, то копируем его в буфер
            Clipboard.SetText(textBox_Console.SelectedText);
        }
        private void button_packetGenerate_Click(object sender, EventArgs e)
        {
            UpdateAllFields();
            textBox_packet.Text = CurrentPacket.GetRMAPPacket();
            Report("---  Создан новый пакет   ---");
            Report(CurrentPacket.GetReport);
        }
        private void button_parsePacket_Click(object sender, EventArgs e)
        {
            Report("--- Парсинг нового пакета:  -----");
            CurrentPacket.TargetLogicalAddresses.Set(textBox_TargetLogicalAddresses.Text);
            CurrentPacket.InitiatorLogicalAddress.Set(textBox_InitiatorLogicalAddress.Text);
            CurrentPacket.ProtocolIdentifier.Set(textBox_ProtocolIdentifier.Text);

            if (CurrentPacket.TargetLogicalAddresses.Fail || CurrentPacket.InitiatorLogicalAddress.Fail || CurrentPacket.ProtocolIdentifier.Fail)
            {
                Report("Ошибка : Одно или несколько ключевых полей (TargetLogicalAddresses, InitiatorLogicalAddress, ProtocolIdentifier) заполнено не корректно.");
                return;
            }

            CurrentPacket.Parse(textBox_packet.Text, out string log);
            if (log != "")
            {
                Report(log);
            }
            else
            {
                UpdateAllControls();
                Report(CurrentPacket.GetReport + "\r\n");
            }
        }
        private void button_headerCRC_calc_Click(object sender, EventArgs e)
        {
            UpdateAllFields();
            CurrentPacket.UpdateHeaderCrc();
            textBox_headerCRC.Text = CurrentPacket.HeaderCRC.ToString("0x","");

        }
        private void button_daraCRC_calc_Click(object sender, EventArgs e)
        {
            UpdateAllFields();
            CurrentPacket.UpdateDataCrc();
            textBox_dataCRC.Text = CurrentPacket.DataCRC.ToString("0x", "");
        }

        private void TextBoxInstruction_Chenged(object sender, EventArgs e)
        {
            CurrentPacket.Instruction.Set(textBox_Instruction.Text);
            if (CurrentPacket.Instruction.Fail)
            {
                return;
            }
            // отписываем InstructionTextBoxUpdate от событий, чтобы не зациклиться:
            checkBox_commandCodeIncrement.CheckedChanged -= new System.EventHandler(this.InstructionControls_Chenged);
            checkBox_commandCodeWrite.CheckedChanged -= new System.EventHandler(this.InstructionControls_Chenged);
            checkBox_commandCodeVerify.CheckedChanged -= new System.EventHandler(this.InstructionControls_Chenged);
            checkBox_commandCodeReply.CheckedChanged -= new System.EventHandler(this.InstructionControls_Chenged);
            radioButton_packetType_reply.CheckedChanged -= new System.EventHandler(this.InstructionControls_Chenged);
            radioButton_packetType_command.CheckedChanged -= new System.EventHandler(this.InstructionControls_Chenged);
            radioButton_replyAddrLength_0.CheckedChanged -= new System.EventHandler(this.InstructionControls_Chenged);
            radioButton_replyAddrLength_4.CheckedChanged -= new System.EventHandler(this.InstructionControls_Chenged);
            radioButton_replyAddrLength_8.CheckedChanged -= new System.EventHandler(this.InstructionControls_Chenged);
            radioButton_replyAddrLength_12.CheckedChanged -= new System.EventHandler(this.InstructionControls_Chenged);
            // обновляем элементы управления
            checkBox_commandCodeWrite.Checked = CurrentPacket.Instruction.CommandType[3];
            checkBox_commandCodeVerify.Checked = CurrentPacket.Instruction.CommandType[2];
            checkBox_commandCodeReply.Checked = CurrentPacket.Instruction.CommandType[1];
            checkBox_commandCodeIncrement.Checked = CurrentPacket.Instruction.CommandType[0];
            radioButton_packetType_reply.Checked = CurrentPacket.Instruction.IsReply;
            radioButton_packetType_command.Checked = CurrentPacket.Instruction.IsCommand;
            radioButton_replyAddrLength_0.Checked = CurrentPacket.Instruction.GetReplyAddressLength == 0;
            radioButton_replyAddrLength_4.Checked = CurrentPacket.Instruction.GetReplyAddressLength == 4;
            radioButton_replyAddrLength_8.Checked = CurrentPacket.Instruction.GetReplyAddressLength == 8;
            radioButton_replyAddrLength_12.Checked = CurrentPacket.Instruction.GetReplyAddressLength == 12;
            // Возвращаем подписку на события
            checkBox_commandCodeIncrement.CheckedChanged += new System.EventHandler(this.InstructionControls_Chenged);
            checkBox_commandCodeWrite.CheckedChanged += new System.EventHandler(this.InstructionControls_Chenged);
            checkBox_commandCodeVerify.CheckedChanged += new System.EventHandler(this.InstructionControls_Chenged);
            checkBox_commandCodeReply.CheckedChanged += new System.EventHandler(this.InstructionControls_Chenged);
            radioButton_packetType_reply.CheckedChanged += new System.EventHandler(this.InstructionControls_Chenged);
            radioButton_packetType_command.CheckedChanged += new System.EventHandler(this.InstructionControls_Chenged);
            radioButton_replyAddrLength_0.CheckedChanged += new System.EventHandler(this.InstructionControls_Chenged);
            radioButton_replyAddrLength_4.CheckedChanged += new System.EventHandler(this.InstructionControls_Chenged);
            radioButton_replyAddrLength_8.CheckedChanged += new System.EventHandler(this.InstructionControls_Chenged);
            radioButton_replyAddrLength_12.CheckedChanged += new System.EventHandler(this.InstructionControls_Chenged);

            DisableUnusedControls();
        }

        private void InstructionControls_Chenged(object sender, EventArgs e)
        {
            CurrentPacket.Instruction.SetPacketType(radioButton_packetType_command.Checked, radioButton_packetType_reply.Checked);
            CurrentPacket.Instruction.SetCommandType(checkBox_commandCodeWrite.Checked, checkBox_commandCodeVerify.Checked,
                checkBox_commandCodeReply.Checked, checkBox_commandCodeIncrement.Checked);
            CurrentPacket.Instruction.SetReplyAddressLength(radioButton_replyAddrLength_0.Checked, radioButton_replyAddrLength_4.Checked,
                radioButton_replyAddrLength_8.Checked, radioButton_replyAddrLength_12.Checked);

            textBox_Instruction.TextChanged -= new System.EventHandler(this.TextBoxInstruction_Chenged);
            textBox_Instruction.Text = CurrentPacket.Instruction.ToString();
            textBox_Instruction.TextChanged += new System.EventHandler(this.TextBoxInstruction_Chenged);
            DisableUnusedControls();
        }

        private void DisableUnusedControls()
        {
            bool isReply = CurrentPacket.Instruction.IsReply;
            bool isCommand = CurrentPacket.Instruction.IsCommand;
            bool dataFieldExist = CurrentPacket.Instruction.DataExist;
            EnabledControlsOfStatusField(isReply);
            EnabledControlsOfReplayAddressesField(isCommand);
            EnabledControlsOfAddressField(isCommand);
            EnabledControlsOfKeyField(isCommand);
            EnabledControlsOfDataFields(dataFieldExist);
            EnabledControlsOfDataLengthFields(dataFieldExist || isCommand);
        }
        private void EnabledControlsOfStatusField(bool enable)
        {
            textBox_Status.Enabled = enable;
            label_Status.Enabled = enable;
        }
        private void EnabledControlsOfReplayAddressesField(bool enable)
        {
            textBox_ReplayAddresses.Enabled = enable;
            label_ReplayAddress.Enabled = enable;
        }
        private void EnabledControlsOfAddressField(bool enable)
        {
            textBox_extendedAddress.Enabled = enable;
            textBox_address.Enabled = enable;
            label_ExtendedAddress.Enabled = enable;
            label_Address.Enabled = enable;
        }
        private void EnabledControlsOfKeyField(bool enable)
        {
            label_Key.Enabled = enable;
            textBox_Key.Enabled = enable;
        }
        private void EnabledControlsOfDataLengthFields(bool enable)
        {
            textBox_DataLength.Enabled = enable;
            label_DataLength.Enabled = enable;
        }
        private void EnabledControlsOfDataFields(bool enable)
        {
            textBox_Data.Enabled = enable;
            textBox_dataCRC.Enabled = enable;
            label_Data.Enabled = enable;
            label_DataCrc.Enabled = enable;
            button_daraCRC_calc.Enabled = enable;
        }
        
        private void UpdateAllControls()
        {
            textBox_TargetSpWAddresses.Text = CurrentPacket.SpwAddresses.ToString(" 0x","","");
            textBox_ProtocolIdentifier.Text = CurrentPacket.ProtocolIdentifier.ToString("0x", "");
            textBox_Instruction.Text = CurrentPacket.Instruction.ToString("0x", "");
            textBox_Key.Text = CurrentPacket.Key.ToString("0x", "");
            textBox_Status.Text = CurrentPacket.Status.ToString("0x", "");
            textBox_ReplayAddresses.Text = CurrentPacket.ReplyAddresses.ToString(" 0x", "", "");
            textBox_InitiatorLogicalAddress.Text = CurrentPacket.InitiatorLogicalAddress.ToString("0x", "");
            textBox_TransactionIdentifier.Text = CurrentPacket.TransactionIdentifier.ToString("0x", "");
            textBox_extendedAddress.Text = CurrentPacket.ExtendedAddress.ToString("0x", "");
            textBox_address.Text = CurrentPacket.Address.ToString("0x", "");
            textBox_DataLength.Text = CurrentPacket.DataLength.ToString("0x", "");
            textBox_headerCRC.Text = CurrentPacket.HeaderCRC.ToString("0x", "");
            textBox_Data.Text = CurrentPacket.Data.ToString(" 0x", "", "");
            textBox_dataCRC.Text = CurrentPacket.DataCRC.ToString("0x", "");
            radioButton_Eep.Checked = CurrentPacket.EEP;
        }

        private void UpdateAllFields()
        {
            CurrentPacket.SpwAddresses.Set(textBox_TargetSpWAddresses.Text);
            CurrentPacket.TargetLogicalAddresses.Set(textBox_TargetLogicalAddresses.Text);
            CurrentPacket.ProtocolIdentifier.Set(textBox_ProtocolIdentifier.Text);
            CurrentPacket.Instruction.Set(textBox_Instruction.Text);
            CurrentPacket.Key.Set(textBox_Key.Text);
            CurrentPacket.Status.Set(textBox_Status.Text);
            CurrentPacket.ReplyAddresses.Set(textBox_ReplayAddresses.Text);
            CurrentPacket.InitiatorLogicalAddress.Set(textBox_InitiatorLogicalAddress.Text);
            CurrentPacket.TransactionIdentifier.Set(textBox_TransactionIdentifier.Text);
            CurrentPacket.ExtendedAddress.Set(textBox_extendedAddress.Text);
            CurrentPacket.Address.Set(textBox_address.Text);
            CurrentPacket.DataLength.Set(textBox_DataLength.Text);
            CurrentPacket.HeaderCRC.Set(textBox_headerCRC.Text);
            CurrentPacket.Data.Set(textBox_Data.Text);
            CurrentPacket.DataCRC.Set(textBox_dataCRC.Text);
            CurrentPacket.EEP = radioButton_Eep.Checked;
            if (CurrentPacket.Fail)
            {
                Report("одно или несколько полей заполнено не корректно");
            }
        }
        private void Report(string rep)
        {
            textBox_Console.AppendText(rep + "\r\n");
        }
    }
}
